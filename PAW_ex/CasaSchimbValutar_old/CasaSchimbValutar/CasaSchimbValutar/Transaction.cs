using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CasaSchimbValutar
{
    [Serializable] 
    
    class Transaction //: IDataObject
    { 
        public long id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string CNP { get; set; }
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

        public Transaction(long id, string name, string surname, string CNP, double amount, Currency currencyFrom, double endAmount, Currency currencyTo, DateTime transactionDate) 
        {
            //globalID = ++id;
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.CNP = CNP;
            this.amount = amount;
            this.currencyFrom = currencyFrom;
            this.endAmount = endAmount;
            this.currencyTo = currencyTo;
            this.transactionDate = transactionDate;
        }

    }
}
