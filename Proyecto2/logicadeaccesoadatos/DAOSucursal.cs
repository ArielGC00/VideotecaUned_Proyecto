using Microsoft.Data.SqlClient;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto2.logicadeaccesoadatos
{
    internal class DAOSucursal
    {
        public void registrarSucursal(int idSucursal, int idEncargado, string nombre, string Direccion, string telefono,bool activo)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO Sucursal (IdSucursal, IdEncargado, Nombre, Direccion, Telefono, Activo) VALUES (@idSucursal,@idEncargado, @nombre,@Direccion,@telefono, @activo)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idSucursal", idSucursal);
                    comando.Parameters.AddWithValue("@idEncargado", idEncargado);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@Direccion", Direccion);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@activo", activo);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
        }

        public List<Sucursal> obtenerSucursal()
        {
            List<Sucursal> listaSucursales = new List<Sucursal>();

            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = @"Select s.IdSucursal,
		                            s.IdEncargado,
		                            s.Nombre,
		                            s.Direccion,
		                            s.Telefono,
		                            s.Activo,
		                            p.Identificacion,
		                            p.Nombre,
		                            p.PrimerApellido,
		                            p.SegundoApellido,
		                            p.FechaNacimiento,
		
		                            e.FechaIngreso
                            From Sucursal s
                            JOIN Encargado e ON s.IdEncargado=e.IdEncargado
                            JOIN Persona p ON p.Identificacion=e.Identificacion";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idSucursal = reader.GetInt32(0);
                            int idEncargado = reader.GetInt32(1);
                            string nombreSucursal = reader.GetString(2);
                            string direccion = reader.GetString(3);
                            string telefono = reader.GetString(4);
                            bool sucursalActiva = reader.GetBoolean(5);
                            string cedulaEncargado = reader.GetString(6);
                            string nombreEncargado = reader.GetString(7);
                            string primerApellido = reader.GetString(8);
                            string segundoApelldio= reader.GetString(9);
                            DateTime fechaNacimiento = reader.GetDateTime(10);
                            DateTime fechaIngreso= reader.GetDateTime(11);
                            Encargado encargado=new Encargado(cedulaEncargado,nombreEncargado,primerApellido,segundoApelldio,fechaNacimiento,idEncargado,fechaIngreso);
                            Sucursal sucursal = new Sucursal(idSucursal,nombreSucursal,encargado,direccion,telefono,sucursalActiva);
                           

                            listaSucursales.Add(sucursal);
                        }
                    }
                }
            }
            return listaSucursales;
        }
        public void mostrarClientes()
        {
            List<Sucursal> sucursales = obtenerSucursal();

            foreach (Sucursal sucursal in sucursales)
            {
                Console.WriteLine($"idSucursal: {sucursal.idSucursal}, Encargado: {sucursal.encargado.Nombre}");
            }
        }
    }
}
