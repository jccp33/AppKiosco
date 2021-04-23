
namespace AppKiosco.views
{
    partial class Home
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbHomeTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHomeTitle
            // 
            this.lbHomeTitle.AutoSize = true;
            this.lbHomeTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHomeTitle.Location = new System.Drawing.Point(58, 261);
            this.lbHomeTitle.Name = "lbHomeTitle";
            this.lbHomeTitle.Size = new System.Drawing.Size(477, 37);
            this.lbHomeTitle.TabIndex = 1;
            this.lbHomeTitle.Text = "TOQUE LA PANTALLA PARA INICIAR";
            this.lbHomeTitle.Click += new System.EventHandler(this.LoadAccountView);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbHomeTitle);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(600, 600);
            this.Click += new System.EventHandler(this.LoadAccountView);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHomeTitle;
    }
}
