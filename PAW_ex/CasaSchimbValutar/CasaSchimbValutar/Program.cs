using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//=> RON,EUR,USD,GBP,CHF

namespace CasaSchimbValutar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //Ratele raportate la RON 

            ExchangeRate rateRON = new ExchangeRate();
            rateRON.rate = 1;

            ExchangeRate rateEUR = new ExchangeRate();
            rateEUR.rate = 0.20;

            ExchangeRate rateUSD = new ExchangeRate();
            rateUSD.rate = 0.24;

            ExchangeRate rateGBP = new ExchangeRate();
            rateGBP.rate = 0.18;

            ExchangeRate rateCHF = new ExchangeRate();
            rateCHF.rate = 0.22;


            Currency RON = new Currency("Romanian Leu", "RON", rateRON);
            Currency EUR = new Currency("European EURO", "EUR", rateEUR);
            Currency USD = new Currency("American Dollar", "USD", rateUSD);
            Currency GBP = new Currency("British Pound", "GBP", rateGBP);
            Currency CHF = new Currency("Swiss Franc", "CHF", rateCHF);

            List<Currency> cbList = null;
            cbList.Add(RON);
            cbList.Add(EUR);
            cbList.Add(USD);
            cbList.Add(GBP);
            cbList.Add(CHF);
        }
    }


    
}
