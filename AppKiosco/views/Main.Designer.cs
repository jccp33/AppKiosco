
namespace AppKiosco.views
{
    partial class Main
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbMainData = new System.Windows.Forms.Label();
            this.btMainPrev = new System.Windows.Forms.Button();
            this.btMainNext = new System.Windows.Forms.Button();
            this.gbMainButtons = new System.Windows.Forms.GroupBox();
            this.lbMainControl = new System.Windows.Forms.Label();
            this.gbMainButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(12, 61);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 600);
            this.panelMain.TabIndex = 0;
            // 
            // lbMainData
            // 
            this.lbMainData.AutoSize = true;
            this.lbMainData.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMainData.Location = new System.Drawing.Point(1, 24);
            this.lbMainData.Name = "lbMainData";
            this.lbMainData.Size = new System.Drawing.Size(30, 15);
            this.lbMainData.TabIndex = 5;
            this.lbMainData.Text = "data";
            // 
            // btMainPrev
            // 
            this.btMainPrev.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMainPrev.Location = new System.Drawing.Point(6, 22);
            this.btMainPrev.Name = "btMainPrev";
            this.btMainPrev.Size = new System.Drawing.Size(178, 53);
            this.btMainPrev.TabIndex = 1;
            this.btMainPrev.Text = "< Anterior";
            this.btMainPrev.UseVisualStyleBackColor = true;
            this.btMainPrev.Click += new System.EventHandler(this.btMainPrev_Click);
            // 
            // btMainNext
            // 
            this.btMainNext.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMainNext.Location = new System.Drawing.Point(416, 22);
            this.btMainNext.Name = "btMainNext";
            this.btMainNext.Size = new System.Drawing.Size(178, 53);
            this.btMainNext.TabIndex = 2;
            this.btMainNext.Text = "Siguiente >";
            this.btMainNext.UseVisualStyleBackColor = true;
            this.btMainNext.Click += new System.EventHandler(this.btMainNext_Click);
            // 
            // gbMainButtons
            // 
            this.gbMainButtons.Controls.Add(this.btMainPrev);
            this.gbMainButtons.Controls.Add(this.btMainNext);
            this.gbMainButtons.Location = new System.Drawing.Point(12, 708);
            this.gbMainButtons.Name = "gbMainButtons";
            this.gbMainButtons.Size = new System.Drawing.Size(600, 90);
            this.gbMainButtons.TabIndex = 3;
            this.gbMainButtons.TabStop = false;
            // 
            // lbMainControl
            // 
            this.lbMainControl.AutoSize = true;
            this.lbMainControl.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMainControl.Location = new System.Drawing.Point(1, 0);
            this.lbMainControl.Name = "lbMainControl";
            this.lbMainControl.Size = new System.Drawing.Size(55, 15);
            this.lbMainControl.TabIndex = 4;
            this.lbMainControl.Text = "welcome";
            this.lbMainControl.TextChanged += new System.EventHandler(this.LoadView);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 810);
            this.Controls.Add(this.lbMainData);
            this.Controls.Add(this.lbMainControl);
            this.Controls.Add(this.gbMainButtons);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Kiosco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbMainButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btMainPrev;
        private System.Windows.Forms.Button btMainNext;
        private System.Windows.Forms.GroupBox gbMainButtons;
        private System.Windows.Forms.Label lbMainControl;
        private System.Windows.Forms.Label lbMainData;
    }
}