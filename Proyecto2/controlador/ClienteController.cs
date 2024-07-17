using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.controlador
{
    internal class ClienteController
    {
        public List<string> validarCliente(string cedula)
        {
            DAOCliente daoCliente = new DAOCliente();
            List<Cliente> clientes = daoCliente.obtenerClientes();
            Cliente cliente = clientes.FirstOrDefault(c => c.Identificacion == cedula && c.Activo);

            if (cliente != null)
            {
                return new List<string>
            {
                "Cliente validado",
                $"{cliente.Nombre} {cliente.PrimerApellido} {cliente.SegundoApellido}",
                cliente.Identificacion
            };
            }
            else
            {
                return new List<string>
                {
                    "Cliente no validado"
                };
            }
        }
    }
}
