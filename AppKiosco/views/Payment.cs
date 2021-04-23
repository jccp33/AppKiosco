using AppKiosco.models;
using AppKiosco.Controllers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace AppKiosco.views
{
    public partial class Payment : UserControl
    {
        private float deuda = 0.0f;
        private float deposito = 0.0f;
        private float restan = 0.0f;
        private string account = "";
        private string user = "";

        public Payment(string balance)
        {
            InitializeComponent();

            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(3, 3, 43, 43);
            Region region = new Region(p);

            btPaym_10.Region = region;
            btPaym_5.Region = region;
            btPaym_2.Region = region;
            btPaym_1.Region = region;
            btPaym_0_50.Region = region;

            if (Util.IsJsonObject(balance)){
                JObject obj = JObject.Parse(balance);
                account = obj.GetValue("account").ToString();
                user = obj.GetValue("user").ToString();
                tbPaymentDeuda.Text = obj.GetValue("debt").ToString();
                tbPaymentDepo.Text = "0.00";
                tbPaymentRest.Text = "0.00";

                deuda = float.Parse(tbPaymentDeuda.Text);
            }
        }

        public Payment()
        {
        }

        private void SendPay(){
            models.Payment payment = new models.Payment();
            payment.id = 0;
            payment.account = account;
            payment.customer = user;
            payment.debt = deuda;
            payment.paid = deposito;
            payment.date = DateTime.Now.ToString("dd/MM/yyyy hh:mm");

            SQLiteService sqlite = new SQLiteService();
            if (sqlite.InsertPay(payment) == "OK") {
                MessageBox.Show("PAGO REGISTRADO");
            }else {
                MessageBox.Show("ERROR DE SISTEMA");
            }

            if (WebService.PostTransaction(payment.account, payment.paid) != "OK") {
                MessageBox.Show("ERROR EN SERVIDOR");
            }

            this.Parent.Parent.Controls[1].Text = "welcome";
        }

        private void MakePay(float pay) {
            deposito = deposito + pay;
            restan = deuda - deposito;
            tbPaymentDepo.Text = deposito.ToString("0.00");
            tbPaymentRest.Text = restan.ToString("0.00");

            if (restan <= 0.0f) {
                SendPay();
            }
        }

        private void btPaym_500_Click(object sender, EventArgs e)
        {
            MakePay(500.0f);
        }

        private void btPaym_200_Click(object sender, EventArgs e)
        {
            MakePay(200.0f);
        }

        private void btPaym_100_Click(object sender, EventArgs e)
        {
            MakePay(100.0f);
        }

        private void btPaym_50_Click(object sender, EventArgs e)
        {
            MakePay(50.0f);
        }

        private void btPaym_20_Click(object sender, EventArgs e)
        {
            MakePay(20.0f);
        }

        private void btPaym_10_Click(object sender, EventArgs e)
        {
            MakePay(10.0f);
        }

        private void btPaym_5_Click(object sender, EventArgs e)
        {
            MakePay(5.0f);
        }

        private void btPaym_2_Click(object sender, EventArgs e)
        {
            MakePay(2.0f);
        }

        private void btPaym_1_Click(object sender, EventArgs e)
        {
            MakePay(1.0f);
        }

        private void btPaym_0_50_Click(object sender, EventArgs e)
        {
            MakePay(0.50f);
        }
    }
}
