﻿using AppKiosco.models;
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
        DeviceLibrary.DeviceLibrary device;

        public Payment(string balance)
        {
            InitializeComponent();

            device = new DeviceLibrary.DeviceLibrary();
            device.Open();

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

            device.Close();
            this.Parent.Parent.Controls[1].Text = "welcome";
        }

        private void MakePay(float pay) {
            deposito = deposito + pay;
            restan = deuda - deposito;
            tbPaymentDepo.Text = deposito.ToString("0.00");
            tbPaymentRest.Text = restan.ToString("0.00");

            if (restan <= 0.0f) {
                restan = restan * -1.0f;
                deuda = 0.0f;
                tbPaymentRest.Text = "00.00";

                MoneyExchange moneyExchange = Util.DispenseChange((decimal)restan);
                string change = "CHANGE:\n";
                for (int i = 0; i < moneyExchange.pairs.Count; i++)
                {
                    change += moneyExchange.pairs[i].denomination + " x " + moneyExchange.pairs[i].amount + "\n";
                }
                MessageBox.Show(change);
                device.Enable();
                device.Dispense((decimal)restan);
                device.Disable();

                SendPay();
            }
        }

        private void InsertDocument(decimal denomination) {
            DeviceLibrary.Models.Document dep = new DeviceLibrary.Models.Document(denomination, DeviceLibrary.Models.Enums.DocumentType.Bill, 1);
            device.Enable();
            device.SimulateInsertion(dep);
            device.Disable();
        }

        private void btPaym_500_Click(object sender, EventArgs e)
        {
            InsertDocument(500);

            MakePay(500.0f);
        }

        private void btPaym_200_Click(object sender, EventArgs e)
        {
            InsertDocument(200);

            MakePay(200.0f);
        }

        private void btPaym_100_Click(object sender, EventArgs e)
        {
            InsertDocument(100);

            MakePay(100.0f);
        }

        private void btPaym_50_Click(object sender, EventArgs e)
        {
            InsertDocument(50);

            MakePay(50.0f);
        }

        private void btPaym_20_Click(object sender, EventArgs e)
        {
            InsertDocument(20);

            MakePay(20.0f);
        }

        private void btPaym_10_Click(object sender, EventArgs e)
        {
            InsertDocument(10);

            MakePay(10.0f);
        }

        private void btPaym_5_Click(object sender, EventArgs e)
        {
            InsertDocument(5);

            MakePay(5.0f);
        }

        private void btPaym_2_Click(object sender, EventArgs e)
        {
            InsertDocument(2);

            MakePay(2.0f);
        }

        private void btPaym_1_Click(object sender, EventArgs e)
        {
            InsertDocument(1);

            MakePay(1.0f);
        }

        private void btPaym_0_50_Click(object sender, EventArgs e)
        {
            InsertDocument(0.50M);

            MakePay(0.50f);
        }
    }
}
