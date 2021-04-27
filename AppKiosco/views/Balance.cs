﻿using AppKiosco.Controllers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppKiosco.views
{
    public partial class Balance : UserControl
    {
        public Balance(string balance)
        {
            InitializeComponent();

            if (Util.IsJsonObject(balance)) {
                JObject obj = JObject.Parse(balance);
                tbBalanceAccount.Text = obj.GetValue("account").ToString();
                tbBalanceUser.Text = obj.GetValue("user").ToString();

                float debt = float.Parse(obj.GetValue("debt").ToString());
                if (debt <= 0.0f) {
                    tbBalanceDebt.Text = "00.00";
                }else {
                    tbBalanceDebt.Text = obj.GetValue("debt").ToString();
                }
            }
        }
    }
}
