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
            InitializeComponent();

        }

        private void showTransactions()
        {
            lvTransactions.Items.Clear();

            foreach (Transaction t in _transactions)
            {
                var lvItem = new ListViewItem();
                lvItem.SubItems.Add(t.id.ToString());
                lvItem.SubItems.Add(t.name);
                lvItem.SubItems.Add(t.surname);
                lvItem.SubItems.Add(t.CNP.ToString());
                lvItem.SubItems.Add(t.amount.ToString());
                lvItem.SubItems.Add(t.currencyFrom.ToString());
                lvItem.SubItems.Add(t.endAmount.ToString());
                lvItem.SubItems.Add(t.currencyTo.ToString());
                lvItem.SubItems.Add(t.transactionDate.ToShortDateString());

                lvItem.Tag = t.id;

                lvTransactions.Items.Add(lvItem);
            }
        }

        private void loadTransactions()
        {
            const string cmdSql = "SELECT * FROM Transactions";

            using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
            {
                connection.Open();
                var cmd = new SQLiteCommand(cmdSql, connection); //comanda mai sus cmdSql - pentru care conexiune

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int id = (int)reader["id"];
                        DateTime transactionDate = DateTime.Parse((string)reader["transactionDate"]);
                        string name = (string)reader["name"];
                        string surname = (string)reader["surname"];
                        string CNP = (string)reader["CNP"];
                        float amount = (float)reader["amount"];
                        Currency currencyFrom = (Currency)reader["currencyFrom"];
                        float endAmount = (float)reader["endAmount"];
                        Currency currencyTo = (Currency)reader["currencyTo"];

                        Transaction t = new Transaction(id, name, surname, amount, currencyFrom, endAmount, currencyTo, transactionDate);
                        _transactions.Add(t);
                    }
                }
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
    }
}
