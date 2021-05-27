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
            txtID.Text = t.id.ToString();
            DateTime d = new DateTime();
            d = DateTime.Now;
            txtDateTime.Text = d.ToShortDateString();
            
        }

        List<Transaction> lista = null; //initializam lista

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
            MessageBox.Show("Are you sure?", "Yes/No", MessageBoxButtons.YesNo);
            if (!chkTOS.Checked)
            {
                MessageBox.Show("Please read the terms of service.");
            }
            if(txtCNP.TextLength < 12)
            {
                MessageBox.Show("Please review the ID number input.");
            }

            //introducem obiectele in lista
            Transaction t = new Transaction();
            t.amount = float.Parse(txtFrom.ToString());
            //ATENTIE
            //t.currencyFrom = cbCurr1.SelectedValue.ToString();
            t.endAmount = float.Parse(txtTo.ToString());
            t.id = int.Parse(txtID.ToString());


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
