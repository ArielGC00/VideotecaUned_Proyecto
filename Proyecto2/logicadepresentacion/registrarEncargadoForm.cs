using Proyecto2.logicadeaccesoadatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor.logicadepresentacion
{
    public partial class registrarEncargadoForm : Form
    {
        public registrarEncargadoForm()
        {
            InitializeComponent();
        }

        private void btnRegistrarEncargado_Click(object sender, EventArgs e)
        {
            string identificacion = cedulaEncargadoTxt.Text;
            string nombre = nombreEncargadoTxt.Text;
            string primerApellido = primerApellidoTxt.Text;
            string segundoApellido = segundoApellidoTxt.Text;
            DateTime fechaNacimiento = fechaNacimientoEncargado.Value;
            int idEncargado = int.Parse(idEncargadoTxt.Text);
            DateTime fechaIngreso = DateTime.Now; // Fecha de registro autogenerada

            DAOEncargado daoEncargado = new DAOEncargado();
            daoEncargado.registrarPersonaEncargada(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento,idEncargado,fechaIngreso);
        }
    }
}
