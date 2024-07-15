using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class PrestamoForm : Form
    {
        private int clientId;
        private TcpClient client;
        private NetworkStream stream;
        private string clienteInfo;
        public PrestamoForm(int clientId, TcpClient client, NetworkStream stream, string clienteInfo)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.client = client;
            this.stream = stream;
            this.clienteInfo = clienteInfo;

            // Mostrar información del cliente
            clienteInfoLabel.Text = clienteInfo;
        }
        private void enviarSolicitudBtn_Click(object sender, EventArgs e)
        {
            // Aquí puedes manejar las acciones específicas del cliente, por ejemplo, solicitar un préstamo.
            string solicitud = solicitudTxt.Text;
            enviarMensajeAlServidor($"SOLICITUD:{solicitud}");

            string response = recibirRespuestaDelServidor();
            MessageBox.Show(response);
        }

        private void enviarMensajeAlServidor(string mensaje)
        {
            byte[] data = Encoding.ASCII.GetBytes(mensaje);
            stream.Write(data, 0, data.Length);
        }

        private string recibirRespuestaDelServidor()
        {
            byte[] responseData = new byte[256];
            int bytes = stream.Read(responseData, 0, responseData.Length);
            return Encoding.ASCII.GetString(responseData, 0, bytes);
        }

        private void ClienteVentana_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Asegúrate de cerrar la conexión cuando se cierre el formulario
            if (client != null)
                client.Close();
        }

        private void PrestamoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
