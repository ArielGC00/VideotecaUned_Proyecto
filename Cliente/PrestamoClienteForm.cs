using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cliente
{
    public partial class PrestamoClienteForm : Form
    {
        private int clientId;
        private TcpClient client;
        private NetworkStream stream;
        private string clienteInfo;
        private string identificacion;
        private string idPeliculaSeleccionada;

        public PrestamoClienteForm(int clientId, TcpClient client, NetworkStream stream, string clienteInfo, string identificacion)
        {
            InitializeComponent();

            this.clientId = clientId;
            this.client = client;
            this.stream = stream;
            this.clienteInfo = clienteInfo;
            this.identificacion = identificacion;

            // Mostrar información del cliente
            nombreUsuarioLabel.Text = clienteInfo;

            dataGridViewPeliculas.ColumnCount = 5;

            dataGridViewPeliculas.Columns[0].Name = "ID";
            dataGridViewPeliculas.Columns[1].Name = "Título";
            dataGridViewPeliculas.Columns[2].Name = "Idioma";
            dataGridViewPeliculas.Columns[3].Name = "Fecha lanzamiento";
            dataGridViewPeliculas.Columns[4].Name = "Categoría";
            dataGridViewPeliculas.CellClick += DataGridViewPeliculas_CellClick;

            dataGridViewVerPrestamos.ColumnCount = 8;

            dataGridViewVerPrestamos.Columns[0].Name = "ID Prestamo";
            dataGridViewVerPrestamos.Columns[1].Name = "Fecha Prestamo";
            dataGridViewVerPrestamos.Columns[2].Name = "Devolución Pendiente";
            dataGridViewVerPrestamos.Columns[3].Name = "ID Pelicula";
            dataGridViewVerPrestamos.Columns[4].Name = "Título";
            dataGridViewVerPrestamos.Columns[5].Name = "Categoría";
            dataGridViewVerPrestamos.Columns[6].Name = "Año de lanzamiento";
            dataGridViewVerPrestamos.Columns[7].Name = "Idioma";
        }

        private void DataGridViewPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda seleccionada sea válida
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPeliculas.Rows.Count)
            {
                DataGridViewRow row = dataGridViewPeliculas.Rows[e.RowIndex];
                idPeliculaSeleccionada = row.Cells["ID"].Value.ToString();
            }
        }
        private void solicitarPrestamoBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxSucursal.SelectedItem != null)
            {

                var sucursalItem = comboBoxSucursal.SelectedItem as dynamic;

                string idSucursal = sucursalItem.Id;

                if (idPeliculaSeleccionada != null)
                {
                    enviarMensajeAlServidor($"REGISTRAR_PRESTAMO:{idSucursal},{idPeliculaSeleccionada},{identificacion}");
                    string response = recibirRespuestaDelServidor();
                    MessageBox.Show($"{response}.");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una película del listado.");
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una sucursal.");
            }

        }

        private void enviarMensajeAlServidor(string mensaje)
        {
            byte[] data = Encoding.ASCII.GetBytes(mensaje);
            stream.Write(data, 0, data.Length);
        }

        private string recibirRespuestaDelServidor()
        {
            byte[] responseData = new byte[4096];
            int bytes = stream.Read(responseData, 0, responseData.Length);
            return Encoding.ASCII.GetString(responseData, 0, bytes);
        }

        private void ClienteVentana_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (client != null)
                client.Close();
        }

        private void cargarSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                // Enviar solicitud de sucursales al servidor
                enviarMensajeAlServidor("SOLICITAR_SUCURSAL:");

                // Recibir la respuesta del servidor
                string response = recibirRespuestaDelServidor();

                // Procesar la respuesta del servidor
                if (!string.IsNullOrEmpty(response))
                {
                    // Dividir la respuesta en sucursales individuales
                    string[] sucursales = response.Split('|');

                    // Limpiar el ComboBox antes de agregar nuevas sucursales
                    comboBoxSucursal.Items.Clear();

                    foreach (string sucursal in sucursales)
                    {
                        // Dividir los campos de la sucursal (id, nombre)
                        string[] datosSucursal = sucursal.Split(',');

                        // Crear un objeto que tenga propiedades Nombre y Id
                        var sucursalItem = new
                        {
                            Nombre = datosSucursal[1],
                            Id = datosSucursal[0]
                        };

                        // Añadir al ComboBox el objeto completo
                        comboBoxSucursal.Items.Add(sucursalItem);
                    }

                    // Configurar el ComboBox para mostrar el nombre de la sucursal
                    comboBoxSucursal.DisplayMember = "Nombre";

                    // Seleccionar el primer elemento por defecto
                    if (comboBoxSucursal.Items.Count > 0)
                    {
                        comboBoxSucursal.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se recibieron sucursales desde el servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al solicitar sucursales desde Cliente {clientId}: " + ex.Message);
            }
        }



        private void PrestamoClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void selectSucursalBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxSucursal.SelectedItem != null)
            {

                var sucursalItem = comboBoxSucursal.SelectedItem as dynamic;

                string idSucursal = sucursalItem.Id;

                try
                {
                    enviarMensajeAlServidor($"SOLICITAR_PELICULASXSUCURSAL:{idSucursal}");
                    dataGridViewPeliculas.Rows.Clear();
                    string response = recibirRespuestaDelServidor();

                    // Verificar que la respuesta no esté vacía
                    if (!string.IsNullOrEmpty(response))
                    {
                        string[] peliculasServidor = response.Split('|');
                        foreach (string pelicula in peliculasServidor)
                        {
                            string[] datosPelicula = pelicula.Split(',');
                            dataGridViewPeliculas.Rows.Add(datosPelicula);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se recibieron películas desde el servidor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al solicitar películas: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una sucursal.");
            }
        }

        private void verPrestamosBtn_Click(object sender, EventArgs e)
        {
            enviarMensajeAlServidor($"VER_PRESTAMOS:{identificacion}");
            string response = recibirRespuestaDelServidor();

            // Limpiar las filas existentes
            dataGridViewVerPrestamos.Rows.Clear();

            // Verificar que la respuesta no esté vacía
            if (!string.IsNullOrEmpty(response))
            {
                // Dividir la respuesta en préstamos individuales
                string[] prestamosServidor = response.Split('|');

                // Procesar cada préstamo y agregarlo al DataGridView
                foreach (string prestamo in prestamosServidor)
                {
                    string[] datosPrestamo = prestamo.Split(',');

                    // Asegurarse de que haya exactamente 7 elementos en datosPrestamo
                    if (datosPrestamo.Length == 8)
                    {
                        dataGridViewVerPrestamos.Rows.Add(datosPrestamo);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se recibieron préstamos desde el servidor.");
            }
        }

    }
}
