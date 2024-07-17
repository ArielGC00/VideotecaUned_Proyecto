using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.controlador
{
    internal class PeliculaController
    {
        public List<string> solicitarPeliculas()
        {
            DAOPelicula daoPelicula = new DAOPelicula();
            List<Pelicula> peliculas = daoPelicula.obtenerPeliculas();
            List<string> peliculasConDatos = new List<string>();

            foreach (Pelicula pelicula in peliculas)
            {
                // Construir el string con los datos requeridos
                string peliculaInfo = $"{pelicula.idPelicula},{pelicula.titulo},{pelicula.idioma},{pelicula.fechaLanzamiento},{pelicula.categoria.nombreCategoria}";
                peliculasConDatos.Add(peliculaInfo);
            }

            return peliculasConDatos;

        }
    }
}
