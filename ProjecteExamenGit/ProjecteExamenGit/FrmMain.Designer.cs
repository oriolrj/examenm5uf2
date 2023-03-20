namespace ProjecteExamenGit
{
    partial class FrmMain
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
            this.btnGroc = new System.Windows.Forms.Button();
            this.btnVerd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGroc
            // 
            this.btnGroc.Location = new System.Drawing.Point(374, 105);
            this.btnGroc.Name = "btnGroc";
            this.btnGroc.Size = new System.Drawing.Size(75, 23);
            this.btnGroc.TabIndex = 0;
            this.btnGroc.Text = "Groc";
            this.btnGroc.UseVisualStyleBackColor = true;
            this.btnGroc.Click += new System.EventHandler(this.btnGroc_Click);
            // 
            // btnVerd
            // 
            this.btnVerd.Location = new System.Drawing.Point(363, 214);
            this.btnVerd.Name = "btnVerd";
            this.btnVerd.Size = new System.Drawing.Size(75, 23);
            this.btnVerd.TabIndex = 1;
            this.btnVerd.Text = "Verd";
            this.btnVerd.UseVisualStyleBackColor = true;
            this.btnVerd.Click += new System.EventHandler(this.btnVerd_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerd);
            this.Controls.Add(this.btnGroc);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGroc;
        private System.Windows.Forms.Button btnVerd;
    }
}

