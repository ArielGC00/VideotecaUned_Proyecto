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
    internal class DAOCategoria
    {
        public void registrarCategoria(int id, string nombreCategoria, string descripcion)
        {
            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO CategoriaPelicula (IdCategoria, NombreCategoria, Descripcion) VALUES (@id,@nombreCategoria, @descripcion)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);

                    int filasInsertadas = comando.ExecuteNonQuery();

                    Console.WriteLine($"Filas insertadas: {filasInsertadas}");
                }
            }
        }
        public List<Categoria> obtenerCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            using (SqlConnection conexion = BaseDeDatos.ObtenerConexion())
            {
                string consulta = @"SELECT c.IdCategoria,
		                            c.NombreCategoria,
		                            c.Descripcion
                            FROM CategoriaPelicula c";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idCategoria = reader.GetInt32(0);
                            string nombreCategoria = reader.GetString(1);
                            string descripcionCategoria = reader.GetString(2);
                            Categoria categoria = new Categoria(idCategoria, nombreCategoria, descripcionCategoria);
                            

                            listaCategorias.Add(categoria);
                        }
                    }
                }
            }
            return listaCategorias;
        }
        public void mostrarClientes()
        {
            List<Categoria> clientes = obtenerCategorias();

            foreach (Categoria cliente in clientes)
            {
                int categoria=cliente.idCategoria;
                string nombre=cliente.nombreCategoria;
                string descripcion=cliente.descripcion;
            }
        }
    }
}
