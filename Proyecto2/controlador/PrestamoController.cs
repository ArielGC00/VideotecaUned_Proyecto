using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.controlador
{
    internal class PrestamoController
    {
        public List<string> registrarPrestamo(string idSucursalStr,string idPeliculaStr,string identificacion)
        {
            int idCliente = 0;
            bool validado = false;
            int idSucursal = int.Parse(idSucursalStr);
            int idPelicula = int.Parse(idPeliculaStr);
            DateTime fechaPrestamo = DateTime.Now;
            DAOCliente dAOCliente = new DAOCliente();
            List<Cliente> clientes = dAOCliente.obtenerClientes();
            foreach (Cliente cliente in clientes) {
                if (identificacion==cliente.Identificacion) {
                    idCliente=cliente.IdCliente;
                }
            }
            DAOPrestamo daoPrestamo = new DAOPrestamo();
            daoPrestamo.registrarPrestamo(idCliente,idSucursal,idPelicula,fechaPrestamo,true);
            DAOPeliculaXSucursal dAOPeliculaXSucursal = new DAOPeliculaXSucursal();
            dAOPeliculaXSucursal.actualizarCantidadPelicula(idSucursal,idPelicula);
            return new List<string>
                {
                    "Prestamo realizado"
                };



        }
        public List<string> obtenerPrestamosCliente(int idCliente) {
            DAOPrestamo daoPrestamo= new DAOPrestamo();
            List<Prestamo> listaPrestamos= daoPrestamo.obtenerPrestamosPorCliente(idCliente);
            List<string> prestamosConDatos = new List<string>();
            DAOPelicula dAOPelicula = new DAOPelicula();


            foreach (Prestamo prestamo in listaPrestamos)
            {
                // Construir el string con los datos requeridos
                
                string infoPelicula = dAOPelicula.obtenerPeliculaPorId(prestamo.idPelicula);
                string prestamoInfo = $"{prestamo.idPrestamo},{prestamo.fechaPrestamo},{prestamo.pendienteDevolucion},{infoPelicula}";
                prestamosConDatos.Add(prestamoInfo);
            }

            return prestamosConDatos;

        }
    }
}
