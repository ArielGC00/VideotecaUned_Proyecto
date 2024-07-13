using Proyecto2.logicadeaccesoadatos;

namespace Proyecto2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DAOPeliculaXSucursal dAOEncargado = new DAOPeliculaXSucursal();
            DateTime fechaNacimiento = new DateTime(2005, 04, 07);
            DateTime fechaRegistro = new DateTime(2024, 07, 12);
            dAOEncargado.mostrarClientes();
            //daoCliente.registrarPersonaCliente( "3-0557-0420","Jimena","fernandez","Vargas",fechaNacimiento,1000,fechaRegistro,true);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}