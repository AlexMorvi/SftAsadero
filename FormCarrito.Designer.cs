namespace SftAsadero
{
    partial class FormCarrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrito));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMas = new System.Windows.Forms.Button();
            this.btnTerminarCompra = new System.Windows.Forms.Button();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(352, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Desea añadir algo más al carrito?";
            // 
            // btnAgregarMas
            // 
            this.btnAgregarMas.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarMas.Location = new System.Drawing.Point(169, 586);
            this.btnAgregarMas.Name = "btnAgregarMas";
            this.btnAgregarMas.Size = new System.Drawing.Size(185, 51);
            this.btnAgregarMas.TabIndex = 2;
            this.btnAgregarMas.Text = "Añadir más";
            this.btnAgregarMas.UseVisualStyleBackColor = false;
            this.btnAgregarMas.Click += new System.EventHandler(this.btnAgregarMas_Click);
            // 
            // btnTerminarCompra
            // 
            this.btnTerminarCompra.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTerminarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarCompra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTerminarCompra.Location = new System.Drawing.Point(940, 586);
            this.btnTerminarCompra.Name = "btnTerminarCompra";
            this.btnTerminarCompra.Size = new System.Drawing.Size(188, 51);
            this.btnTerminarCompra.TabIndex = 3;
            this.btnTerminarCompra.Text = "Terminar Compra";
            this.btnTerminarCompra.UseVisualStyleBackColor = false;
            this.btnTerminarCompra.Click += new System.EventHandler(this.btnTerminarCompra_Click);
            // 
            // txtCarrito
            // 
            this.txtCarrito.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCarrito.Enabled = false;
            this.txtCarrito.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCarrito.Location = new System.Drawing.Point(414, 176);
            this.txtCarrito.Multiline = true;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCarrito.Size = new System.Drawing.Size(468, 353);
            this.txtCarrito.TabIndex = 4;
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SftAsadero.Properties.Resources.fire_1235718_960_720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 725);
            this.ControlBox = false;
            this.Controls.Add(this.txtCarrito);
            this.Controls.Add(this.btnTerminarCompra);
            this.Controls.Add(this.btnAgregarMas);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCarrito";
            this.Text = "Asadero Poliitos En Fuga";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMas;
        private System.Windows.Forms.Button btnTerminarCompra;
        private System.Windows.Forms.TextBox txtCarrito;
    }
}