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
    public partial class registrarPeliculaForm : Form
    {
        public registrarPeliculaForm()
        {
            InitializeComponent();
            LlenarComboBoxConCategorias();
        }
        private void LlenarComboBoxConCategorias()
        {
            DAOCategoria daoCategoria = new DAOCategoria();
            List<Categoria> listaCategorias = daoCategoria.obtenerCategorias();

            idCategoriaComboBox.DisplayMember = "NombreCategoria";
            idCategoriaComboBox.ValueMember = "IdCategoria";
            idCategoriaComboBox.DataSource = listaCategorias;
        }
        private void idCategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            int idPelicula = int.Parse(idPeliculaTxt.Text);
            string tituloPelicula = tituloTxt.Text;
            int categoriaPelicula = ((Categoria)idCategoriaComboBox.SelectedItem).idCategoria;
            int anioLanzamiento = int.Parse(anioLanzamientoTxt.Text);
            string idiomaPelicula= idomaTxt.Text;
            DAOCategoria dAOCategoria = new DAOCategoria();
            Categoria categoria=dAOCategoria.obtenerCategoriaPorId(categoriaPelicula);
            int idCategoria = categoria.idCategoria;

            DAOPelicula daoPelicula = new DAOPelicula();
            daoPelicula.registrarPelicula(idPelicula,categoriaPelicula,tituloPelicula,idiomaPelicula,anioLanzamiento);
        }
    }
}
