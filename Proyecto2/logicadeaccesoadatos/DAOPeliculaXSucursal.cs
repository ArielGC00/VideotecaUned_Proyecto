using Microsoft.Data.SqlClient;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadeaccesoadatos
{
    internal class DAOPeliculaXSucursal
    {
        public void registrarPeliculaSucursal(int idSucursal, int idPelicula, int cantidad)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO PeliculaXSucursal (IdSucursal, IdPelicula, Cantidad) VALUES (@idSucursal,@idPelicula, @cantidad)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idSucursal", idSucursal);
                    comando.Parameters.AddWithValue("@idPelicula", idPelicula);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
        }
        public List<PeliculaXSucursal> obtenerPeliculasXSucursal()
        {
            List<PeliculaXSucursal> listaPeliculasXSucursal = new List<PeliculaXSucursal>();

            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = @"SELECT 
		                                    ps.IdSucursal,
		                                    ps.IdPelicula,
		                                    ps.Cantidad,
		                                    pl.IdCategoria,
		                                    pl.Titulo,
		                                    pl.AnioLanzamiento,
		                                    pl.Idioma,
		                                    c.NombreCategoria,
		                                    c.Descripcion,
		                                    s.IdEncargado,
		                                    s.Nombre,
		                                    s.Direccion,
		                                    s.Telefono,
		                                    s.Activo,
		                                    e.Identificacion,
		                                    e.FechaIngreso,
		                                    p.Nombre,
		                                    p.PrimerApellido,
		                                    p.SegundoApellido,
		                                    p.FechaNacimiento
                                    FROM PeliculaxSucursal ps
                                    JOIN Pelicula pl ON ps.IdPelicula=pl.IdPelicula
                                    JOIN CategoriaPelicula c ON pl.IdCategoria=c.IdCategoria
                                    JOIN Sucursal s ON ps.IdSucursal=s.IdSucursal
                                    JOIN Encargado e ON s.IdEncargado=e.IdEncargado
                                    JOIN Persona p ON e.Identificacion=p.Identificacion
                                     ";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idSucursal = reader.GetInt32(0);
                            int idPelicula = reader.GetInt32(1);
                            int cantidad=reader.GetInt32(2);
                            int idCategoria = reader.GetInt32(3);
                            string titulo = reader.GetString(4);
                            int anioLanzamiento = reader.GetInt32(5);
                            string idioma = reader.GetString(6);
                            string nombreCategoria = reader.GetString(7);
                            string descripcionPelicula = reader.GetString(8);
                            int idEncargado=reader.GetInt32(9);
                            string nombreSucursal= reader.GetString(10);
                            string direccionSucursal = reader.GetString(11);
                            string telefonoSucursal = reader.GetString(12);
                            bool sucursalActiva=reader.GetBoolean(13);
                            string cedulaEncargado=reader.GetString(14);
                            DateTime fechaIngreso=reader.GetDateTime(15);
                            string nombreEncargado = reader.GetString(16);
                            string primerApellido=reader.GetString(17);
                            string segundoApellido =reader.GetString(18);
                            DateTime fechaNacimiento=reader.GetDateTime(19);
                            Encargado encargado=new Encargado(cedulaEncargado,nombreEncargado,primerApellido,segundoApellido,fechaNacimiento,idEncargado,fechaIngreso);
                            Sucursal sucursal = new Sucursal(idSucursal,nombreSucursal,encargado,direccionSucursal,telefonoSucursal,sucursalActiva);
                            Categoria categoria = new Categoria(idCategoria, nombreCategoria, descripcionPelicula);
                            Pelicula pelicula = new Pelicula(idPelicula, titulo, categoria, anioLanzamiento, idioma);
                            PeliculaXSucursal peliculaXSucursal = new PeliculaXSucursal(sucursal, pelicula, cantidad);


                            listaPeliculasXSucursal.Add(peliculaXSucursal);
                        }
                    }
                }
            }
            return listaPeliculasXSucursal;
        }
        public void actualizarCantidadPelicula(int idSucursal, int idPelicula)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "UPDATE PeliculaXSucursal SET Cantidad=Cantidad-1 WHERE IdPelicula=@IdPelicula AND IdSucursal=@IdSucursal";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdSucursal", idSucursal);
                    comando.Parameters.AddWithValue("@IdPelicula", idPelicula);


                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }

        }

        public void mostrarClientes()
        {
            List<PeliculaXSucursal> clientes = obtenerPeliculasXSucursal();

            foreach (PeliculaXSucursal cliente in clientes)
            {
                string pelicula = cliente.pelicula.titulo;
                string categorita= cliente.pelicula.categoria.nombreCategoria;
              //  string sucursal = cliente.sucursal.nombreSucursal;
                string encargado= cliente.sucursal.encargado.PrimerApellido;
                int cantidad = cliente.cantidad;
            }
        }
    }
}
