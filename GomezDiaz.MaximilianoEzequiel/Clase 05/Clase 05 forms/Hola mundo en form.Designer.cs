namespace Clase_05_forms
{
    partial class FrmSaludo
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(62, 66);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(512, 98);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "¡¡¡Hola Mundo WinForm!!!";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSaludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(172, 194);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(275, 83);
            this.btnSaludo.TabIndex = 1;
            this.btnSaludo.Text = "Haga click aqui";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSaludo
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 313);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Name = "FrmSaludo";
            this.Tag = "lblSaludo";
            this.Text = "esto tiene que cambiar";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnSaludo;
    }
}

