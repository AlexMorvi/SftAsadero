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
            txtFacturaDatos.Text = "\t\tFACTURA\r\t\t\n\r\nNombre del Cliente:\r\t"+cliente.nombre+ "\r\n" +"Numero de Cedula:\r\t" +cliente.cedula + "\r\n"+"Telefono:\r\t"+ cliente.telefono + "\r\n" +"Direccion\r\t"+ cliente.direccion + "\r\n" +"Fecha:\r\t" + fecha.dia+"/"+ fecha.mes+"/"+fecha.anio+"\r\n\r\nCantidad\r\tProducto\r\t\tPrecio Unitario\r\n\r\n" + Convert.ToString(factura.descripcion) + "\r\n" + "Subtotal\t\t\t" + Convert.ToString(factura.subtotal)+"\r\nTotal\t\t\t"+factura.total;
            btnSalir.Enabled = true;
            btnPagar.Enabled = true;
        }
    }
}
