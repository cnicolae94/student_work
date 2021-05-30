using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace CasaSchimbValutar
{
    public partial class MainForm : Form
    {
        #region Attributes
        private const string connectionDB = "Data Source=baza.db";
        private readonly List<Transaction> _transactions;
        
        #endregion

        public MainForm()
        {
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

            List<Currency> cbList = new List<Currency>();
            cbList.Add(RON);
            cbList.Add(EUR);
            cbList.Add(USD);
            cbList.Add(GBP);
            cbList.Add(CHF);

			//am introdus elementele "valuta" in DB

            //const string connectionCurr = "Data Source=baza.db";
			
            //var cmdAdd = "INSERT INTO Currency(name, iso, rate)" +
            //    " VALUES (@name, @iso, @rate);";
           
            //foreach (Currency c in cbList)
            //{
            //    using (SQLiteConnection connection = new SQLiteConnection(connectionCurr))
            //    {
            //        connection.Open();
            //        SQLiteCommand command = new SQLiteCommand(cmdAdd, connection);
            //        command.Parameters.AddWithValue("@name", c.name);
            //        command.Parameters.AddWithValue("@iso", c.iso);
            //        command.Parameters.AddWithValue("@rate", c.rate.rate);
            //        //Console.WriteLine(c.rate); - test line
            //        command.ExecuteNonQuery();
            //    }
            //}
            InitializeComponent();
        }


        private void btnNewTClick(object sender, EventArgs e)
        {
            Form NewTransactionForm = new NewTransactionForm();
            NewTransactionForm.ShowDialog();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Form NewConversionForm = new ConversionForm();
            NewConversionForm.ShowDialog();
        }
    }
}
