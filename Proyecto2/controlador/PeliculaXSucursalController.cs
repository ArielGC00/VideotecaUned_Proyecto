using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.controlador
{
    internal class PeliculaXSucursalController
    {
        public List<string> solicitarPeliculaXSucursal(string idSucursalStr)
        {
            bool validado=false;
            int idSucursal=int.Parse(idSucursalStr);
            DAOPeliculaXSucursal daoPeliculaXSucursal = new DAOPeliculaXSucursal();
            List<PeliculaXSucursal> peliculasXSucursal = daoPeliculaXSucursal.obtenerPeliculasXSucursal();
            List<string> peliculasConDatos = new List<string>();

            foreach (PeliculaXSucursal peliculaXSucursal in peliculasXSucursal)
            {
                // Construir el string con los datos requeridos
                if (idSucursal == peliculaXSucursal.sucursal.idSucursal) {
                    validado=true;
                    string peliculaInfo = $"{peliculaXSucursal.pelicula.idPelicula},{peliculaXSucursal.pelicula.titulo},{peliculaXSucursal.pelicula.idioma},{peliculaXSucursal.pelicula.fechaLanzamiento},{peliculaXSucursal.pelicula.categoria.nombreCategoria}";
                    peliculasConDatos.Add(peliculaInfo);
                }
                
            }
            if (validado)
            {
                return peliculasConDatos;
            }
            else {
                string mensaje = $" , , , , ";
                peliculasConDatos.Add(mensaje);
                return peliculasConDatos;
            }
            

        }
    }
}
