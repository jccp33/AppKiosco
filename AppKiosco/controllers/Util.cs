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
    }
}
