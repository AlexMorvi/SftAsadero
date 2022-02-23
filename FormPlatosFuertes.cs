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
    public partial class FormPlatosFuertes : Form
    {
        public FormPlatosFuertes()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormBienvenida formBienvenida = new FormBienvenida();
            this.Hide();
            formBienvenida.Show();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            FormExtras formExtras = new FormExtras();
            this.Hide();
            formExtras.Show();
        }
    }
}
