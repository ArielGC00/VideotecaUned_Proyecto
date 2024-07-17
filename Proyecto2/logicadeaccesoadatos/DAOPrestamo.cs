using Microsoft.Data.SqlClient;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadeaccesoadatos
{
    internal class DAOPrestamo
    {
        public void registrarPrestamo( int idCliente, int idSucursal, int idPelicula, DateTime fechaPrestamo, bool pendienteDevolucion)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO Prestamo ( IdCliente, IdSucursal, IdPelicula, FechaPrestamo,PendienteDevolucion) VALUES (@idCliente, @idSucursal,@idPelicula,@fechaPrestamo,@pendienteDevolucion)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idCliente", idCliente);
                    comando.Parameters.AddWithValue("@idSucursal", idSucursal);
                    comando.Parameters.AddWithValue("@idPelicula", idPelicula);
                    comando.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
                    comando.Parameters.AddWithValue("@pendienteDevolucion", pendienteDevolucion);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
           
        }
        public List<Prestamo> obtenerPrestamosPorCliente(int idCliente)
        {
            List<Prestamo> prestamos = new List<Prestamo>();

            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "SELECT IdPrestamo, IdCliente, IdSucursal, IdPelicula, FechaPrestamo, PendienteDevolucion FROM Prestamo WHERE IdCliente = @idCliente";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idCliente", idCliente);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())

                        {
                            int idPrestamo = reader.GetInt32(0);
                            idCliente = reader.GetInt32(1);
                            int idSucursal=reader.GetInt32(2);
                            int idPelicula=reader.GetInt32(3);
                            DateTime fechaPrestamo= reader.GetDateTime(4);
                            bool pendienteDevolucion=reader.GetBoolean(5);

                            Prestamo prestamo = new Prestamo(idPrestamo,idCliente,idPelicula,fechaPrestamo,pendienteDevolucion);
                            
                            prestamos.Add(prestamo);
                        }
                    }
                }
            }

            return prestamos;
        }

    }
}
