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
        factura[] arregloFactura = new factura[1];
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
            FormBienvenida formBienvenida = new FormBienvenida();
            this.Hide();
            formBienvenida.Show();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            if (nmrcSecoPollo.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcSecoPollo.Value) * arregloPlatos[0].precioPlato;
                arregloFactura[0].descripcion += "Seco de Pollo\n";
            }
            if (nmrcEncebollado.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcEncebollado.Value) * arregloPlatos[1].precioPlato;
                arregloFactura[0].descripcion += "Encebollado\n";
            }
            if (nmrcChurrasco.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcChurrasco.Value) * arregloPlatos[2].precioPlato;
                arregloFactura[0].descripcion += "Churrasco\n";
            }
            if (nmrcParrillada.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcParrillada.Value) * arregloPlatos[3].precioPlato;
                arregloFactura[0].descripcion += "Parrillada\n";
            }
            FormExtras formExtras = new FormExtras();
            this.Hide();
            formExtras.Show();
            MessageBox.Show(arregloFactura[0].subtotal + "\n" + arregloFactura[0].descripcion);
        }
    }
}
