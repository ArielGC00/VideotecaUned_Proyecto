using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class Sucursal
    {
        public int idSucursal;
        public string nombreSucursal;
        public Encargado encargado;
        public string direccion;
        public string telefono;
        public bool activo;

        public Sucursal() { }

        public Sucursal(int idSucursal, string nombreSucursal, Encargado encargado, string direccion, string telefono, bool activo) { 
            this.idSucursal = idSucursal;
            this.nombreSucursal = nombreSucursal;
            this.encargado = encargado;
            this.direccion = direccion;
            this.telefono = telefono;
            this.activo = activo;
        }
    }
}
