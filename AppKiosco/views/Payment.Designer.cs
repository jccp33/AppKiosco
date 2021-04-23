
namespace AppKiosco.views
{
    partial class Payment
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
            this.tbPaymentRest = new System.Windows.Forms.TextBox();
            this.tbPaymentDepo = new System.Windows.Forms.TextBox();
            this.tbPaymentDeuda = new System.Windows.Forms.TextBox();
            this.lbPaymentRest = new System.Windows.Forms.Label();
            this.lbPaymentDep = new System.Windows.Forms.Label();
            this.lbPaymentDeuda = new System.Windows.Forms.Label();
            this.btPaym_500 = new System.Windows.Forms.Button();
            this.btPaym_200 = new System.Windows.Forms.Button();
            this.btPaym_100 = new System.Windows.Forms.Button();
            this.btPaym_50 = new System.Windows.Forms.Button();
            this.btPaym_20 = new System.Windows.Forms.Button();
            this.btPaym_10 = new System.Windows.Forms.Button();
            this.btPaym_5 = new System.Windows.Forms.Button();
            this.btPaym_2 = new System.Windows.Forms.Button();
            this.btPaym_1 = new System.Windows.Forms.Button();
            this.btPaym_0_50 = new System.Windows.Forms.Button();
            this.lbPaymentTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPaymentRest
            // 
            this.tbPaymentRest.Enabled = false;
            this.tbPaymentRest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPaymentRest.Location = new System.Drawing.Point(407, 205);
            this.tbPaymentRest.Name = "tbPaymentRest";
            this.tbPaymentRest.Size = new System.Drawing.Size(157, 39);
            this.tbPaymentRest.TabIndex = 14;
            // 
            // tbPaymentDepo
            // 
            this.tbPaymentDepo.Enabled = false;
            this.tbPaymentDepo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPaymentDepo.Location = new System.Drawing.Point(220, 205);
            this.tbPaymentDepo.Name = "tbPaymentDepo";
            this.tbPaymentDepo.Size = new System.Drawing.Size(157, 39);
            this.tbPaymentDepo.TabIndex = 13;
            // 
            // tbPaymentDeuda
            // 
            this.tbPaymentDeuda.Enabled = false;
            this.tbPaymentDeuda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPaymentDeuda.Location = new System.Drawing.Point(30, 205);
            this.tbPaymentDeuda.Name = "tbPaymentDeuda";
            this.tbPaymentDeuda.Size = new System.Drawing.Size(157, 39);
            this.tbPaymentDeuda.TabIndex = 12;
            // 
            // lbPaymentRest
            // 
            this.lbPaymentRest.AutoSize = true;
            this.lbPaymentRest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPaymentRest.Location = new System.Drawing.Point(422, 170);
            this.lbPaymentRest.Name = "lbPaymentRest";
            this.lbPaymentRest.Size = new System.Drawing.Size(127, 32);
            this.lbPaymentRest.TabIndex = 11;
            this.lbPaymentRest.Text = "RESTANTE:";
            // 
            // lbPaymentDep
            // 
            this.lbPaymentDep.AutoSize = true;
            this.lbPaymentDep.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPaymentDep.Location = new System.Drawing.Point(219, 170);
            this.lbPaymentDep.Name = "lbPaymentDep";
            this.lbPaymentDep.Size = new System.Drawing.Size(159, 32);
            this.lbPaymentDep.TabIndex = 10;
            this.lbPaymentDep.Text = "DEPOSITADO:";
            // 
            // lbPaymentDeuda
            // 
            this.lbPaymentDeuda.AutoSize = true;
            this.lbPaymentDeuda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPaymentDeuda.Location = new System.Drawing.Point(60, 170);
            this.lbPaymentDeuda.Name = "lbPaymentDeuda";
            this.lbPaymentDeuda.Size = new System.Drawing.Size(95, 32);
            this.lbPaymentDeuda.TabIndex = 9;
            this.lbPaymentDeuda.Text = "DEUDA:";
            // 
            // btPaym_500
            // 
            this.btPaym_500.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_500.Location = new System.Drawing.Point(35, 385);
            this.btPaym_500.Name = "btPaym_500";
            this.btPaym_500.Size = new System.Drawing.Size(100, 50);
            this.btPaym_500.TabIndex = 15;
            this.btPaym_500.Text = "$500";
            this.btPaym_500.UseVisualStyleBackColor = true;
            this.btPaym_500.Click += new System.EventHandler(this.btPaym_500_Click);
            // 
            // btPaym_200
            // 
            this.btPaym_200.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_200.Location = new System.Drawing.Point(141, 385);
            this.btPaym_200.Name = "btPaym_200";
            this.btPaym_200.Size = new System.Drawing.Size(100, 50);
            this.btPaym_200.TabIndex = 16;
            this.btPaym_200.Text = "$200";
            this.btPaym_200.UseVisualStyleBackColor = true;
            this.btPaym_200.Click += new System.EventHandler(this.btPaym_200_Click);
            // 
            // btPaym_100
            // 
            this.btPaym_100.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_100.Location = new System.Drawing.Point(247, 385);
            this.btPaym_100.Name = "btPaym_100";
            this.btPaym_100.Size = new System.Drawing.Size(100, 50);
            this.btPaym_100.TabIndex = 17;
            this.btPaym_100.Text = "$100";
            this.btPaym_100.UseVisualStyleBackColor = true;
            this.btPaym_100.Click += new System.EventHandler(this.btPaym_100_Click);
            // 
            // btPaym_50
            // 
            this.btPaym_50.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_50.Location = new System.Drawing.Point(353, 385);
            this.btPaym_50.Name = "btPaym_50";
            this.btPaym_50.Size = new System.Drawing.Size(100, 50);
            this.btPaym_50.TabIndex = 18;
            this.btPaym_50.Text = "$50";
            this.btPaym_50.UseVisualStyleBackColor = true;
            this.btPaym_50.Click += new System.EventHandler(this.btPaym_50_Click);
            // 
            // btPaym_20
            // 
            this.btPaym_20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_20.Location = new System.Drawing.Point(459, 385);
            this.btPaym_20.Name = "btPaym_20";
            this.btPaym_20.Size = new System.Drawing.Size(100, 50);
            this.btPaym_20.TabIndex = 19;
            this.btPaym_20.Text = "$20";
            this.btPaym_20.UseVisualStyleBackColor = true;
            this.btPaym_20.Click += new System.EventHandler(this.btPaym_20_Click);
            // 
            // btPaym_10
            // 
            this.btPaym_10.BackColor = System.Drawing.Color.Gray;
            this.btPaym_10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_10.Location = new System.Drawing.Point(105, 467);
            this.btPaym_10.Name = "btPaym_10";
            this.btPaym_10.Size = new System.Drawing.Size(50, 50);
            this.btPaym_10.TabIndex = 20;
            this.btPaym_10.Text = "$10";
            this.btPaym_10.UseVisualStyleBackColor = false;
            this.btPaym_10.Click += new System.EventHandler(this.btPaym_10_Click);
            // 
            // btPaym_5
            // 
            this.btPaym_5.BackColor = System.Drawing.Color.Gray;
            this.btPaym_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_5.Location = new System.Drawing.Point(187, 467);
            this.btPaym_5.Name = "btPaym_5";
            this.btPaym_5.Size = new System.Drawing.Size(50, 50);
            this.btPaym_5.TabIndex = 21;
            this.btPaym_5.Text = "$5";
            this.btPaym_5.UseVisualStyleBackColor = false;
            this.btPaym_5.Click += new System.EventHandler(this.btPaym_5_Click);
            // 
            // btPaym_2
            // 
            this.btPaym_2.BackColor = System.Drawing.Color.Gray;
            this.btPaym_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_2.Location = new System.Drawing.Point(272, 467);
            this.btPaym_2.Name = "btPaym_2";
            this.btPaym_2.Size = new System.Drawing.Size(50, 50);
            this.btPaym_2.TabIndex = 22;
            this.btPaym_2.Text = "$2";
            this.btPaym_2.UseVisualStyleBackColor = false;
            this.btPaym_2.Click += new System.EventHandler(this.btPaym_2_Click);
            // 
            // btPaym_1
            // 
            this.btPaym_1.BackColor = System.Drawing.Color.Gray;
            this.btPaym_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_1.Location = new System.Drawing.Point(354, 467);
            this.btPaym_1.Name = "btPaym_1";
            this.btPaym_1.Size = new System.Drawing.Size(50, 50);
            this.btPaym_1.TabIndex = 23;
            this.btPaym_1.Text = "$1";
            this.btPaym_1.UseVisualStyleBackColor = false;
            this.btPaym_1.Click += new System.EventHandler(this.btPaym_1_Click);
            // 
            // btPaym_0_50
            // 
            this.btPaym_0_50.BackColor = System.Drawing.Color.Gray;
            this.btPaym_0_50.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPaym_0_50.Location = new System.Drawing.Point(437, 467);
            this.btPaym_0_50.Name = "btPaym_0_50";
            this.btPaym_0_50.Size = new System.Drawing.Size(50, 50);
            this.btPaym_0_50.TabIndex = 24;
            this.btPaym_0_50.Text = "¢50";
            this.btPaym_0_50.UseVisualStyleBackColor = false;
            this.btPaym_0_50.Click += new System.EventHandler(this.btPaym_0_50_Click);
            // 
            // lbPaymentTitle
            // 
            this.lbPaymentTitle.AutoSize = true;
            this.lbPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPaymentTitle.Location = new System.Drawing.Point(172, 25);
            this.lbPaymentTitle.Name = "lbPaymentTitle";
            this.lbPaymentTitle.Size = new System.Drawing.Size(269, 37);
            this.lbPaymentTitle.TabIndex = 25;
            this.lbPaymentTitle.Text = "ABONAR A CUENTA";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbPaymentTitle);
            this.Controls.Add(this.btPaym_0_50);
            this.Controls.Add(this.btPaym_1);
            this.Controls.Add(this.btPaym_2);
            this.Controls.Add(this.btPaym_5);
            this.Controls.Add(this.btPaym_10);
            this.Controls.Add(this.btPaym_20);
            this.Controls.Add(this.btPaym_50);
            this.Controls.Add(this.btPaym_100);
            this.Controls.Add(this.btPaym_200);
            this.Controls.Add(this.btPaym_500);
            this.Controls.Add(this.tbPaymentRest);
            this.Controls.Add(this.tbPaymentDepo);
            this.Controls.Add(this.tbPaymentDeuda);
            this.Controls.Add(this.lbPaymentRest);
            this.Controls.Add(this.lbPaymentDep);
            this.Controls.Add(this.lbPaymentDeuda);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPaymentRest;
        private System.Windows.Forms.TextBox tbPaymentDepo;
        private System.Windows.Forms.TextBox tbPaymentDeuda;
        private System.Windows.Forms.Label lbPaymentRest;
        private System.Windows.Forms.Label lbPaymentDep;
        private System.Windows.Forms.Label lbPaymentDeuda;
        private System.Windows.Forms.Button btPaym_500;
        private System.Windows.Forms.Button btPaym_200;
        private System.Windows.Forms.Button btPaym_100;
        private System.Windows.Forms.Button btPaym_50;
        private System.Windows.Forms.Button btPaym_20;
        private System.Windows.Forms.Button btPaym_10;
        private System.Windows.Forms.Button btPaym_5;
        private System.Windows.Forms.Button btPaym_2;
        private System.Windows.Forms.Button btPaym_1;
        private System.Windows.Forms.Button btPaym_0_50;
        private System.Windows.Forms.Label lbPaymentTitle;
    }
}
