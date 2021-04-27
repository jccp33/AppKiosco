using System;
using System.Collections.Generic;
using System.Text;

namespace AppKiosco.models
{
    public class MoneyExchange
    {
        public class Pair
        {
            public decimal denomination { get; set; }
            public int amount { get; set; }

            public Pair(decimal denomination, int amount) {
                this.denomination = denomination;
                this.amount = amount;
            }
        }

        public List<Pair> pairs = new List<Pair>();

        public void Add(decimal denomination, int amount) {
            pairs.Add(new Pair(denomination, amount));
        }
    }
}
