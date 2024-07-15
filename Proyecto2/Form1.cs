using Servidor.logicadepresentacion;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void funcionClienteBtn_Click(object sender, EventArgs e)
        {

            clienteFormularioServidor clienteFormulario = new clienteFormularioServidor();


            clienteFormulario.Show();
        }

        private void categoriaBtn_Click(object sender, EventArgs e)
        {
            registrarCategoriaForm categoriaFormulario = new registrarCategoriaForm();
            categoriaFormulario.Show();
        }

        private void peliculasBtn_Click(object sender, EventArgs e)
        {
            registrarPeliculaForm registrarPeliculaForm = new registrarPeliculaForm();
            registrarPeliculaForm.Show();
        }

        private void encargadoBtn_Click(object sender, EventArgs e)
        {
            registrarEncargadoForm registrarEncargadoForm = new registrarEncargadoForm();
            registrarEncargadoForm.Show();
        }

        private void sucursalBtn_Click(object sender, EventArgs e)
        {
            registrarSucursalForm registrarSucursalForm = new registrarSucursalForm();
            registrarSucursalForm.Show();

        }

        private void peliculaXSucursalBtn_Click(object sender, EventArgs e)
        {
            registrarPeliculaXSucursal registrarPeliculaXSucursalForm = new registrarPeliculaXSucursal();
            registrarPeliculaXSucursalForm.Show();
        }

        private void verCategoriasBtn_Click(object sender, EventArgs e)
        {
            verCategoriasFrom verCategoriasFrom = new verCategoriasFrom();
            verCategoriasFrom.Show();
        }

        private void verPeliculasBtn_Click(object sender, EventArgs e)
        {
            verPeliculasForm verPeliculasForm = new verPeliculasForm();
            verPeliculasForm.Show();
        }

        private void verEncargadoBtn_Click(object sender, EventArgs e)
        {
            verEncargadosForm verEncargadosForm = new verEncargadosForm();
            verEncargadosForm.Show();
        }

        private void verSucursalesRegistradasBtn_Click(object sender, EventArgs e)
        {
            verSucursalForm verSucursalForm = new verSucursalForm();
            verSucursalForm.Show();
        }

        private void verClientesBtn_Click(object sender, EventArgs e)
        {
            verClienteForm verClienteForm = new verClienteForm();
            verClienteForm.Show();
        }

        private void verPeliculaXSucursalBtn_Click(object sender, EventArgs e)
        {
            verPeliculaXSucursalForm verPeliculaXSucursalForm = new verPeliculaXSucursalForm();
            verPeliculaXSucursalForm.Show();
        }
    }
}
