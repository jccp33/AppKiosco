using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppKiosco.views
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btAccount_1_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "1";
        }

        private void btAccount_2_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "2";
        }

        private void btAccount_3_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "3";
        }

        private void btAccount_4_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "4";
        }

        private void btAccount_5_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "5";
        }

        private void btAccount_6_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "6";
        }

        private void btAccount_7_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "7";
        }

        private void btAccount_8_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "8";
        }

        private void btAccount_9_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "9";
        }

        private void btAccount_0_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text += "0";
        }

        private void btAccount_back_Click(object sender, EventArgs e)
        {
            if (tbAccountNumber.Text.Length > 0) {
                tbAccountNumber.Text = tbAccountNumber.Text.Substring(0, tbAccountNumber.Text.Length - 1);
            }
        }
    }
}
