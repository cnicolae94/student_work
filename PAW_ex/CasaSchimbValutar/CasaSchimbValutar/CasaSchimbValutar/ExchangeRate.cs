using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaSchimbValutar
{
    class ExchangeRate
    {
        public double rate { get; set; }
        //public DateTime dateOfRate { get; set; }

        public ExchangeRate()
        {

        }

        public ExchangeRate(double rate)
        {
            this.rate = rate;
            //this.dateOfRate = dateOfRate;
        }
    }

    
}
