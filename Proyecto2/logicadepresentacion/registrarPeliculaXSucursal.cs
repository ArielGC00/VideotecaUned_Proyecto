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
    public partial class registrarPeliculaXSucursal : Form
    {
        public registrarPeliculaXSucursal()
        {
            InitializeComponent();
            llenarComboBoxSucursal();
            llenarComboBoxPelicula();
        }

        private void llenarComboBoxPelicula()
        {
            DAOPelicula daoPelicula = new DAOPelicula();
            List<Pelicula> listaPeliculas = daoPelicula.obtenerPeliculas();

            peliculaComboBox.DisplayMember = "Titulo";
            peliculaComboBox.ValueMember = "IdPelicula";
            peliculaComboBox.DataSource = listaPeliculas;
        }

        private void llenarComboBoxSucursal()
        {
            DAOSucursal daoSucursal = new DAOSucursal();
            List<Sucursal> listaSucursales = daoSucursal.obtenerSucursal();

            sucursalComboBox.DisplayMember = "Nombre";
            sucursalComboBox.ValueMember = "IdSucursal";
            sucursalComboBox.DataSource = listaSucursales;
        }

        private void registarPeliculaXSucursalBtn_Click(object sender, EventArgs e)
        {
            int idPelicula = ((Pelicula)peliculaComboBox.SelectedItem).idPelicula;
            int idSucursal = ((Sucursal)sucursalComboBox.SelectedItem).idSucursal;
            int cantidadPeliculas = int.Parse(cantidadPeliculasTxt.Text);

            DAOPeliculaXSucursal dAOPeliculaXSucursal = new DAOPeliculaXSucursal();
            dAOPeliculaXSucursal.registrarPeliculaSucursal(idSucursal,idPelicula,cantidadPeliculas);
        }
    }
}
