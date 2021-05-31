using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
			
		}

		#region Attributes
		private const string connectionDB = "Data Source=baza.db";
		#endregion

		private void ViewTransaction_Load(object sender, EventArgs e)
		{
			txtID.Text = MainForm.transactionID;
			txtName.Text = MainForm.transactionName;
			txtSurname.Text = MainForm.transactionSurname;
			dtPick.Value = DateTime.Parse(MainForm.transactionDate);
			
			txtCNP.Text = MainForm.transactionCNP;
			txtFrom.Text = MainForm.transactionAmount;
			cbCurr1.Text = MainForm.transactionCurr1;
			txtTo.Text = MainForm.transactionEndAmount;
			cbCurr2.Text = MainForm.transactionCurr2;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
				this.Close();
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			txtName.Enabled = true;
			txtSurname.Enabled = true;
			txtCNP.Enabled = true;
			dtPick.Enabled = true;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(result == DialogResult.Yes)
			{
		
				const string cmdDel = "DELETE FROM Transactions WHERE id=@id";
				using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
				{
					connection.Open();
					var cmd = new SQLiteCommand(cmdDel, connection);

					cmd.Parameters.AddWithValue("@id", txtID.Text);
					cmd.ExecuteNonQuery();
				}
				this.Close();
			}
		}

		private void txtUpdate_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("This cannot be undone. Proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if(result == DialogResult.Yes)
			{
				const string cmdUpdate = "UPDATE Transactions SET name=@name, surname=@surname, transactionDate=@transactionDate, cnp=@cnp WHERE id=@id";

				using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
				{
					var cmd = new SQLiteCommand(cmdUpdate, connection);
					{
						connection.Open();
						cmd.Parameters.AddWithValue("@name", txtName.Text);
						cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
						cmd.Parameters.AddWithValue("@transactionDate", dtPick.Text);
						cmd.Parameters.AddWithValue("@cnp", txtCNP.Text);
						cmd.Parameters.AddWithValue("@id", txtID.Text);
						cmd.ExecuteNonQuery();
					}
				}
				this.Close();
			}
		}

		private void dtPick_Validating(object sender, CancelEventArgs e)
		{
			if (dtPick.Value.Date > DateTime.Today)
			{
				errDate.SetError((Control)sender, "The date cannot be in the future.");
			}
		}

		private void dtPick_Validated(object sender, EventArgs e)
		{
			if (dtPick.Value.Date > DateTime.Today)
			{
				errDate.SetError((Control)sender, "The date cannot be in the future.");
				btnUpdate.Enabled = false;
			}
			else
			{
				errDate.SetError((Control)sender, string.Empty);
				btnUpdate.Enabled = true;
			}
				
		}
	}
}
