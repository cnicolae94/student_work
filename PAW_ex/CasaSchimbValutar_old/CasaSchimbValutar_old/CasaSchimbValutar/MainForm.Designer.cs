
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
			this.components = new System.ComponentModel.Container();
			this.btnNewT = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.lvTransactions = new System.Windows.Forms.ListView();
			this.lvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvCurr1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvEndAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvCurr2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mainMS = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deserializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnStats = new System.Windows.Forms.Button();
			this.lvMS = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tEXTchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTest = new System.Windows.Forms.TextBox();
			this.lbTest = new System.Windows.Forms.Label();
			this.mainMS.SuspendLayout();
			this.lvMS.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNewT
			// 
			this.btnNewT.Location = new System.Drawing.Point(14, 32);
			this.btnNewT.Name = "btnNewT";
			this.btnNewT.Size = new System.Drawing.Size(128, 42);
			this.btnNewT.TabIndex = 0;
			this.btnNewT.Text = "New &transaction";
			this.btnNewT.UseVisualStyleBackColor = true;
			this.btnNewT.Click += new System.EventHandler(this.btnNewTClick);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(510, 32);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(128, 42);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "&Converter";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// lvTransactions
			// 
			this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvID,
            this.lvDate,
            this.lvName,
            this.lvSurname,
            this.lvCNP,
            this.lvAmount,
            this.lvCurr1,
            this.lvEndAmount,
            this.lvCurr2});
			this.lvTransactions.ContextMenuStrip = this.lvMS;
			this.lvTransactions.FullRowSelect = true;
			this.lvTransactions.GridLines = true;
			this.lvTransactions.HideSelection = false;
			this.lvTransactions.HoverSelection = true;
			this.lvTransactions.Location = new System.Drawing.Point(14, 89);
			this.lvTransactions.Name = "lvTransactions";
			this.lvTransactions.Size = new System.Drawing.Size(624, 302);
			this.lvTransactions.TabIndex = 4;
			this.lvTransactions.UseCompatibleStateImageBehavior = false;
			this.lvTransactions.View = System.Windows.Forms.View.Details;
			this.lvTransactions.DoubleClick += new System.EventHandler(this.lvTransactions_DoubleClick);
			// 
			// lvID
			// 
			this.lvID.Text = "ID";
			this.lvID.Width = 46;
			// 
			// lvDate
			// 
			this.lvDate.Text = "Transaction Date";
			this.lvDate.Width = 97;
			// 
			// lvName
			// 
			this.lvName.Text = "Name";
			this.lvName.Width = 72;
			// 
			// lvSurname
			// 
			this.lvSurname.Text = "Surname";
			this.lvSurname.Width = 91;
			// 
			// lvCNP
			// 
			this.lvCNP.Text = "CNP/ID nr.";
			// 
			// lvAmount
			// 
			this.lvAmount.Text = "Amount";
			// 
			// lvCurr1
			// 
			this.lvCurr1.Text = "Currency";
			this.lvCurr1.Width = 59;
			// 
			// lvEndAmount
			// 
			this.lvEndAmount.Text = "End Amount";
			this.lvEndAmount.Width = 75;
			// 
			// lvCurr2
			// 
			this.lvCurr2.Text = "Currency";
			// 
			// mainMS
			// 
			this.mainMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMS.Location = new System.Drawing.Point(0, 0);
			this.mainMS.Name = "mainMS";
			this.mainMS.Size = new System.Drawing.Size(650, 24);
			this.mainMS.TabIndex = 5;
			this.mainMS.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationToolStripMenuItem,
            this.deserializationToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// serializationToolStripMenuItem
			// 
			this.serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
			this.serializationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.serializationToolStripMenuItem.Text = "&Serialization";
			// 
			// deserializationToolStripMenuItem
			// 
			this.deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
			this.deserializationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deserializationToolStripMenuItem.Text = "&Deserialization";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.printToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// btnStats
			// 
			this.btnStats.Location = new System.Drawing.Point(256, 32);
			this.btnStats.Name = "btnStats";
			this.btnStats.Size = new System.Drawing.Size(128, 42);
			this.btnStats.TabIndex = 6;
			this.btnStats.Text = "&Stats for nerds";
			this.btnStats.UseVisualStyleBackColor = true;
			// 
			// lvMS
			// 
			this.lvMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDataToolStripMenuItem,
            this.pasteDataToolStripMenuItem});
			this.lvMS.Name = "lvMS";
			this.lvMS.Size = new System.Drawing.Size(130, 48);
			this.lvMS.Text = "Options";
			this.lvMS.Opening += new System.ComponentModel.CancelEventHandler(this.lvMS_Opening);
			// 
			// copyDataToolStripMenuItem
			// 
			this.copyDataToolStripMenuItem.Name = "copyDataToolStripMenuItem";
			this.copyDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.copyDataToolStripMenuItem.Text = "Cop&y Data";
			this.copyDataToolStripMenuItem.Click += new System.EventHandler(this.copyDataToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEXTchangeToolStripMenuItem,
            this.cSVToolStripMenuItem});
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// tEXTchangeToolStripMenuItem
			// 
			this.tEXTchangeToolStripMenuItem.Name = "tEXTchangeToolStripMenuItem";
			this.tEXTchangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.tEXTchangeToolStripMenuItem.Text = "TEXT //change";
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printToolStripMenuItem.Text = "Print";
			// 
			// cSVToolStripMenuItem
			// 
			this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
			this.cSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cSVToolStripMenuItem.Text = "CSV";
			// 
			// pasteDataToolStripMenuItem
			// 
			this.pasteDataToolStripMenuItem.Name = "pasteDataToolStripMenuItem";
			this.pasteDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.pasteDataToolStripMenuItem.Text = "&Paste Data";
			// 
			// txtTest
			// 
			this.txtTest.Location = new System.Drawing.Point(14, 416);
			this.txtTest.Name = "txtTest";
			this.txtTest.Size = new System.Drawing.Size(624, 20);
			this.txtTest.TabIndex = 7;
			// 
			// lbTest
			// 
			this.lbTest.AutoSize = true;
			this.lbTest.Location = new System.Drawing.Point(12, 400);
			this.lbTest.Name = "lbTest";
			this.lbTest.Size = new System.Drawing.Size(147, 13);
			this.lbTest.TabIndex = 8;
			this.lbTest.Text = "Test the copy/paste function.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 446);
			this.Controls.Add(this.lbTest);
			this.Controls.Add(this.txtTest);
			this.Controls.Add(this.btnStats);
			this.Controls.Add(this.lvTransactions);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnNewT);
			this.Controls.Add(this.mainMS);
			this.MainMenuStrip = this.mainMS;
			this.Name = "MainForm";
			this.Text = "ExchangeManager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainMS.ResumeLayout(false);
			this.mainMS.PerformLayout();
			this.lvMS.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewT;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListView lvTransactions;
		private System.Windows.Forms.ColumnHeader lvID;
		private System.Windows.Forms.ColumnHeader lvDate;
		private System.Windows.Forms.ColumnHeader lvName;
		private System.Windows.Forms.ColumnHeader lvSurname;
		private System.Windows.Forms.ColumnHeader lvCNP;
		private System.Windows.Forms.ColumnHeader lvAmount;
		private System.Windows.Forms.ColumnHeader lvCurr1;
		private System.Windows.Forms.ColumnHeader lvEndAmount;
		private System.Windows.Forms.ColumnHeader lvCurr2;
		private System.Windows.Forms.MenuStrip mainMS;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button btnStats;
		private System.Windows.Forms.ToolStripMenuItem serializationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deserializationToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip lvMS;
		private System.Windows.Forms.ToolStripMenuItem copyDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tEXTchangeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteDataToolStripMenuItem;
		private System.Windows.Forms.TextBox txtTest;
		private System.Windows.Forms.Label lbTest;
	}
}

