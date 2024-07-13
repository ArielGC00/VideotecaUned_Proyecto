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
    public partial class clienteFormularioServidor : Form
    {
        public clienteFormularioServidor()
        {
            InitializeComponent();
        }

        private void clienteFormularioServidor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nombreClienteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void primerApellidoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void segundoApellidoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaNacimientoSelect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void registrarClienteBtn_Click(object sender, EventArgs e)
        {
            string identificacion = cedulaClienteTxt.Text;
            string nombre = nombreClienteTxt.Text;
            string primerApellido = primerApellidoTxt.Text;
            string segundoApellido = segundoApellidoTxt.Text;
            DateTime fechaNacimiento = fechaNacimientoSelect.Value;
            int idCliente = int.Parse(iDClienteTxt.Text);
            DateTime fechaRegistro = DateTime.Now; // Fecha de registro autogenerada

            // Convertir el valor del ComboBox a booleano
            bool activo = (activoClienteComboBox.SelectedItem.ToString() == "Si");

            DAOCliente daoCliente = new DAOCliente();
            daoCliente.registrarPersonaCliente(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento, idCliente, fechaRegistro, activo);
        }

        private void iDClienteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedulaClienteTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
