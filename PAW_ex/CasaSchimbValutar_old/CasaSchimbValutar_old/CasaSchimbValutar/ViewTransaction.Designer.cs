
namespace CasaSchimbValutar
{
	partial class ViewTransaction
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbConverted = new System.Windows.Forms.Label();
			this.lbOriginal = new System.Windows.Forms.Label();
			this.cbCurr2 = new System.Windows.Forms.ComboBox();
			this.cbCurr1 = new System.Windows.Forms.ComboBox();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.txtFrom = new System.Windows.Forms.TextBox();
			this.txtDateTime = new System.Windows.Forms.TextBox();
			this.lbDateTime = new System.Windows.Forms.Label();
			this.txtCNP = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lbCNP = new System.Windows.Forms.Label();
			this.lbSurname = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbConverted
			// 
			this.lbConverted.AutoSize = true;
			this.lbConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbConverted.Location = new System.Drawing.Point(277, 157);
			this.lbConverted.Name = "lbConverted";
			this.lbConverted.Size = new System.Drawing.Size(117, 16);
			this.lbConverted.TabIndex = 42;
			this.lbConverted.Text = "Converted amount";
			// 
			// lbOriginal
			// 
			this.lbOriginal.AutoSize = true;
			this.lbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbOriginal.Location = new System.Drawing.Point(14, 157);
			this.lbOriginal.Name = "lbOriginal";
			this.lbOriginal.Size = new System.Drawing.Size(101, 16);
			this.lbOriginal.TabIndex = 41;
			this.lbOriginal.Text = "Original amount";
			// 
			// cbCurr2
			// 
			this.cbCurr2.Enabled = false;
			this.cbCurr2.FormattingEnabled = true;
			this.cbCurr2.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD",
            "GBP",
            "CHF"});
			this.cbCurr2.Location = new System.Drawing.Point(402, 177);
			this.cbCurr2.Name = "cbCurr2";
			this.cbCurr2.Size = new System.Drawing.Size(71, 21);
			this.cbCurr2.TabIndex = 40;
			// 
			// cbCurr1
			// 
			this.cbCurr1.Enabled = false;
			this.cbCurr1.FormattingEnabled = true;
			this.cbCurr1.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD",
            "GBP",
            "CHF"});
			this.cbCurr1.Location = new System.Drawing.Point(137, 177);
			this.cbCurr1.Name = "cbCurr1";
			this.cbCurr1.Size = new System.Drawing.Size(71, 21);
			this.cbCurr1.TabIndex = 39;
			// 
			// txtTo
			// 
			this.txtTo.Enabled = false;
			this.txtTo.Location = new System.Drawing.Point(280, 177);
			this.txtTo.Name = "txtTo";
			this.txtTo.ReadOnly = true;
			this.txtTo.Size = new System.Drawing.Size(114, 20);
			this.txtTo.TabIndex = 38;
			// 
			// txtFrom
			// 
			this.txtFrom.AcceptsReturn = true;
			this.txtFrom.Enabled = false;
			this.txtFrom.Location = new System.Drawing.Point(17, 178);
			this.txtFrom.Name = "txtFrom";
			this.txtFrom.Size = new System.Drawing.Size(114, 20);
			this.txtFrom.TabIndex = 37;
			// 
			// txtDateTime
			// 
			this.txtDateTime.Enabled = false;
			this.txtDateTime.Location = new System.Drawing.Point(15, 105);
			this.txtDateTime.Name = "txtDateTime";
			this.txtDateTime.Size = new System.Drawing.Size(138, 20);
			this.txtDateTime.TabIndex = 36;
			this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbDateTime
			// 
			this.lbDateTime.AutoSize = true;
			this.lbDateTime.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDateTime.Location = new System.Drawing.Point(12, 86);
			this.lbDateTime.Name = "lbDateTime";
			this.lbDateTime.Size = new System.Drawing.Size(97, 16);
			this.lbDateTime.TabIndex = 35;
			this.lbDateTime.Text = "Date and Time";
			// 
			// txtCNP
			// 
			this.txtCNP.Enabled = false;
			this.txtCNP.Location = new System.Drawing.Point(335, 105);
			this.txtCNP.Name = "txtCNP";
			this.txtCNP.Size = new System.Drawing.Size(138, 20);
			this.txtCNP.TabIndex = 34;
			// 
			// txtSurname
			// 
			this.txtSurname.Enabled = false;
			this.txtSurname.Location = new System.Drawing.Point(335, 37);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(138, 20);
			this.txtSurname.TabIndex = 33;
			// 
			// txtName
			// 
			this.txtName.Enabled = false;
			this.txtName.Location = new System.Drawing.Point(148, 37);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(152, 20);
			this.txtName.TabIndex = 32;
		    // 
			// lbCNP
			// 
			this.lbCNP.AutoSize = true;
			this.lbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCNP.Location = new System.Drawing.Point(332, 86);
			this.lbCNP.Name = "lbCNP";
			this.lbCNP.Size = new System.Drawing.Size(110, 16);
			this.lbCNP.TabIndex = 31;
			this.lbCNP.Text = "CNP / ID Number";
			// 
			// lbSurname
			// 
			this.lbSurname.AutoSize = true;
			this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSurname.Location = new System.Drawing.Point(332, 18);
			this.lbSurname.Name = "lbSurname";
			this.lbSurname.Size = new System.Drawing.Size(62, 16);
			this.lbSurname.TabIndex = 30;
			this.lbSurname.Text = "Surname";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(145, 16);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(45, 16);
			this.lbName.TabIndex = 29;
			this.lbName.Text = "Name";
			// 
			// txtID
			// 
			this.txtID.Enabled = false;
			this.txtID.Location = new System.Drawing.Point(15, 37);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(74, 20);
			this.txtID.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Transaction ID";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(317, 234);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 43;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(14, 234);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 44;
			this.btnChange.Text = "Change";
			this.btnChange.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(398, 234);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 45;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ViewTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 269);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lbConverted);
			this.Controls.Add(this.lbOriginal);
			this.Controls.Add(this.cbCurr2);
			this.Controls.Add(this.cbCurr1);
			this.Controls.Add(this.txtTo);
			this.Controls.Add(this.txtFrom);
			this.Controls.Add(this.txtDateTime);
			this.Controls.Add(this.lbDateTime);
			this.Controls.Add(this.txtCNP);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lbCNP);
			this.Controls.Add(this.lbSurname);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label1);
			this.Name = "ViewTransaction";
			this.Text = "View Transaction";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbConverted;
		private System.Windows.Forms.Label lbOriginal;
		private System.Windows.Forms.ComboBox cbCurr2;
		private System.Windows.Forms.ComboBox cbCurr1;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.TextBox txtDateTime;
		private System.Windows.Forms.Label lbDateTime;
		private System.Windows.Forms.TextBox txtCNP;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lbCNP;
		private System.Windows.Forms.Label lbSurname;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnCancel;
	}
}