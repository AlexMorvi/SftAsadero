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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            FormCombos formCombos = new FormCombos();
            this.Hide();
            formCombos.Show();

        }

        private void btnPlatosFuertes_Click(object sender, EventArgs e)
        {
            FormPlatosFuertes formPlatosFuertes = new FormPlatosFuertes();
            this.Hide();
            formPlatosFuertes.Show();
        }

        private void btnPostresYBebidas_Click(object sender, EventArgs e)
        {
            FormExtras formExtras = new FormExtras();
            this.Hide();
            formExtras.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Saldrá de la aplicación\n¿Desea continuar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
