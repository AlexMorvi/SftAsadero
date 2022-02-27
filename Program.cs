using System;
using System.Windows.Forms;

namespace SftAsadero
{
    internal static class Program
    {
        public struct cliente
        {
            public string nombre;
            public string cedula;
            public string telefono;
            public string direccion;
        }
        public struct fecha
        {
            public int dia;
            public int mes;
            public int anio;
        }
        public struct menuCombos
        {
            public int numeroCombo;
            public double precioCombos;
        }
        public struct menuPlatos
        {
            public int numeroPlatos;
            public double precioPlatos;
        }
        public struct menuExtras
        {
            public int numeroExtras;
            public double precioExtras;
        }
        public struct factura
        {
            public cliente cliente;
            public fecha fecha;
            public string menuCombosDescripcion;
            public string menuPlatosDescripcion;
            public string menuExtrasDescripcion;
            public double subtotal;
            public double total;
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormBienvenida());
        }
    }
}
