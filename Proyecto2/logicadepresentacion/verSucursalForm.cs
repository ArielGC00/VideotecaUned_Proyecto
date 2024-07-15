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
    public partial class verSucursalForm : Form
    {
        public verSucursalForm()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void mostrarBtn_Click(object sender, EventArgs e)
        {
            llenarDataGridViewConSucursales();
        }

        private void llenarDataGridViewConSucursales()
        {
            DAOSucursal daoSucursal = new DAOSucursal();
            List<Sucursal> listaSucursales = daoSucursal.obtenerSucursal();

            dataGridViewSucursal.DataSource = listaSucursales;
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewSucursal.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idSucursal",
                HeaderText = "ID Sucursal"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre Sucursal"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "direccion",
                HeaderText = "Dirección"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "telefono",
                HeaderText = "Teléfono"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "activo",
                HeaderText = "Activo"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "encargado.IdEncargado",
                HeaderText = "ID Encargado"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "encargado.Nombre",
                HeaderText = "Nombre Encargado"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "encargado.PrimerApellido",
                HeaderText = "Primer Apellido Encargado"
            });
            dataGridViewSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "encargado.SegundoApellido",
                HeaderText = "Segundo Apellido Encargado"
            });

            // Manejar el evento CellFormatting
            dataGridViewSucursal.CellFormatting += DataGridViewSucursal_CellFormatting;
        }

        private void DataGridViewSucursal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewSucursal.Columns[e.ColumnIndex].HeaderText == "ID Encargado")
            {
                Sucursal sucursal = dataGridViewSucursal.Rows[e.RowIndex].DataBoundItem as Sucursal;
                if (sucursal != null)
                {
                    e.Value = sucursal.encargado.IdEncargado;
                }
            }
            else if (dataGridViewSucursal.Columns[e.ColumnIndex].HeaderText == "Nombre Encargado")
            {
                Sucursal sucursal = dataGridViewSucursal.Rows[e.RowIndex].DataBoundItem as Sucursal;
                if (sucursal != null)
                {
                    e.Value = sucursal.encargado.Nombre;
                }
            }
            else if (dataGridViewSucursal.Columns[e.ColumnIndex].HeaderText == "Primer Apellido Encargado")
            {
                Sucursal sucursal = dataGridViewSucursal.Rows[e.RowIndex].DataBoundItem as Sucursal;
                if (sucursal != null)
                {
                    e.Value = sucursal.encargado.PrimerApellido;
                }
            }
            else if (dataGridViewSucursal.Columns[e.ColumnIndex].HeaderText == "Segundo Apellido Encargado")
            {
                Sucursal sucursal = dataGridViewSucursal.Rows[e.RowIndex].DataBoundItem as Sucursal;
                if (sucursal != null)
                {
                    e.Value = sucursal.encargado.SegundoApellido;
                }
            }
        }

        private void dataGridViewSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
