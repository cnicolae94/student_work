using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaSchimbValutar
{
    class Transaction
    {
        public int id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String CNP { get; set; }
        public float amount { get; set; }
        public Currency currencyFrom { get; set; }
        public float endAmount { get; set; }
        public Currency currencyTo { get; set; }
        public DateTime transactionDate { get; set; }
        private static int globalID { get; set; }
      
        public Transaction()
        {
            id = 1000;
        }

        public Transaction(int id, String name, String surname, float amount, Currency currencyFrom, float endAmount, Currency currencyTo, DateTime transactionDate)
        {
            this.id = ++globalID;
            this.name = name;
            this.surname = surname;
            this.amount = amount;
            this.currencyFrom = currencyFrom;
            this.endAmount = endAmount;
            this.currencyTo = currencyTo;
            this.transactionDate = transactionDate;
        }

        //private int generate_id() //pt incrementarea nr de tranzactii / id-ul
        //{ 
        //    return id++;
        //}

    }
}
