
namespace CasaSchimbValutar
{
    partial class MainForm
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
			this.btnNewT = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.lvTransactions = new System.Windows.Forms.ListView();
			this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvCnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvCurr1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnNewT
			// 
			this.btnNewT.Location = new System.Drawing.Point(26, 40);
			this.btnNewT.Name = "btnNewT";
			this.btnNewT.Size = new System.Drawing.Size(128, 24);
			this.btnNewT.TabIndex = 0;
			this.btnNewT.Text = "New transaction";
			this.btnNewT.UseVisualStyleBackColor = true;
			this.btnNewT.Click += new System.EventHandler(this.btnNewTClick);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(26, 82);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(128, 23);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "Converter";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// lvTransactions
			// 
			this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvId,
            this.lvName,
            this.lvSurname,
            this.lvCnp,
            this.lvAmount,
            this.lvCurr1,
            this.lvDate});
			this.lvTransactions.HideSelection = false;
			this.lvTransactions.Location = new System.Drawing.Point(12, 121);
			this.lvTransactions.Name = "lvTransactions";
			this.lvTransactions.Size = new System.Drawing.Size(589, 302);
			this.lvTransactions.TabIndex = 4;
			this.lvTransactions.UseCompatibleStateImageBehavior = false;
			this.lvTransactions.View = System.Windows.Forms.View.Details;
			// 
			// lvName
			// 
			this.lvName.Text = "Name";
			this.lvName.Width = 78;
			// 
			// lvSurname
			// 
			this.lvSurname.Text = "Surname";
			this.lvSurname.Width = 96;
			// 
			// lvId
			// 
			this.lvId.Text = "ID";
			this.lvId.Width = 54;
			// 
			// lvCnp
			// 
			this.lvCnp.Text = "CNP";
			this.lvCnp.Width = 113;
			// 
			// lvAmount
			// 
			this.lvAmount.Text = "Amount";
			// 
			// lvCurr1
			// 
			this.lvCurr1.Text = "Currency";
			// 
			// lvDate
			// 
			this.lvDate.Text = "Transaction date";
			this.lvDate.Width = 97;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 435);
			this.Controls.Add(this.lvTransactions);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnNewT);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewT;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListView lvTransactions;
		private System.Windows.Forms.ColumnHeader lvName;
		private System.Windows.Forms.ColumnHeader lvSurname;
		private System.Windows.Forms.ColumnHeader lvId;
		private System.Windows.Forms.ColumnHeader lvCnp;
		private System.Windows.Forms.ColumnHeader lvAmount;
		private System.Windows.Forms.ColumnHeader lvCurr1;
		private System.Windows.Forms.ColumnHeader lvDate;
	}
}

