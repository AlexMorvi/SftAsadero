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
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FormBienvenida formBienvenida = new FormBienvenida();
            this.Hide();
            formBienvenida.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
