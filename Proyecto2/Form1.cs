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
    }
}
