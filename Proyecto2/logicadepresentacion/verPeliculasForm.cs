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
    public partial class verPeliculasForm : Form
    {
        public verPeliculasForm()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void mostrarBtn_Click(object sender, EventArgs e)
        {
            llenarDataGridViewConPeliculas();
        }

        private void llenarDataGridViewConPeliculas()
        {
            DAOPelicula daoPelicula = new DAOPelicula();
            List<Pelicula> listaPeliculas = daoPelicula.obtenerPeliculas();

            dataGridViewPelicula.DataSource = listaPeliculas;
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewPelicula.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            dataGridViewPelicula.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idPelicula",
                HeaderText = "ID Película"
            });
            dataGridViewPelicula.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "titulo",
                HeaderText = "Título"
            });
            dataGridViewPelicula.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "categoria",
                HeaderText = "Nombre Categoría"
            });
            dataGridViewPelicula.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "categoria",
                HeaderText = "Descripción Categoría"
            });
            dataGridViewPelicula.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "fechaLanzamiento",
                HeaderText = "Año Lanzamiento"
            });
            dataGridViewPelicula.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idioma",
                HeaderText = "Idioma"
            });

          
            dataGridViewPelicula.CellFormatting += DataGridViewPelicula_CellFormattingy;
        }

        private void DataGridViewPelicula_CellFormattingy(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPelicula.Columns[e.ColumnIndex].HeaderText == "Nombre Categoría")
            {
                Pelicula pelicula = dataGridViewPelicula.Rows[e.RowIndex].DataBoundItem as Pelicula;
                if (pelicula != null)
                {
                    e.Value = pelicula.categoria.nombreCategoria;
                }
            }
            else if (dataGridViewPelicula.Columns[e.ColumnIndex].HeaderText == "Descripción Categoría")
            {
                Pelicula pelicula = dataGridViewPelicula.Rows[e.RowIndex].DataBoundItem as Pelicula;
                if (pelicula != null)
                {
                    e.Value = pelicula.categoria.descripcion;
                }
            }
        }

        private void dataGridViewPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verPeliculasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
