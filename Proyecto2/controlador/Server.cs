using Proyecto2.logicadeaccesoadatos;
using Proyecto2.logicadenegocios;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Servidor.controlador
{
    internal class Server
    {
        private TcpListener server;
        private bool isRunning;
        string responseString = null;

        public Server()
        {
            server = new TcpListener(System.Net.IPAddress.Parse("127.0.0.1"), 15500);
            isRunning = false;
        }

        public void Start()
        {
            try
            {
                server.Start();
                isRunning = true;
                Console.WriteLine("Servidor iniciado en el puerto 15500...");

                // Aceptar hasta 5 clientes simultáneamente.
                for (int i = 0; i < 5; i++)
                {
                    Thread clientThread = new Thread(new ThreadStart(ListenForClients));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al iniciar el servidor: " + ex.Message);
            }
        }

        private void ListenForClients()
        {
            while (isRunning)
            {
                TcpClient client = null;
                try
                {
                    // Aceptar una solicitud de conexión del cliente.
                    client = server.AcceptTcpClient();
                    Console.WriteLine("Cliente conectado!");

                    // Crear un nuevo hilo para manejar al cliente conectado.
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                    clientThread.Start(client);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al aceptar cliente: " + ex.Message);
                    client?.Close();
                }
            }
        }

        private void HandleClientComm(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream clientStream = client.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;
                try
                {
                    // Leer datos del cliente.
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de lectura: " + ex.Message);
                    break;
                }

                if (bytesRead == 0)
                {
                    // Cliente cerró la conexión.
                    break;
                }

                // Decodificar y mostrar los datos recibidos.
                string dataReceived = Encoding.ASCII.GetString(message, 0, bytesRead);
                Console.WriteLine("Mensaje recibido: " + dataReceived);

                // Procesar el mensaje recibido basado en el tipo de dato
                List<string> response = ProcesarMensaje(dataReceived);

                // Unir los elementos de la lista en una única cadena con un delimitador
                if (response != null)
                {
                    responseString = string.Join("|", response);
                }
                
                

                // Enviar la respuesta al cliente
                byte[] dataToSend = Encoding.ASCII.GetBytes(responseString);
                clientStream.Write(dataToSend, 0, dataToSend.Length);
                clientStream.Flush();
            }

            client.Close();
        }

        private List<string> ProcesarMensaje(string mensaje)
        {
            if (mensaje.StartsWith("VALIDAR_ID:"))
            {
                string cedulaCliente = mensaje.Substring("VALIDAR_ID:".Length);
                ClienteController controladorCliente = new ClienteController();
                return controladorCliente.validarCliente(cedulaCliente);
            }
            else if (mensaje.StartsWith("SOLICITAR_SUCURSAL:"))
            {
                SucursalController controladorSucursal = new SucursalController();
                return controladorSucursal.solicitarSucursales();
            }
            else if (mensaje.StartsWith("SOLICITAR_PELICULASXSUCURSAL:"))
            {
                string idSucursal = mensaje.Substring("SOLICITAR_PELICULASXSUCURSAL:".Length);
                PeliculaXSucursalController peliculaXSucursalController = new PeliculaXSucursalController();
                return peliculaXSucursalController.solicitarPeliculaXSucursal(idSucursal);
            }
            else if (mensaje.StartsWith("REGISTRAR_PRESTAMO:"))
            {
                // Extraer los valores de idSucursal, idPeliculaSeleccionada y identificacion
                string datos = mensaje.Substring("REGISTRAR_PRESTAMO:".Length);
                string[] partes = datos.Split(',');

                if (partes.Length == 3)
                {
                    string idSucursal = partes[0];
                    string idPeliculaSeleccionada = partes[1];
                    string identificacion = partes[2];

                    // Aquí puedes usar los valores extraídos como necesites
                    PrestamoController prestamoController = new PrestamoController();
                    return prestamoController.registrarPrestamo(idSucursal, idPeliculaSeleccionada, identificacion);
                }
                else
                {
                    return new List<string>
                        {
                            "Datos insuficientes para registrar el préstamo"
                        };
                }
            }
            else if (mensaje.StartsWith("VER_PRESTAMOS:"))
            {
                string cedulaCliente = mensaje.Substring("VER_PRESTAMOS:".Length);
                DAOCliente dAOCliente = new DAOCliente();
                int idCliente=dAOCliente.obtenerIdCliente(cedulaCliente);
                PrestamoController prestamoController=new PrestamoController();
                return prestamoController.obtenerPrestamosCliente(idCliente);
            }
            else
            {
                return new List<string>
                    {
                        "Cliente no validado"
                    };
            }
        }


        public void Stop()
        {
            isRunning = false;
            server.Stop();
        }
    }
}
