using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppKiosco.models;
using AppKiosco.Controllers;
using Newtonsoft.Json.Linq;

namespace AppKiosco.views
{
    public partial class Main : Form
    {
        DeviceLibrary.DeviceLibrary device;

        public Main()
        {
            InitializeComponent();

            device = new DeviceLibrary.DeviceLibrary();
            device.Open();

            Point point = Util.CenterPoint(Screen.PrimaryScreen.Bounds.Size, panelMain.Size);
            gbMainButtons.Location = new Point(point.X, point.Y + panelMain.Size.Height);
            gbMainButtons.Visible = false;
            panelMain.Location = point;
            Home home = new Home();
            panelMain.Controls.Add(home);
        }

        private void LoadView(object sender, EventArgs e)
        {
            if (lbMainControl.Text == "welcome") {
                lbMainData.Text = "data";
                panelMain.Controls.Clear();
                Home home = new Home();
                panelMain.Controls.Add(home);
                gbMainButtons.Visible = false;
                btMainNext.Enabled = true;
            }else if (lbMainControl.Text == "account") {
                lbMainData.Text = "data";
                panelMain.Controls.Clear();
                Account account = new Account();
                panelMain.Controls.Add(account);
                btMainPrev.Text = "< Cancelar";
                btMainNext.Text = "Continuar >";
                btMainNext.Enabled = true;
                gbMainButtons.Visible = true;
            }else if (lbMainControl.Text == "balance") {

                if (panelMain.Controls[0].Controls[11].Text == "") {
                    MessageBox.Show("INGRESE UN NUMERO DE CUENTA");
                    lbMainControl.Text = "account";
                }else {
                    string account = panelMain.Controls[0].Controls[11].Text;
                    string balance = WebService.GetBalance(account);
                    
                    if (Util.IsJsonObject(balance) && balance.Contains("user") && balance.Contains("debt")) {
                        lbMainData.Text = balance;

                        JObject obj = JObject.Parse(balance);
                        float debt = float.Parse(obj.GetValue("debt").ToString());
                        if (debt <= 0.0f)
                        {
                            btMainNext.Enabled = false;
                        }else {
                            btMainNext.Enabled = true;
                        }
                    }

                    if (Util.IsJsonObject(lbMainData.Text) && lbMainData.Text.Contains("user") && lbMainData.Text.Contains("debt")) {
                        JObject obj = JObject.Parse(lbMainData.Text);
                        if (!obj.ContainsKey("account")) {
                            obj.Add("account", account);
                        }
                        lbMainData.Text = obj.ToString();
                        
                        panelMain.Controls.Clear();
                        Balance _balance = new Balance(obj.ToString());
                        panelMain.Controls.Add(_balance);
                        btMainPrev.Text = "< Volver";
                        btMainNext.Text = "Pagar >";
                    }else {
                        MessageBox.Show("ERROR DE SERVIDOR");
                        lbMainControl.Text = "account";
                    }
                }

            }else if (lbMainControl.Text == "payment") {
                panelMain.Controls.Clear();
                Payment payment = new Payment(lbMainData.Text);
                panelMain.Controls.Add(payment);

                btMainPrev.Text = "< Cancelar";
                btMainNext.Text = "Abonar >";
            }else if (lbMainControl.Text == "send_pay") {
                float deuda = 0.0f;
                float deposito = 0.0f;
                float restan = 0.0f;
                
                for (int i=0; i<panelMain.Controls[0].Controls.Count; i++) {
                    if (panelMain.Controls[0].Controls[i].Name == "tbPaymentDeuda") {
                        deuda = float.Parse(panelMain.Controls[0].Controls[i].Text);
                    }
                    if (panelMain.Controls[0].Controls[i].Name == "tbPaymentDepo"){
                        deposito = float.Parse(panelMain.Controls[0].Controls[i].Text);
                    }
                    if (panelMain.Controls[0].Controls[i].Name == "tbPaymentRest")
                    {
                        restan = float.Parse(panelMain.Controls[0].Controls[i].Text);
                    }
                }

                if (Util.IsJsonObject(lbMainData.Text)) {
                    JObject obj = JObject.Parse(lbMainData.Text);
                    models.Payment paym = new models.Payment();
                    paym.id = 0;
                    paym.account = obj.GetValue("account").ToString();
                    paym.customer = obj.GetValue("user").ToString(); ;
                    paym.debt = restan;
                    paym.paid = deposito;
                    paym.date = DateTime.Now.ToString("dd/MM/yyyy hh:mm");

                    DeviceLibrary.Models.Document dep = new DeviceLibrary.Models.Document((decimal)deposito, DeviceLibrary.Models.Enums.DocumentType.Bill, 1);
                    device.SimulateInsertion(dep);

                    SQLiteService sqlite = new SQLiteService();
                    if (sqlite.InsertPay(paym) == "OK")
                    {
                        MessageBox.Show("PAGO REGISTRADO");
                    }
                    else
                    {
                        MessageBox.Show("ERROR DE SISTEMA");
                    }

                    if (WebService.PostTransaction(paym.account, paym.paid) != "OK"){
                        MessageBox.Show("ERROR EN SERVIDOR");
                    }

                    lbMainControl.Text = "welcome";
                }
                
            }
        }

        private void btMainNext_Click(object sender, EventArgs e)
        {
            if (lbMainControl.Text == "welcome") {
                lbMainControl.Text = "account";
            }else if (lbMainControl.Text == "account") {
                lbMainControl.Text = "balance";
            }else if (lbMainControl.Text == "balance") {
                lbMainControl.Text = "payment";
            }else if (lbMainControl.Text == "payment") {
                lbMainControl.Text = "send_pay";
            }
        }

        private void btMainPrev_Click(object sender, EventArgs e){
            if (lbMainControl.Text == "account") {
                lbMainControl.Text = "welcome";
            }else if (lbMainControl.Text == "balance") {
                lbMainControl.Text = "account";
            }else if (lbMainControl.Text=="payment" || lbMainControl.Text=="send_pay") {

                List<string> strings = new List<string>();
                for (int i=0; i<panelMain.Controls[0].Controls.Count; i++) {
                    if (panelMain.Controls[0].Controls[i] is TextBox) {
                        strings.Add(panelMain.Controls[0].Controls[i].Text);
                    }
                }
                int count = 0;
                for (int i=0; i<strings.Count; i++) {
                    if (strings[i] != "0.00") {
                        count++;
                    }
                }
                if (count > 1) {
                    MessageBox.Show("NO SE PUEDE CANCELAR LA TRANSACCION");
                }else {
                    lbMainControl.Text = "welcome";
                }
                
            }
        }
    }
}
