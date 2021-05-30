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
	public partial class ViewTransaction : Form
	{
		public ViewTransaction()
		{
			InitializeComponent();
			txtName.Text = MainForm.lvTransactions.SelectedItems
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
				this.Close();
		}
	}
}
