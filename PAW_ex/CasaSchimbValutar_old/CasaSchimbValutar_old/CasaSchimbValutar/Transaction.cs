using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CasaSchimbValutar
{
    class Transaction
    {
        public long id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String CNP { get; set; }
        public double amount { get; set; }
        public Currency currencyFrom { get; set; }
        public double endAmount { get; set; }
        public Currency currencyTo { get; set; }
        public DateTime transactionDate { get; set; }

        //private static int globalID = 1000; 
      
        public Transaction()
        {
           
            id = 1000;
        }

        public Transaction(long id, String name, String surname, double amount, Currency currencyFrom, double endAmount, Currency currencyTo, DateTime transactionDate) 
        {
            //globalID = ++id;
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.amount = amount;
            this.currencyFrom = currencyFrom;
            this.endAmount = endAmount;
            this.currencyTo = currencyTo;
            this.transactionDate = transactionDate;
        }

    }
}
