using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.logicadenegocios
{
    internal class Cliente:Persona
    {
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }


        public Cliente()
        {
        }

        public Cliente(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int idCliente, DateTime fechaRegistro, bool activo)
            : base(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }
    }
}
