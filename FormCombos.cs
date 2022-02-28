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
        factura[] arregloFactura = new factura[1];
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
            
            FormBienvenida formBienvenida = new FormBienvenida();
            this.Hide();
            formBienvenida.Show();
        }

        private void btnPlatosFuertes_Click(object sender, EventArgs e)
        {
            
            if(nmrcCombo1.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcCombo1.Value )* arregloCombos[0].precioCombo;
                arregloFactura[0].descripcion += "Combo 1\n";
            }
            if (nmrcCombo2.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcCombo2.Value) * arregloCombos[1].precioCombo;
                arregloFactura[0].descripcion += "Combo 2\n";
            }
            if (nmrcCombo3.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcCombo3.Value) * arregloCombos[2].precioCombo;
                arregloFactura[0].descripcion += "Combo 3\n";
            }
            if (nmrcCombo4.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcCombo4.Value) * arregloCombos[3].precioCombo;
                arregloFactura[0].descripcion += "Combo 4\n";
            }
            if (nmrcCombo5.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcCombo5.Value) * arregloCombos[4].precioCombo;
                arregloFactura[0].descripcion += "Combo 5\n";
            }
            if (nmrcCombo6.Value > 0)
            {
                arregloFactura[0].subtotal += Convert.ToInt32(nmrcCombo6.Value) * arregloCombos[5].precioCombo;
                arregloFactura[0].descripcion += "Combo 6\n";
            }
            
            FormPlatosFuertes formPlatosFuertes = new FormPlatosFuertes();
            this.Hide();
            formPlatosFuertes.Show();
            MessageBox.Show(arregloFactura[0].subtotal +"\n"+ arregloFactura[0].descripcion);
        }
    }
}
