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
    public partial class MainForm : Form
    {
        public MainForm()
        {
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
