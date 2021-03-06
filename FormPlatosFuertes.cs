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
    public partial class FormPlatosFuertes : Form
    {
        menuPlatos[] arregloPlatos = new menuPlatos[4];
        public FormPlatosFuertes()
        {
            InitializeComponent();
            for (int i = 0; i < arregloPlatos.Length; i++)
            {
                arregloPlatos[i].numeroPlato = i + 1;
            }
            arregloPlatos[0].precioPlato = 3;
            arregloPlatos[1].precioPlato = 3;
            arregloPlatos[2].precioPlato = 4;
            arregloPlatos[3].precioPlato = 18;
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

        private void btnExtras_Click(object sender, EventArgs e)
        {
            if (nmrcSecoPollo.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcSecoPollo.Value) * arregloPlatos[0].precioPlato;
                factura.descripcion += nmrcSecoPollo.Value + "\tSeco de Pollo\r\t" + "$" + arregloPlatos[0].precioPlato+"\r\n";

            }
            if (nmrcEncebollado.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcEncebollado.Value) * arregloPlatos[1].precioPlato;
                factura.descripcion += nmrcEncebollado.Value + "\tEncebollado\r\t" + "$" + arregloPlatos[1].precioPlato+"\r\n";
            }
            if (nmrcChurrasco.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcChurrasco.Value) * arregloPlatos[2].precioPlato;
                factura.descripcion += nmrcChurrasco.Value + "\tChurrasco\r\t\t" + "$" + arregloPlatos[2].precioPlato+"\r\n";
            }
            if (nmrcParrillada.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcParrillada.Value) * arregloPlatos[3].precioPlato;
                factura.descripcion += nmrcParrillada.Value + "\tParrillada\r\t\t" + "$" + arregloPlatos[3].precioPlato+"\r\n";
            }
            FormExtras formExtras = new FormExtras();
            this.Hide();
            formExtras.Show();
        }
    }
}
