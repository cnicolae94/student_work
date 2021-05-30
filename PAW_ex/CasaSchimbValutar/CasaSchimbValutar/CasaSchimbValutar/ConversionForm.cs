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
                        MessageBox.Show("No currency selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
            float aux = convertRON();
            double aux2 = 1;
            switch (cbCurr2.SelectedItem)
            {
                case "RON":
                    txtTo.Text = aux.ToString();
                    break;
                case "EUR":
                    aux2 = aux * 0.2;
                    txtTo.Text = aux2.ToString();
                    break;
                case "USD":
                    aux2 = aux * 0.24;
                    txtTo.Text = aux2.ToString();
                    break;
                case "GBP":
                    aux2 = aux * 0.18;
                    txtTo.Text = aux2.ToString();
                    break;
                case "CHF":
                    aux2 = aux * 0.22;
                    txtTo.Text = aux2.ToString();
                    break;
                default:
                    MessageBox.Show("Please input the amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
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
                errTxtFrom.SetError(txtFrom, 
                    "Please input the amount to be converted."); ;
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
                errCurr1.SetError(cbCurr1, "Please select the currency.");
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
                errCurr2.SetError(cbCurr2, "Please select the currency.");
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
            //bool temp = isSelected();
            if (txtFrom.Text.All(char.IsDigit))
            {
                    btnConvert.Enabled = true;
            }
        }
       

        

        
    }    
}
