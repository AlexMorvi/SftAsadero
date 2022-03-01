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
    public partial class FormExtras : Form
    {
        menuExtras[] arregloExtras = new menuExtras[10];
        public FormExtras()
        {
            InitializeComponent();
            for (int i = 0; i < arregloExtras.Length; i++)
            {
                arregloExtras[i].numeroExtra = i + 1;
            }
            arregloExtras[0].precioExtra = 1;
            arregloExtras[1].precioExtra = 2;
            arregloExtras[2].precioExtra = 2;
            arregloExtras[3].precioExtra = 3;
            arregloExtras[4].precioExtra = 1;
            arregloExtras[5].precioExtra = 4;
            arregloExtras[6].precioExtra = 2;
            arregloExtras[7].precioExtra = 5;
            arregloExtras[8].precioExtra = 3;
            arregloExtras[9].precioExtra = 3;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Se anulará su orden\n¿Desea continuar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                FormBienvenida formBienvenida = new FormBienvenida();
                this.Hide();
                formBienvenida.Show();
                factura.subtotal = 0;
                factura.descripcion = null;
            }
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (nmrcColas.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcColas.Value) * arregloExtras[0].precioExtra;
                factura.descripcion += nmrcColas.Value + "\tGaseosa\t\t" + "$" + arregloExtras[0].precioExtra + "\r\n";

            }
            if (nmrcCerveza.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCerveza.Value) * arregloExtras[1].precioExtra;
                factura.descripcion += nmrcCerveza.Value + "\tCerveza\t\t" + "$" + arregloExtras[1].precioExtra + "\r\n";

            }
            if (nmrcJugos.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcJugos.Value) * arregloExtras[2].precioExtra;
                factura.descripcion += nmrcJugos.Value + "\tJugo Natural\t" + "$" + arregloExtras[2].precioExtra + "\r\n";

            }
            if (nmrcMichelada.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcMichelada.Value) * arregloExtras[3].precioExtra;
                factura.descripcion += nmrcMichelada.Value + "\tMichelada\t\t" + "$" + arregloExtras[3].precioExtra + "\r\n";

            }
            if (nmrcTeHelado.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcTeHelado.Value) * arregloExtras[4].precioExtra;
                factura.descripcion += nmrcTeHelado.Value + "\tTe Helado\r\t\t" + "$" + arregloExtras[4].precioExtra + "\r\n";

            }
            if (nmrcTiramisu.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcTiramisu.Value) * arregloExtras[5].precioExtra;
                factura.descripcion += nmrcTiramisu.Value + "\tMini Tiramisu\t" + "$" + arregloExtras[5].precioExtra + "\r\n";

            }
            if (nmrcTresLeches.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcTresLeches.Value) * arregloExtras[6].precioExtra;
                factura.descripcion += nmrcTresLeches.Value + "\tMini TresLeches\r\t" + "$" + arregloExtras[6].precioExtra + "\r\n";

            }
            if (nmrcBananaSplit.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcBananaSplit.Value) * arregloExtras[7].precioExtra;
                factura.descripcion += nmrcBananaSplit.Value + "\tBanana Split\r\t" + "$" + arregloExtras[7].precioExtra + "\r\n";

            }
            if (nmrcCheesCake.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCheesCake.Value) * arregloExtras[8].precioExtra;
                factura.descripcion += nmrcCheesCake.Value + "\tMini Cheescake\r\t" + "$" + arregloExtras[8].precioExtra + "\r\n";

            }
            if (nmrcQuimbolitos.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcQuimbolitos.Value) * arregloExtras[9].precioExtra;
                factura.descripcion += nmrcQuimbolitos.Value + "\tTres Quimbolitos\r\t" + "$" + arregloExtras[9].precioExtra + "\r\n";

            }

            FormCarrito formCarrito = new FormCarrito();
            this.Hide();
            formCarrito.Show();
        }
    }
}
