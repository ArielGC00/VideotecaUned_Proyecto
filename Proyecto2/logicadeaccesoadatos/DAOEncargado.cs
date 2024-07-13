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
    internal class DAOEncargado
    {
        public void registrarPersonaEncargada(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int idEncargado ,DateTime fechaIngreso)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO Persona (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento) VALUES (@identificacion,@nombre, @primerApellido,@segundoApellido,@fechaNacimiento)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@identificacion", identificacion);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@primerApellido", primerApellido);
                    comando.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                    comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
            registrarEncargado(identificacion, idEncargado, fechaIngreso);
        }
        private void registrarEncargado(string identificacion, int idEncargado, DateTime fechaIngreso) {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO Encargado (IdEncargado, Identificacion, FechaIngreso) VALUES (@idEncargado,@identificacion, @fechaIngreso)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@identificacion", identificacion);
                    comando.Parameters.AddWithValue("@idEncargado", idEncargado);
                    comando.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
        }
        public List<Encargado> obtenerEncargados()
        {
            List<Encargado> listaEcargados = new List<Encargado>();

            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = @"Select e.IdEncargado,
		                            e.FechaIngreso,
		                            e.Identificacion,
		                            p.Nombre,
		                            p.PrimerApellido,
		                            p.SegundoApellido,
		                            p.FechaNacimiento
                            FROM Encargado e
                            JOIN Persona p ON e.Identificacion=p.Identificacion";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Encargado encargado = new Encargado
                            {
                                IdEncargado = reader.GetInt32(0),
                                FechaIngreso = reader.GetDateTime(1),
                                Identificacion = reader.GetString(2),
                                Nombre = reader.GetString(3),
                                PrimerApellido = reader.GetString(4),
                                SegundoApellido = reader.GetString(5),
                                FechaNacimiento = reader.GetDateTime(6),
                                
                            };

                            listaEcargados.Add(encargado);
                        }
                    }
                }
            }
            return listaEcargados;
        }
        public void mostrarClientes()
        {
            List<Encargado> clientes = obtenerEncargados();

            foreach (Encargado cliente in clientes)
            {
                Console.WriteLine($"IdEncargado: {cliente.IdEncargado}, Cedula: {cliente.Identificacion}, fechaIngreso:{cliente.FechaNacimiento}");
                
            }
        }
    }
}
