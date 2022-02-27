using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SftAsadero
{
    public partial class FormCombos : Form
    {
        public FormCombos()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormBienvenida formBienvenida = new FormBienvenida();
            this.Hide();
            formBienvenida.Show();
        }

        private void btnPlatosFuertes_Click(object sender, EventArgs e)
        {
            FormPlatosFuertes formPlatosFuertes = new FormPlatosFuertes();
            this.Hide();
            formPlatosFuertes.Show();  
        }
    }
}
