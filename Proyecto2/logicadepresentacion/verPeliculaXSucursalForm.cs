using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

namespace Servidor.logicadepresentacion
{
    public partial class verPeliculaXSucursalForm : Form
    {
        public verPeliculaXSucursalForm()
        {
            InitializeComponent();
            configurarDataGridView();
        }

        private void mostrarBtn_Click(object sender, EventArgs e)
        {
            llenarDataGridViewConPeliculasXSucursal();
        }

        private void llenarDataGridViewConPeliculasXSucursal()
        {
            DAOPeliculaXSucursal daoPeliculaXSucursal = new DAOPeliculaXSucursal();
            List<PeliculaXSucursal> listaPeliculasXSucursal = daoPeliculaXSucursal.obtenerPeliculasXSucursal();

            dataGridViewPeliculaXSucursal.DataSource = listaPeliculasXSucursal;
        }

        private void configurarDataGridView()
        {
            dataGridViewPeliculaXSucursal.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.idSucursal",
                HeaderText = "ID Sucursal"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.Nombre",
                HeaderText = "Nombre Sucursal"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.direccion",
                HeaderText = "Dirección Sucursal"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.telefono",
                HeaderText = "Teléfono Sucursal"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "sucursal.activo",
                HeaderText = "Activo Sucursal"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.encargado.IdEncargado",
                HeaderText = "ID Encargado"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.encargado.Nombre",
                HeaderText = "Nombre Encargado"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.encargado.PrimerApellido",
                HeaderText = "Primer Apellido Encargado"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sucursal.encargado.SegundoApellido",
                HeaderText = "Segundo Apellido Encargado"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pelicula.idPelicula",
                HeaderText = "ID Película"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pelicula.titulo",
                HeaderText = "Título Película"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pelicula.categoria.nombreCategoria",
                HeaderText = "Nombre de la categoría"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pelicula.categoria.descripcion",
                HeaderText = "Descripción de la categoría"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pelicula.fechaLanzamiento",
                HeaderText = "Año Lanzamiento"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pelicula.idioma",
                HeaderText = "Idioma"
            });
            dataGridViewPeliculaXSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "cantidad",
                HeaderText = "Cantidad"
            });

            // Manejar el evento CellFormatting
            dataGridViewPeliculaXSucursal.CellFormatting += DataGridViewPeliculaXSucursal_CellFormatting;
        }

        private void DataGridViewPeliculaXSucursal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewPeliculaXSucursal.Rows.Count)
                return;

            var row = dataGridViewPeliculaXSucursal.Rows[e.RowIndex];
            if (row.DataBoundItem == null)
                return;

            var peliculaXSucursal = (PeliculaXSucursal)row.DataBoundItem;

            if (dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.StartsWith("sucursal.encargado."))
            {
                string[] propertyNameParts = dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.Split('.');
                string propertyName = propertyNameParts[2]; 

                var encargado = peliculaXSucursal.sucursal.encargado;
                if (encargado != null)
                {
                    var propertyInfo = encargado.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        e.Value = propertyInfo.GetValue(encargado);
                    }
                }
            }
            else if (dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.StartsWith("pelicula.categoria."))
            {
                string[] propertyNameParts = dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.Split('.');
                string propertyName = propertyNameParts[2]; 

                var categoria = peliculaXSucursal.pelicula.categoria;
                if (categoria != null)
                {
                    var propertyInfo = categoria.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        e.Value = propertyInfo.GetValue(categoria);
                    }
                }
            }
            else if (dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.StartsWith("pelicula."))
            {
                string[] propertyNameParts = dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.Split('.');
                string propertyName = propertyNameParts[1]; 

                var pelicula = peliculaXSucursal.pelicula;
                if (pelicula != null)
                {
                    var propertyInfo = pelicula.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        e.Value = propertyInfo.GetValue(pelicula);
                    }
                }
            }
            else if (dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.StartsWith("sucursal."))
            {
                string[] propertyNameParts = dataGridViewPeliculaXSucursal.Columns[e.ColumnIndex].DataPropertyName.Split('.');
                string propertyName = propertyNameParts[1];

                var sucursal = peliculaXSucursal.sucursal;
                if (sucursal != null)
                {
                    var propertyInfo = sucursal.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        e.Value = propertyInfo.GetValue(sucursal);
                    }
                }
            }
        }

        private void dataGridViewPeliculaXSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
