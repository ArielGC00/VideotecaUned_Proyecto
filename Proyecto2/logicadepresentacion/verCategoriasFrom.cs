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
    public partial class verCategoriasFrom : Form
    {
        public verCategoriasFrom()
        {
            InitializeComponent();
        }

        private void mostrarBtn_Click(object sender, EventArgs e)
        {
            LlenarDataGridViewConCategorias();
        }

        private void LlenarDataGridViewConCategorias()
        {
            DAOCategoria daoCategoria = new DAOCategoria();
            List<Categoria> listaCategorias = daoCategoria.obtenerCategorias();

            dataGridViewCategoria.DataSource = listaCategorias;
        }

        private void dataGridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Maneja el evento de clic en una celda aquí si es necesario
        }
    }
}
