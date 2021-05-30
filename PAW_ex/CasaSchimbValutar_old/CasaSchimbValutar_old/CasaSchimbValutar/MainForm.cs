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
        private readonly List<Transaction> transactions;
        #endregion

        public MainForm()
        {
            transactions = new List<Transaction>();
            InitializeComponent();

            //Ratele raportate la RON 

            //ExchangeRate rateRON = new ExchangeRate();
            //rateRON.rate = 1;

            //ExchangeRate rateEUR = new ExchangeRate();
            //rateEUR.rate = 0.20;

            //ExchangeRate rateUSD = new ExchangeRate();
            //rateUSD.rate = 0.24;

            //ExchangeRate rateGBP = new ExchangeRate();
            //rateGBP.rate = 0.18;

            //ExchangeRate rateCHF = new ExchangeRate();
            //rateCHF.rate = 0.22;


            //Currency RON = new Currency("Romanian Leu", "RON", rateRON);
            //Currency EUR = new Currency("European EURO", "EUR", rateEUR);
            //Currency USD = new Currency("American Dollar", "USD", rateUSD);
            //Currency GBP = new Currency("British Pound", "GBP", rateGBP);
            //Currency CHF = new Currency("Swiss Franc", "CHF", rateCHF);

            //List<Currency> cbList = new List<Currency>();
            //cbList.Add(RON);
            //cbList.Add(EUR);
            //cbList.Add(USD);
            //cbList.Add(GBP);
            //cbList.Add(CHF);


            //introducerea currency in baza de date

            //const string connectionCurr = "Data Source=baza.db";

            //var cmdAdd = "INSERT INTO Currency(name, iso, rate)" +
            //	" VALUES (@name, @iso, @rate);";

            //foreach (Currency c in cbList)
            //{
            //	using (SQLiteConnection connection = new SQLiteConnection(connectionCurr))
            //	{
            //		connection.Open();
            //		SQLiteCommand command = new SQLiteCommand(cmdAdd, connection);
            //		command.Parameters.AddWithValue("@name", c.name);
            //		command.Parameters.AddWithValue("@iso", c.iso);
            //		command.Parameters.AddWithValue("@iso", c.iso);
            //		command.Parameters.AddWithValue("@rate", c.rate.rate);
            //		//Console.WriteLine(c.rate); - test line
            //		command.ExecuteNonQuery();
            //	}
            //}

        }

        #region Methods

            public void displayTransactions()
        {
            lvTransactions.Items.Clear();

            foreach (Transaction t in transactions)
            {
                var lvItem = new ListViewItem(t.id.ToString());
                lvItem.SubItems.Add(t.transactionDate.ToShortDateString());
                lvItem.SubItems.Add(t.name);
                lvItem.SubItems.Add(t.surname);
                lvItem.SubItems.Add(t.CNP);
                lvItem.SubItems.Add(t.amount.ToString());
                lvItem.SubItems.Add(t.currencyFrom.iso);
                lvItem.SubItems.Add(t.endAmount.ToString());
                lvItem.SubItems.Add(t.currencyTo.iso);


                lvItem.Tag = t;
                lvTransactions.Items.Add(lvItem);
            }

        }

        private void loadTransactions()
        {
            const string cmdSQL = "SELECT * FROM Transactions";

            using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
            {
                connection.Open();
                var cmd = new SQLiteCommand(cmdSQL, connection);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["id"];
                        DateTime transactionDate = DateTime.Parse((string)reader["transactionDate"]);
                        string name = (string)reader["name"];
                        string surname = (string)reader["surname"];
                        String CNP = Convert.ToString((string)reader["CNP"]);
                        double amount = double.Parse(reader["amount"].ToString());
                        Currency c1 = new Currency();
                        c1.iso = (string)reader["currencyFrom"];
                        double endAmount = double.Parse(reader["endAmount"].ToString());
                        Currency c2 = new Currency();
                        c2.iso = (string)reader["currencyTo"];

                        Transaction _t = new Transaction(id, name, surname, amount, c1, endAmount, c2, transactionDate);
                        transactions.Add(_t);
                    }
                }
            }
        }

        private void deleteTransaction(Transaction t)
        {
            const string cmdDel = "DELETE FROM Transactions WHERE id=@id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
            {
                connection.Open();
                var cmd = new SQLiteCommand(cmdDel, connection);

                cmd.Parameters.AddWithValue("@id", t.id);
                cmd.ExecuteNonQuery();


                transactions.Remove(t);
            }
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
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadTransactions();
                displayTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //de sters vvvvvv
        private void lvTransactions_DoubleClick(object sender, EventArgs e)
        {
           
            if (lvTransactions.SelectedItems.Count >= 0)
            {
                Form ViewTransaction = new ViewTransaction();
                ViewTransaction.ShowDialog();
            }
            
            
        }

		private void copyDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //copy selected row
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //delete selected row
		}

		private void lvMS_Opening(object sender, CancelEventArgs e)
		{

		}
	}	
}
