using Microsoft.Data.SqlClient;

namespace Proyecto2.logicadeaccesoadatos
{
    internal class BaseDeDatos
    {
        // Cadena de conexión para conectar a SQL Server
        private static readonly string connectionString =
            "Data Source=Lenovo_AGC;Initial Catalog=VIDEOTECAUNED;Integrated Security=True;TrustServerCertificate=True";

        // Método para obtener una conexión abierta a la base de datos
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            return conexion;
        }

        // Método para cerrar la conexión
        public static void CerrarConexion(SqlConnection conexion)
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }
    }
}
