using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class Categoria
    {
        public int idCategoria { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcion { get; set; }

        public Categoria(int pIdCategoria, string pNombreCategoria, string pDescripcion) {
            idCategoria = pIdCategoria;
            nombreCategoria = pNombreCategoria;
            descripcion = pDescripcion;
        }
    }
}
