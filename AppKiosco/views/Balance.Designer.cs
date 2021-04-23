
namespace AppKiosco.views
{
    partial class Balance
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
            this.lbBalanceAccount = new System.Windows.Forms.Label();
            this.lbBalanceUser = new System.Windows.Forms.Label();
            this.lbBalanceDebt = new System.Windows.Forms.Label();
            this.tbBalanceAccount = new System.Windows.Forms.TextBox();
            this.tbBalanceUser = new System.Windows.Forms.TextBox();
            this.tbBalanceDebt = new System.Windows.Forms.TextBox();
            this.lbBalanceTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBalanceAccount
            // 
            this.lbBalanceAccount.AutoSize = true;
            this.lbBalanceAccount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBalanceAccount.Location = new System.Drawing.Point(46, 128);
            this.lbBalanceAccount.Name = "lbBalanceAccount";
            this.lbBalanceAccount.Size = new System.Drawing.Size(129, 37);
            this.lbBalanceAccount.TabIndex = 3;
            this.lbBalanceAccount.Text = "CUENTA:";
            // 
            // lbBalanceUser
            // 
            this.lbBalanceUser.AutoSize = true;
            this.lbBalanceUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBalanceUser.Location = new System.Drawing.Point(46, 258);
            this.lbBalanceUser.Name = "lbBalanceUser";
            this.lbBalanceUser.Size = new System.Drawing.Size(144, 37);
            this.lbBalanceUser.TabIndex = 4;
            this.lbBalanceUser.Text = "USUARIO:";
            // 
            // lbBalanceDebt
            // 
            this.lbBalanceDebt.AutoSize = true;
            this.lbBalanceDebt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBalanceDebt.Location = new System.Drawing.Point(46, 388);
            this.lbBalanceDebt.Name = "lbBalanceDebt";
            this.lbBalanceDebt.Size = new System.Drawing.Size(117, 37);
            this.lbBalanceDebt.TabIndex = 5;
            this.lbBalanceDebt.Text = "DEUDA:";
            // 
            // tbBalanceAccount
            // 
            this.tbBalanceAccount.Enabled = false;
            this.tbBalanceAccount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBalanceAccount.Location = new System.Drawing.Point(181, 129);
            this.tbBalanceAccount.Name = "tbBalanceAccount";
            this.tbBalanceAccount.Size = new System.Drawing.Size(351, 39);
            this.tbBalanceAccount.TabIndex = 6;
            // 
            // tbBalanceUser
            // 
            this.tbBalanceUser.Enabled = false;
            this.tbBalanceUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBalanceUser.Location = new System.Drawing.Point(196, 259);
            this.tbBalanceUser.Name = "tbBalanceUser";
            this.tbBalanceUser.Size = new System.Drawing.Size(336, 39);
            this.tbBalanceUser.TabIndex = 7;
            // 
            // tbBalanceDebt
            // 
            this.tbBalanceDebt.Enabled = false;
            this.tbBalanceDebt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBalanceDebt.Location = new System.Drawing.Point(169, 389);
            this.tbBalanceDebt.Name = "tbBalanceDebt";
            this.tbBalanceDebt.Size = new System.Drawing.Size(363, 39);
            this.tbBalanceDebt.TabIndex = 8;
            // 
            // lbBalanceTitle
            // 
            this.lbBalanceTitle.AutoSize = true;
            this.lbBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBalanceTitle.Location = new System.Drawing.Point(151, 41);
            this.lbBalanceTitle.Name = "lbBalanceTitle";
            this.lbBalanceTitle.Size = new System.Drawing.Size(292, 37);
            this.lbBalanceTitle.TabIndex = 9;
            this.lbBalanceTitle.Text = "BALANCE DE CUENTA";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbBalanceTitle);
            this.Controls.Add(this.tbBalanceDebt);
            this.Controls.Add(this.tbBalanceUser);
            this.Controls.Add(this.tbBalanceAccount);
            this.Controls.Add(this.lbBalanceDebt);
            this.Controls.Add(this.lbBalanceUser);
            this.Controls.Add(this.lbBalanceAccount);
            this.Name = "Balance";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBalanceAccount;
        private System.Windows.Forms.Label lbBalanceUser;
        private System.Windows.Forms.Label lbBalanceDebt;
        private System.Windows.Forms.TextBox tbBalanceAccount;
        private System.Windows.Forms.TextBox tbBalanceUser;
        private System.Windows.Forms.TextBox tbBalanceDebt;
        private System.Windows.Forms.Label lbBalanceTitle;
    }
}
