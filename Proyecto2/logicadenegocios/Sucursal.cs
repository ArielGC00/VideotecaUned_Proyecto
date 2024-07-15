using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class Sucursal
    {
        public int IdCliente { get; set; }
        public int idSucursal { get; set; }
        public string Nombre { get; set; }
        public Encargado encargado { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public bool activo { get; set; }

        public Sucursal() { }

        public Sucursal(int idSucursal, string nombreSucursal, Encargado encargado, string direccion, string telefono, bool activo) { 
            this.idSucursal = idSucursal;
            this.Nombre = nombreSucursal;
            this.encargado = encargado;
            this.direccion = direccion;
            this.telefono = telefono;
            this.activo = activo;
        }
    }
}
