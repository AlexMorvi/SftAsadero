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
                factura.descripcion += nmrcColas.Value + "\tGaseosa\t" + arregloExtras[0].precioExtra + "\n";

            }
            if (nmrcCerveza.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCerveza.Value) * arregloExtras[1].precioExtra;
                factura.descripcion += nmrcCerveza.Value + "\tCerveza\t" + arregloExtras[1].precioExtra + "\n";

            }
            if (nmrcJugos.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcJugos.Value) * arregloExtras[2].precioExtra;
                factura.descripcion += nmrcJugos.Value + "\tJugo Natural\t" + arregloExtras[2].precioExtra + "\n";

            }
            if (nmrcMichelada.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcMichelada.Value) * arregloExtras[3].precioExtra;
                factura.descripcion += nmrcMichelada.Value + "\tMichelada\t" + arregloExtras[3].precioExtra + "\n";

            }
            if (nmrcTeHelado.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcTeHelado.Value) * arregloExtras[4].precioExtra;
                factura.descripcion += nmrcTeHelado.Value + "\tTe Helado\t" + arregloExtras[4].precioExtra + "\n";

            }
            if (nmrcTiramisu.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcTiramisu.Value) * arregloExtras[5].precioExtra;
                factura.descripcion += nmrcTiramisu.Value + "\tMini Tiramisu\t" + arregloExtras[5].precioExtra + "\n";

            }
            if (nmrcTresLeches.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcTresLeches.Value) * arregloExtras[6].precioExtra;
                factura.descripcion += nmrcTresLeches.Value + "\tMini TresLeches\t" + arregloExtras[6].precioExtra + "\n";

            }
            if (nmrcBananaSplit.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcBananaSplit.Value) * arregloExtras[7].precioExtra;
                factura.descripcion += nmrcBananaSplit.Value + "\tBanana Split\t" + arregloExtras[7].precioExtra + "\n";

            }
            if (nmrcCheesCake.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCheesCake.Value) * arregloExtras[8].precioExtra;
                factura.descripcion += nmrcCheesCake.Value + "\tMini Cheescake\t" + arregloExtras[8].precioExtra + "\n";

            }
            if (nmrcQuimbolitos.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcQuimbolitos.Value) * arregloExtras[9].precioExtra;
                factura.descripcion += nmrcQuimbolitos.Value + "\tTres Quimbolitos\t" + arregloExtras[9].precioExtra + "\n";

            }

            FormCarrito formCarrito = new FormCarrito();
            this.Hide();
            formCarrito.Show();
            MessageBox.Show(factura.subtotal + "\n" + factura.descripcion + "\n");

        }
    }
}
