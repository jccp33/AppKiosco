using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppKiosco.models
{
    class Payment
    {
        public int id { get; set; }
		public string customer { get; set; }
		public string account { get; set; }
		public float debt { get; set; }
		public float paid { get; set; }
		public string date { get; set; }

		public string ToString() {
			return JsonConvert.SerializeObject(this);
		}
    }
}
