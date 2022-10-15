using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency
{
    internal class Currency
    {
        public string currencyCode { get; set; }
        public string currencyName { get; set; }
        public double Rate { get; set; }
        public Currency(string code, string name, double rate)
        {
            currencyCode = code;
            currencyName = name;
            Rate = rate;
        }
        
    }
}
