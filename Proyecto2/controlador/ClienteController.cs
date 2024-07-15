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
        public string validarCliente(String cedula) {
            DAOCliente daoCliente = new DAOCliente();
            List<Cliente> clientes = daoCliente.obtenerClientes();
            Cliente cliente = clientes.FirstOrDefault(c => c.Identificacion == cedula && c.Activo);

            if (cliente != null)
            {
                return $"Cliente valido: {cliente.Nombre} {cliente.PrimerApellido} {cliente.SegundoApellido}";
            }
            else
            {
                return "Cliente no válido o inactivo.";
            }
        }
    }
}
