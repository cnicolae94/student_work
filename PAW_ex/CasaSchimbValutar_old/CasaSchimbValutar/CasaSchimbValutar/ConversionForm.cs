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
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        public float convertRON()
        {   
            String a = txtFrom.Text;
            float b = float.Parse(a);
            float result = 0;
            if (b >= 0)
            {
                switch (cbCurr1.SelectedItem)
                {
                    case "RON":
                        result = b;
                        break;
                    case "EUR":
                        result = (float)(b / 0.2);
                        break;
                    case "USD":
                        result = (float)(b / 0.24);
                        break;
                    case "GBP":
                        result = (float)(b / 0.18);
                        break;
                    case "CHF":
                        result = (float)(b / 0.22);
                        break;
                    default:
                        MessageBox.Show("Please select the currency.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        break;
                }
                float temp = result;
                return temp;
            }
            else
            {
                return result;
            }
        }

        void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
			if (!ValidateChildren())
			{
                MessageBox.Show("The details are incorrect, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
			{
                float aux = convertRON();
                double aux2 = 1;
                switch (cbCurr2.SelectedItem)
                {
                    case "RON":
                        txtTo.Text = Math.Round(aux, 2).ToString();
                        break;
                    case "EUR":
                        aux2 = aux * 0.2;
                        txtTo.Text = Math.Round(aux2, 2).ToString();
                        break;
                    case "USD":
                        aux2 = aux * 0.24;
                        txtTo.Text = Math.Round(aux2, 2).ToString();
                        break;
                    case "GBP":
                        aux2 = aux * 0.18;
                        txtTo.Text = Math.Round(aux2, 2).ToString();
                        break;
                    case "CHF":
                        aux2 = aux * 0.22;
                        txtTo.Text = Math.Round(aux2, 2).ToString();
                        break;
                    default:
                        MessageBox.Show("Please select the currency.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
			}
			catch(Exception)
			{
                MessageBox.Show("The details are incorrect, please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //private bool isSelected(){
        //    if (cbCurr1.SelectedIndex != -1 && cbCurr2.SelectedIndex != -1)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        private void txtFrom_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFrom.Text))
            {
                errTxtFrom.SetError(txtFrom, "Please input the amount to be converted."); ;
            }
        }

        private void txtFrom_Validated(object sender, EventArgs e)
        {
            errTxtFrom.SetError((Control)sender, String.Empty);
        }

        private void cbCurr1_Validating(object sender, CancelEventArgs e)
        {
            if(cbCurr1.SelectedIndex == -1)
            {
                errCurr1.SetError(cbCurr1, "Currency missing");
            }
        }

        private void cbCurr1_Validated(object sender, EventArgs e)
        {
            if (cbCurr1.SelectedIndex > -1)
            { 
                errCurr1.SetError((Control)sender, String.Empty);
            }
        }

        private void cbCurr2_Validating(object sender, CancelEventArgs e)
        {
            if (cbCurr2.SelectedIndex == -1)
            {
                errCurr2.SetError(cbCurr2, "Currency missing");
            }
        }

        private void cbCurr2_Validated(object sender, EventArgs e)
        {
            if (cbCurr2.SelectedIndex > -1)
            {
                errCurr2.SetError((Control)sender, String.Empty);
            }
        }

        private void btnCancelConverter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

		private void txtFrom_TextChanged(object sender, EventArgs e)
		{
			if (txtFrom.Text.All(char.IsDigit))
			{
				btnConvert.Enabled = true;
			}
		}

	}    
}
