using Microsoft.Data.SqlClient;
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
    }
}
