using Microsoft.Data.SqlClient;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadeaccesoadatos
{
    internal class DAOCliente
    {
        public void registrarPersonaCliente(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int idCliente, DateTime fechaRegistro,bool activo)
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
            registrarCliente(identificacion, idCliente, fechaRegistro,activo);
        }
        private void registrarCliente(string identificacion, int idCliente, DateTime fechaRegistro, bool activo)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO Cliente (IdCliente, Identificacion, FechaRegistro, Activo) VALUES (@idCliente,@identificacion, @fechaRegistro, @activo)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@identificacion", identificacion);
                    comando.Parameters.AddWithValue("@idCliente", idCliente);
                    comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                    comando.Parameters.AddWithValue("@activo", activo);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
        }

        public List<Cliente> obtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta  = @"SELECT 
                                        c.IdCliente, 
                                        c.FechaRegistro, 
                                        p.Nombre, 
                                        p.PrimerApellido, 
                                        p.SegundoApellido, 
                                        c.Activo, 
                                        p.FechaNacimiento, 
                                        c.Identificacion
                                    FROM Cliente c
                                    JOIN Persona p ON c.Identificacion = p.Identificacion";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                IdCliente = reader.GetInt32(0),
                                FechaRegistro = reader.GetDateTime(1),
                                Nombre = reader.GetString(2),
                                PrimerApellido = reader.GetString(3),
                                SegundoApellido = reader.GetString(4),
                                Activo = reader.GetBoolean(5),
                                
                                FechaNacimiento=reader.GetDateTime(6),
                                Identificacion = reader.GetString(7)
                            };

                            listaClientes.Add(cliente);
                        }
                    }
                }
            }
            return listaClientes;
        }
        public void mostrarClientes()
        {
            List<Cliente> clientes = obtenerClientes();

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"IdCliente: {cliente.IdCliente}, Cedula: {cliente.Identificacion}");
            }
        }
    }
}
