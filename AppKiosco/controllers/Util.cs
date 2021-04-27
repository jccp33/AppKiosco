using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using AppKiosco.models;
using System.Drawing;

namespace AppKiosco.Controllers
{
    class Util
    {
        public static Point CenterPoint(Size s1, Size s2) {
            int width = s1.Width / 2 - s2.Width / 2;
            int height = s1.Height / 2 - s2.Height / 2 - 100;
            return new Point(width, height);
        }

        public static bool IsJsonObject(string str) {
            try {
                JObject json = JObject.Parse(str);
                return true;
            }catch (Exception e) {
                return false;
            }
        }

        public static MoneyExchange DispenseChange(decimal cant) {
            MoneyExchange moneyExchange = new MoneyExchange();
			if (cant >= 500){
				decimal denom = 500;
				int amount = (int)(cant / denom);
				moneyExchange.Add(denom, amount);
				cant = cant - amount * denom;
			}
            if (cant >= 200)
            {
                decimal denom = 200;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= 100)
            {
                decimal denom = 100;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= 50)
            {
                decimal denom = 50;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= 20)
            {
                decimal denom = 20;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= 10)
            {
                decimal denom = 10;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= 5)
            {
                decimal denom = 5;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= 2)
            {
                decimal denom = 2;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= 1)
            {
                decimal denom = 1;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            if (cant >= (decimal)0.50)
            {
                decimal denom = 0.50M;
                int amount = (int)(cant / denom);
                moneyExchange.Add(denom, amount);
                cant = cant - amount * denom;
            }
            return moneyExchange;
        }
    }
}
