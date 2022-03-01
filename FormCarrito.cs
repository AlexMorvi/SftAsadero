using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SftAsadero.Program;

namespace SftAsadero
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
            txtCarrito.Text= "Cantidad\r\tProducto\r\t\tPrecio Unitario\r\n" + Convert.ToString(factura.descripcion) + "\r\n";
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Se anulará su orden\n¿Deseá continuar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                FormBienvenida formBienvenida = new FormBienvenida();
                this.Hide();
                formBienvenida.Show();
                factura.subtotal = 0;
                factura.descripcion = null;
            }
        }

        private void btnTerminarCompra_Click(object sender, EventArgs e)
        {
            FormFactura formFactura = new FormFactura();
            this.Hide();
            formFactura.Show();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            if (factura.subtotal == 0)
            {
                MessageBox.Show("No agregó ningun producto, se le redirigirá al menú", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FormBienvenida formBienvenida = new FormBienvenida();
                this.Hide();
                formBienvenida.Show();
                factura.subtotal = 0;
                factura.descripcion = null;
            }
        }
    }
}
