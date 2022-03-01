using System;
using System.Windows.Forms;

namespace SftAsadero
{
    internal static class Program
    {
        public struct cliente
        {
            static public string nombre;
            static public string cedula;
            static public string telefono;
            static public string direccion;
        }
        public struct fecha
        {
            static public string dia;
            static public string mes;
            static public string anio;
            static public string hora;
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
            static public int subtotal;
            static public double total;
            static public double iva;
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
