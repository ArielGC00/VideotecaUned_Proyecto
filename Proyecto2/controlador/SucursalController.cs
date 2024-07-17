using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.controlador
{
    internal class SucursalController
    {
        public List<string> solicitarSucursales()
        {
            DAOSucursal daoSucursal = new DAOSucursal();
            List<Sucursal> sucursales = daoSucursal.obtenerSucursal();
            List<string> sucursalesActivas = new List<string>();

            foreach (var sucursal in sucursales)
            {
                if (sucursal.activo)
                {
                    sucursalesActivas.Add($"{sucursal.idSucursal},{sucursal.Nombre}");
                }
            }

            return sucursalesActivas;

        }
    }
}
