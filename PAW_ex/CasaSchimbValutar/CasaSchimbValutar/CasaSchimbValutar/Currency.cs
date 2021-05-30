using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaSchimbValutar
{
    //clasa Valute 
    class Currency
    {
        public String name { get; set; }
        public String iso { get; set; }
        public ExchangeRate rate { get; set; } //curs valutar

        public Currency()
        {

        }

        public Currency(String name, String iso, ExchangeRate rate)
        {
            this.name = name;
            this.iso = iso;
            this.rate = rate;
        }
        
    }
}
