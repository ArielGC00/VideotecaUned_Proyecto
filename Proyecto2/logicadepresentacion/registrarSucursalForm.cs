using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
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
    public partial class registrarSucursalForm : Form
    {
        public registrarSucursalForm()
        {
            InitializeComponent();
            LlenarComboBoxConEncargados();
        }
        private void LlenarComboBoxConEncargados()
        {
            DAOEncargado daoEncargado = new DAOEncargado();
            List<Encargado> listaEncargados = daoEncargado.obtenerEncargados();

            encargadoSucursalComboBox.DisplayMember = "Nombre" ;
            encargadoSucursalComboBox.ValueMember = "IdEncargado";
            encargadoSucursalComboBox.DataSource = listaEncargados;
        }

        private void registrarSucursalBtn_Click(object sender, EventArgs e)
        {
            int idSucursal = int.Parse(idSucursalTxt.Text);
            string nombreSucursal = nombreSucursalTxt.Text;
            string direccionSucursal = direccionSucursalTxt.Text;
            string telefonoSucursal = telefonoSucursalTxt.Text;
            bool activo = (activoSucursalComboBox.SelectedItem.ToString() == "Si");
            int idEncargado = ((Encargado)encargadoSucursalComboBox.SelectedItem).IdEncargado;


            DAOSucursal daoSucursal = new DAOSucursal();
            daoSucursal.registrarSucursal(idSucursal,idEncargado,nombreSucursal,direccionSucursal,telefonoSucursal,activo);
        }
    }
}
