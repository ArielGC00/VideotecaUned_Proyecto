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
    public partial class verEncargadosForm : Form
    {
        public verEncargadosForm()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void mostrarBtn_Click(object sender, EventArgs e)
        {
            llenarDataGridViewConEncargados();
        }

        private void llenarDataGridViewConEncargados()
        {
            DAOEncargado daoEncargado = new DAOEncargado();
            List<Encargado> listaEncargados = daoEncargado.obtenerEncargados();

            dataGridViewEncargado.DataSource = listaEncargados;
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewEncargado.AutoGenerateColumns = false;


            dataGridViewEncargado.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdEncargado",
                HeaderText = "ID Encargado"
            });
            dataGridViewEncargado.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaIngreso",
                HeaderText = "Fecha Ingreso"
            });
            dataGridViewEncargado.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Identificacion",
                HeaderText = "Identificación"
            });
            dataGridViewEncargado.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });
            dataGridViewEncargado.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrimerApellido",
                HeaderText = "Primer Apellido"
            });
            dataGridViewEncargado.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SegundoApellido",
                HeaderText = "Segundo Apellido"
            });
            dataGridViewEncargado.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaNacimiento",
                HeaderText = "Fecha Nacimiento"
            });
        }

        private void dataGridViewEncargado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
