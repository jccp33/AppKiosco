using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppKiosco.views
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LoadAccountView(object sender, EventArgs e){
            this.Parent.Parent.Controls[1].Text = "account";
        }
    }
}
