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
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            factura.subtotal = 0;
            factura.descripcion = null;
            FormBienvenida formBienvenida = new FormBienvenida ();
            this.Hide();
            formBienvenida.Show();
            

        }

        private void btnTerminarCompra_Click(object sender, EventArgs e)
        {
            FormFactura formFactura = new FormFactura();
            this.Hide();
            formFactura.Show();
        }
    }
}
