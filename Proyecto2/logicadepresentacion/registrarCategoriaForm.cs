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
    public partial class registrarCategoriaForm : Form
    {
        public registrarCategoriaForm()
        {
            InitializeComponent();
        }

        private void registrarCategoriaBtn_Click(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(idCategoriaTxt.Text);
            string nombreCategoria = nombreCategoriaTxt.Text;
            string descripcion = descripcionCategoriaTxt.Text;

            DAOCategoria dAOCategoria = new DAOCategoria();
            dAOCategoria.registrarCategoria(idCategoria,nombreCategoria,descripcion);
        }
    }
}
