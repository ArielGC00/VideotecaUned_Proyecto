using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class ConectarForm : Form
    {
        private List<ClienteForm> formsClientes = new List<ClienteForm>();
        public ConectarForm()
        {
            InitializeComponent();
        }

        private void crearClientesBtn_Click(object sender, EventArgs e)
        {
            // Crear un nuevo formulario ClienteForm para cada cliente
            for (int i = 1; i <= 5; i++) // Crear 5 clientes, puedes ajustar según necesites
            {
                ClienteForm clienteForm = new ClienteForm(i);
                clienteForm.Text = "Cliente " + i.ToString();
                clienteForm.FormClosed += ClienteForm_FormClosed; // Manejar cierre del formulario
                clienteForm.Show();

                formsClientes.Add(clienteForm);
            }
        }

        private void ClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Remover el formulario cerrado de la lista
            formsClientes.Remove((ClienteForm)sender);
        }
    }
}
