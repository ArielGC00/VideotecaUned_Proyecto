using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class Encargado: Persona
    {
        public int IdEncargado { get; set; }
        public DateTime FechaIngreso { get; set; }

        // Constructor por defecto
        public Encargado()
        {
        }

        // Constructor con parámetros
        public Encargado(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int idEncargado, DateTime fechaIngreso)
            : base(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            IdEncargado = idEncargado;
            FechaIngreso = fechaIngreso;
        }
    }
}
