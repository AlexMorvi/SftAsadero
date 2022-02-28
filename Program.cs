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
            public int precioCombo;
        }
        public struct menuPlatos
        {
            public int numeroPlato;
            public int precioPlato;
        }
        public struct menuExtras
        {
            public int numeroExtra;
            public int precioExtra;
        }
        public struct factura
        {
            public cliente cliente;
            public fecha fecha;
            static public int subtotal;
            public double total;
            static public string descripcion;
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
