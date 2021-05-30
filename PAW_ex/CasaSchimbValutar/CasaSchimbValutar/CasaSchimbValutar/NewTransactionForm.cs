using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaSchimbValutar
{
    public partial class NewTransactionForm : Form
    {
        
        public NewTransactionForm()
        {

            InitializeComponent();

			Transaction t = new Transaction();
		}

		List<Transaction> lista = new List<Transaction>();


		private void txtCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelConverter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkTOS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("You would find the Terms of Service here if this wasn't a student project. :)");
        }

        private void btnTransaction_Validating(object sender, CancelEventArgs e)
        {
            if(!chkTOS.Checked)
            {
                errTOS.SetError((Control)sender, "Please read the terms of service and check this box.");
            }
        }


        private void btnTransaction_Validated(object sender, EventArgs e)
        {
            errTOS.SetError((Control)sender, string.Empty);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {

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

			MessageBox.Show("Are you sure?", "Yes/No", MessageBoxButtons.YesNo);

			if (!chkTOS.Checked)
            {
                MessageBox.Show("Please read the terms of service.", "OK", MessageBoxButtons.OK);
            }
            if(txtCNP.TextLength < 12)
            {
                MessageBox.Show("Please review the ID number input.", "OK", MessageBoxButtons.OK);
            }

			//introducem obiectele in lista
			Transaction t = new Transaction();
			t.id = int.Parse(txtID.ToString());
			t.name = txtName.ToString();
			t.surname = txtSurname.ToString();
			t.CNP = txtCNP.ToString();
			t.transactionDate = DateTime.Parse(txtDateTime.Text);
			t.amount = float.Parse(txtFrom.ToString());
			switch (cbCurr1.SelectedItem)
			{
				case "RON":
					t.currencyFrom = RON;
					break;
				case "EUR":
					t.currencyFrom = EUR;
					break;
				case "USD":
					t.currencyFrom = USD;
					break;
				case "GBP":
					t.currencyFrom = GBP;
					break;
				case "CHF":
					t.currencyFrom = CHF;
					break;
				default:
					MessageBox.Show("No currency selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}
			lista.Add(t);
        }

        private void txtCNP_Validating(object sender, CancelEventArgs e)
        {
            if(txtCNP.TextLength < 12)
            {
                errCNP.SetError((Control)sender, "The ID is too short. Please review your input.");
            }
        }

        private void txtCNP_Validated(object sender, EventArgs e)
        {
            errCNP.SetError((Control)sender, String.Empty);
        }
    }
}
