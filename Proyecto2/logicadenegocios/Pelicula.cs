using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class  Pelicula
    {
        public int idPelicula { get; set; }
        public string titulo { get; set; }
        public Categoria categoria { get; set; }
        public int fechaLanzamiento { get; set; }
        public string idioma { get; set; }

        public Pelicula(int idPelicula, string titulo, Categoria categoria, int fechaLanzamiento, string idioma)
        {
            this.idPelicula = idPelicula;
            this.titulo = titulo;
            this.categoria = categoria;
            this.fechaLanzamiento = fechaLanzamiento;
            this.idioma = idioma;
        }
    }
}
