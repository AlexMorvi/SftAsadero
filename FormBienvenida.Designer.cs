namespace SftAsadero
{
    partial class FormBienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenida));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCombos = new System.Windows.Forms.Button();
            this.btnPlatosFuertes = new System.Windows.Forms.Button();
            this.btnPostresYBebidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(288, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a nuestro asadero!!";
            // 
            // btnCombos
            // 
            this.btnCombos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCombos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCombos.Location = new System.Drawing.Point(70, 569);
            this.btnCombos.Name = "btnCombos";
            this.btnCombos.Size = new System.Drawing.Size(234, 55);
            this.btnCombos.TabIndex = 1;
            this.btnCombos.Text = "Combos";
            this.btnCombos.UseVisualStyleBackColor = false;
            // 
            // btnPlatosFuertes
            // 
            this.btnPlatosFuertes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlatosFuertes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnPlatosFuertes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlatosFuertes.Location = new System.Drawing.Point(553, 569);
            this.btnPlatosFuertes.Name = "btnPlatosFuertes";
            this.btnPlatosFuertes.Size = new System.Drawing.Size(234, 55);
            this.btnPlatosFuertes.TabIndex = 2;
            this.btnPlatosFuertes.Text = "Platos Fuertes";
            this.btnPlatosFuertes.UseVisualStyleBackColor = false;
            // 
            // btnPostresYBebidas
            // 
            this.btnPostresYBebidas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPostresYBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnPostresYBebidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPostresYBebidas.Location = new System.Drawing.Point(992, 569);
            this.btnPostresYBebidas.Name = "btnPostresYBebidas";
            this.btnPostresYBebidas.Size = new System.Drawing.Size(234, 55);
            this.btnPostresYBebidas.TabIndex = 3;
            this.btnPostresYBebidas.Text = "Postres y Bebidas";
            this.btnPostresYBebidas.UseVisualStyleBackColor = false;
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SftAsadero.Properties.Resources.Fondo_para_inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 725);
            this.Controls.Add(this.btnPostresYBebidas);
            this.Controls.Add(this.btnPlatosFuertes);
            this.Controls.Add(this.btnCombos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBienvenida";
            this.Text = "Asadero Pollito En fuga";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCombos;
        private System.Windows.Forms.Button btnPlatosFuertes;
        private System.Windows.Forms.Button btnPostresYBebidas;
    }
}

