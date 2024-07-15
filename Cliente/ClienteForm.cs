using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class ClienteForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private const string SERVER_IP = "127.0.0.1"; // Cambia esto por la IP del servidor
        private const int SERVER_PORT = 15500; // Puerto del servidor
        private int clientId;

        public ClienteForm(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        private void conectarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Conectar con el servidor desde este cliente específico
                client = new TcpClient(SERVER_IP, SERVER_PORT);
                stream = client.GetStream();

                string cedulaCliente = cedulaClienteTxt.Text;

                // Enviar la identificación al servidor para validación
                enviarMensajeAlServidor($"VALIDAR_ID:{cedulaCliente}");

                // Recibir la respuesta del servidor
                string response = recibirRespuestaDelServidor();
                if (response.StartsWith("Cliente valido:"))
                {
                    MessageBox.Show(response);
                    abrirVentanaCliente(response);
                }
                else
                {
                    MessageBox.Show("No entra");
                }

                MessageBox.Show($"Conexión exitosa con el servidor desde Cliente {clientId}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con el servidor desde Cliente {clientId}: " + ex.Message);
            }
        }

        private void abrirVentanaCliente(string mensaje)
        {
            PrestamoForm clienteVentana = new PrestamoForm(clientId, client, stream, mensaje);
            clienteVentana.Show();
            this.Hide(); // Opcional: oculta la ventana de conexión
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

        private void ClienteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Asegúrate de cerrar la conexión cuando se cierre el formulario
            if (client != null)
                client.Close();
        }
    }
}
