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
    public partial class FormCombos : Form
    {
        
        menuCombos[] arregloCombos=new menuCombos[6] ;
        public FormCombos()
        {
            InitializeComponent();
            for(int i = 0; i < arregloCombos.Length; i++)
            {
                arregloCombos[i].numeroCombo = i + 1; 
            }
            arregloCombos[0].precioCombo = 4;
            arregloCombos[1].precioCombo = 5;
            arregloCombos[2].precioCombo = 9;
            arregloCombos[3].precioCombo = 15;
            arregloCombos[4].precioCombo = 17;
            arregloCombos[5].precioCombo = 20;
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

        private void btnPlatosFuertes_Click(object sender, EventArgs e)
        {
            
            if(nmrcCombo1.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCombo1.Value )* arregloCombos[0].precioCombo;
                factura.descripcion += nmrcCombo1.Value+ "\tCombo 1" + "\r\t\t" +"$"+ arregloCombos[0].precioCombo+"\r\n";
            }
            if (nmrcCombo2.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCombo2.Value) * arregloCombos[1].precioCombo;
                factura.descripcion += nmrcCombo2.Value + "\tCombo 2" + "\r\t\t" + "$" + arregloCombos[1].precioCombo + "\r\n";
            }
            if (nmrcCombo3.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCombo3.Value) * arregloCombos[2].precioCombo;
                factura.descripcion += nmrcCombo3.Value + "\tCombo 3" + "\r\t\t" + "$" + arregloCombos[2].precioCombo + "\r\n";
            }
            if (nmrcCombo4.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCombo4.Value) * arregloCombos[3].precioCombo;
                factura.descripcion += nmrcCombo4.Value + "\tCombo 4" + "\r\t\t" + "$" + arregloCombos[3].precioCombo + "\r\n";
            }
            if (nmrcCombo5.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCombo5.Value) * arregloCombos[4].precioCombo;
                factura.descripcion += Convert.ToString(nmrcCombo5.Value) + "\tCombo 5" + "\r\t\t" + "$" + arregloCombos[4].precioCombo + "\r\n";
            }
            if (nmrcCombo6.Value > 0)
            {
                factura.subtotal += Convert.ToInt32(nmrcCombo6.Value) * arregloCombos[5].precioCombo;
                factura.descripcion += Convert.ToString(nmrcCombo6.Value) + "\tCombo 6"+"\r\t\t" + "$" + arregloCombos[5].precioCombo + "\r\n";
            }

            FormPlatosFuertes formPlatosFuertes = new FormPlatosFuertes();
            this.Hide();
            formPlatosFuertes.Show();
            MessageBox.Show(factura.subtotal +"\n"+ factura.descripcion+"\n");
        }
    }
}
