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
    public partial class verClienteForm : Form
    {
        public verClienteForm()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void mostrarBtn_Click(object sender, EventArgs e)
        {
            llenarDataGridViewConClientes();
        }

        private void llenarDataGridViewConClientes()
        {
            DAOCliente daoCliente = new DAOCliente();
            List<Cliente> listaClientes = daoCliente.obtenerClientes();

            dataGridViewCliente.DataSource = listaClientes;
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewCliente.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdCliente",
                HeaderText = "ID Cliente"
            });
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaRegistro",
                HeaderText = "Fecha Registro"
            });
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrimerApellido",
                HeaderText = "Primer Apellido"
            });
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SegundoApellido",
                HeaderText = "Segundo Apellido"
            });
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Activo",
                HeaderText = "Activo"
            });
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaNacimiento",
                HeaderText = "Fecha Nacimiento"
            });
            dataGridViewCliente.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Identificacion",
                HeaderText = "Identificación"
            });

            
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
