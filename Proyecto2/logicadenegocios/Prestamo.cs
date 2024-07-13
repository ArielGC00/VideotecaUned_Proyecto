using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class Prestamo
    {
        private int idPrestamo;
        private int idCliente;
        private int idPelicula;
        private DateTime fechaPrestamo;
        private bool pendienteDevolucion;

        public Prestamo(int idPrestamo, int idCliente, int idPelicula, DateTime fechaPrestamo, bool pendienteDevolucion)
        {
            this.idPrestamo = idPrestamo;
            this.idCliente = idCliente;
            this.idPelicula = idPelicula;
            this.fechaPrestamo = fechaPrestamo;
            this.pendienteDevolucion = pendienteDevolucion;
        }
    }
}
