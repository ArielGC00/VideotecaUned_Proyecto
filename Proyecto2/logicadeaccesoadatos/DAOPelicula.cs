using Microsoft.Data.SqlClient;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadeaccesoadatos
{
    internal class DAOPelicula
    {
        public void registrarPelicula(int idPelicula,int idCategoria, string titulo, string idioma, int anioLanzamiento)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO Pelicula (IdPelicula, IdCategoria, Titulo, AnioLanzamiento, Idioma) VALUES (@idPelicula,@idCategoria, @titulo,@anioLanzamiento,@idioma)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idPelicula", idPelicula);
                    comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                    comando.Parameters.AddWithValue("@titulo", titulo);
                    comando.Parameters.AddWithValue("@anioLanzamiento", anioLanzamiento);
                    comando.Parameters.AddWithValue("@idioma", idioma);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
        }
        public List<Pelicula> obtenerPeliculas()
        {
            List<Pelicula> listaPeliculas = new List<Pelicula>();

            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = @"SELECT 
		                            pl.IdPelicula,
		                            pl.IdCategoria,
		                            pl.Titulo,
		                            pl.AnioLanzamiento,
		                            pl.Idioma,
		                            c.NombreCategoria,
		                            c.Descripcion
                            FROM Pelicula pl
                            JOIN CategoriaPelicula c ON pl.IdCategoria=c.IdCategoria";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPelicula = reader.GetInt32(0);
                            int idCategoria = reader.GetInt32(1);
                            string titulo = reader.GetString(2);
                            int anioLanzamiento = reader.GetInt32(3);
                            string idioma = reader.GetString(4);
                            string nombreCategoria= reader.GetString(5);
                            string descripcionPelicula= reader.GetString(6);
                            Categoria categoria = new Categoria(idCategoria,nombreCategoria,descripcionPelicula);
                            Pelicula pelicula = new Pelicula(idPelicula,titulo,categoria,anioLanzamiento,idioma);


                            listaPeliculas.Add(pelicula);
                        }
                    }
                }
            }
            return listaPeliculas;
        }
        public void mostrarClientes()
        {
            List<Pelicula> clientes = obtenerPeliculas();

            foreach (Pelicula cliente in clientes)
            {
                int categoria = cliente.idPelicula;
                string nombre = cliente.categoria.nombreCategoria;
                string descripcion = cliente.titulo;
            }
        }
    }
}
