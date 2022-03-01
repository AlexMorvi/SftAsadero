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
            this.btnEliminarPedida = new System.Windows.Forms.Button();
            this.btnTerminarCompra = new System.Windows.Forms.Button();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verifique los elementos de su pedido";
            // 
            // btnEliminarPedida
            // 
            this.btnEliminarPedida.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarPedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedida.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminarPedida.Location = new System.Drawing.Point(68, 651);
            this.btnEliminarPedida.Name = "btnEliminarPedida";
            this.btnEliminarPedida.Size = new System.Drawing.Size(185, 51);
            this.btnEliminarPedida.TabIndex = 2;
            this.btnEliminarPedida.Text = "Eliminar Pedido";
            this.btnEliminarPedida.UseVisualStyleBackColor = false;
            this.btnEliminarPedida.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnTerminarCompra
            // 
            this.btnTerminarCompra.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTerminarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarCompra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTerminarCompra.Location = new System.Drawing.Point(1096, 651);
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
            this.txtCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarrito.Enabled = false;
            this.txtCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtCarrito.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCarrito.Location = new System.Drawing.Point(464, 120);
            this.txtCarrito.Multiline = true;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarrito.Size = new System.Drawing.Size(409, 558);
            this.txtCarrito.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(542, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Después de este paso no habrá retorno.";
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::SftAsadero.Properties.Resources.fire_1235718_960_720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 725);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarrito);
            this.Controls.Add(this.btnTerminarCompra);
            this.Controls.Add(this.btnEliminarPedida);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCarrito";
            this.Text = "Asadero Poliitos En Fuga";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarPedida;
        private System.Windows.Forms.Button btnTerminarCompra;
        public System.Windows.Forms.TextBox txtCarrito;
        private System.Windows.Forms.Label label2;
    }
}