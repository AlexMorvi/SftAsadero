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
    public partial class FormFactura : Form
    {
        
        public FormFactura()
        {
            InitializeComponent();
            btnSalir.Enabled = false;
            btnPagar.Enabled = false;
            btnFactura.Enabled = false;
        }
        private void FormFactura_load (object sender, EventArgs e)
        {
            lblAdvertencia.Hide();
            lblObliNombre.Hide();
            lblObliCi.Hide();
            lblObiTelefono.Hide();
            lblObliDireccion.Hide();
        }
        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtCedula.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text);
            btnFactura.Enabled = vr;
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su transacción se realizó con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormBienvenida formBienvenida = new FormBienvenida();
            factura.subtotal = 0;
            factura.descripcion = null;
            factura.total = 0;
            cliente.nombre = null;
            cliente.cedula = null;
            cliente.direccion = null;
            cliente.telefono = null;
            this.Hide();
            formBienvenida.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Saldrá de la aplicación\n¿Desea continuar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        
        private void btnFactura_Click(object sender, EventArgs e)
        {
            factura.total = factura.subtotal+(factura.subtotal * 0.12);
            cliente.nombre = txtNombre.Text;
            cliente.cedula = txtCedula.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = txtTelefono.Text;
            fecha.anio = DateTime.Now.ToString("yyyy");
            fecha.mes = DateTime.Now.ToString("MM");
            fecha.dia = DateTime.Now.ToString("dd");
            fecha.hora = DateTime.Now.ToString("HH:mm");
            txtFacturaDatos.Text = "\t\tFACTURA\r\t\t\n\r\nNombre del Cliente:\r\t"+cliente.nombre+ "\r\n" +"Numero de Cedula:\r\t" +cliente.cedula + "\r\n"+"Telefono:\r\t"+ cliente.telefono + "\r\n" +"Direccion\r\t"+ cliente.direccion + "\r\n" +"Fecha:\r\t" + fecha.dia+"/"+ fecha.mes+"/"+fecha.anio+"\r\t"+"Hora:    "+fecha.hora+"\r\n\r\nCantidad\r\tProducto\r\t\tPrecio Unitario\r\n\r\n" + Convert.ToString(factura.descripcion) + "\r\n" + "Subtotal\t\t\t" +"$"+ Convert.ToString(factura.subtotal)+"\r\nTotal\t\t\t"+"$"+factura.total;
            btnSalir.Enabled = true;
            btnPagar.Enabled = true;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if(txtNombre.Text.Equals(""))
            {
                txtNombre.BackColor = Color.Red;
                lblAdvertencia.Show();
                lblObliNombre.Show();
            }
            else
            {
                txtNombre.BackColor = Color.Black;
                lblObliNombre.Hide();
            }
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            if (txtCedula.Text.Equals(""))
            {
                txtCedula.BackColor = Color.Red;
                lblAdvertencia.Show();
                lblObliCi.Show();
            }
            else
            {
                txtCedula.BackColor = Color.Black;
                lblObliCi.Hide();
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Equals(""))
            {
                txtTelefono.BackColor = Color.Red;
                lblAdvertencia.Show();
                lblObiTelefono.Show();
            }
            else
            {
                txtTelefono.BackColor = Color.Black;
                lblObiTelefono.Hide();
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Equals(""))
            {
                txtDireccion.BackColor = Color.Red;
                lblAdvertencia.Show();
                lblObliDireccion.Show();
            }
            else
            {
                txtDireccion.BackColor = Color.Black;
                lblAdvertencia.Hide();
                lblObliDireccion.Hide();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar >57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar > 32 && e.KeyChar <= 64)|| (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}
