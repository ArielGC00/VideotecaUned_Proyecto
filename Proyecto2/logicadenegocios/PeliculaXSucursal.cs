using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class PeliculaXSucursal
    {
        public Sucursal sucursal { get; set; }
        public Pelicula pelicula { get; set; }
        public int cantidad { get; set; }
        public PeliculaXSucursal(Sucursal sucursal, Pelicula pelicula, int cantidad)
        {
            this.sucursal = sucursal;
            this.pelicula = pelicula;
            this.cantidad = cantidad;
        }
    }
}
