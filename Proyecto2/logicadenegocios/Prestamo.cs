using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class Prestamo
    {
        public int idPrestamo { get; set; }
        public int idCliente { get; set; }
        public int idPelicula { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public bool pendienteDevolucion { get; set; }

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
