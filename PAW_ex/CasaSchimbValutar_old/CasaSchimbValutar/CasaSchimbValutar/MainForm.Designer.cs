
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.lvMS = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMS = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deserializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportAscsvFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTest = new System.Windows.Forms.TextBox();
			this.lbTest = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.psd = new System.Windows.Forms.PageSetupDialog();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.printDialog = new System.Windows.Forms.PrintDialog();
			this.lvMS.SuspendLayout();
			this.mainMS.SuspendLayout();
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
			this.btnConvert.Location = new System.Drawing.Point(148, 32);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(128, 42);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "&Converter";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// lvTransactions
			// 
			this.lvTransactions.AllowDrop = true;
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
			// lvMS
			// 
			this.lvMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDataToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
			this.lvMS.Name = "lvMS";
			this.lvMS.Size = new System.Drawing.Size(134, 48);
			this.lvMS.Text = "Options";
			// 
			// copyDataToolStripMenuItem
			// 
			this.copyDataToolStripMenuItem.Name = "copyDataToolStripMenuItem";
			this.copyDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copyDataToolStripMenuItem.Text = "Cop&y Row";
			this.copyDataToolStripMenuItem.Click += new System.EventHandler(this.copyDataToolStripMenuItem_Click);
			// 
			// deleteRowToolStripMenuItem
			// 
			this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
			this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.deleteRowToolStripMenuItem.Text = "&Delete Row";
			this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
			// 
			// mainMS
			// 
			this.mainMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
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
			this.serializationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.serializationToolStripMenuItem.Text = "Binary &serialization";
			this.serializationToolStripMenuItem.Click += new System.EventHandler(this.serializationToolStripMenuItem_Click);
			// 
			// deserializationToolStripMenuItem
			// 
			this.deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
			this.deserializationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.deserializationToolStripMenuItem.Text = "Binary &deserialization";
			this.deserializationToolStripMenuItem.Click += new System.EventHandler(this.deserializationToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exportAsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem1});
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printToolStripMenuItem.Text = "&Print";
			// 
			// pageSetupToolStripMenuItem
			// 
			this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
			this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pageSetupToolStripMenuItem.Text = "Page &Setup";
			this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
			// 
			// printPreviewToolStripMenuItem
			// 
			this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
			this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printPreviewToolStripMenuItem.Text = "Print Previe&w";
			this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewDialog_Click);
			// 
			// printToolStripMenuItem1
			// 
			this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
			this.printToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.printToolStripMenuItem1.Text = "&Print";
			this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
			// 
			// exportAsToolStripMenuItem
			// 
			this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAscsvFileToolStripMenuItem});
			this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
			this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportAsToolStripMenuItem.Text = "E&xport as...";
			// 
			// exportAscsvFileToolStripMenuItem
			// 
			this.exportAscsvFileToolStripMenuItem.Name = "exportAscsvFileToolStripMenuItem";
			this.exportAscsvFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.exportAscsvFileToolStripMenuItem.Text = "Export as .csv file";
			this.exportAscsvFileToolStripMenuItem.Click += new System.EventHandler(this.exportAscsvFileToolStripMenuItem_Click);
			// 
			// txtTest
			// 
			this.txtTest.AllowDrop = true;
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
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(510, 27);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(128, 42);
			this.btnRefresh.TabIndex = 9;
			this.btnRefresh.Text = "Re&fresh list";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// printDocument
			// 
			this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
			this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
			// 
			// printPreviewDialog
			// 
			this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog.Enabled = true;
			this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
			this.printPreviewDialog.Name = "printPreviewDialog1";
			this.printPreviewDialog.Visible = false;
			this.printPreviewDialog.Click += new System.EventHandler(this.printPreviewDialog_Click);
			// 
			// printDialog
			// 
			this.printDialog.UseEXDialog = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 446);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.lbTest);
			this.Controls.Add(this.txtTest);
			this.Controls.Add(this.lvTransactions);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnNewT);
			this.Controls.Add(this.mainMS);
			this.MainMenuStrip = this.mainMS;
			this.Name = "MainForm";
			this.Text = "ExchangeManager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.lvMS.ResumeLayout(false);
			this.mainMS.ResumeLayout(false);
			this.mainMS.PerformLayout();
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
		private System.Windows.Forms.ToolStripMenuItem serializationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deserializationToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip lvMS;
		private System.Windows.Forms.ToolStripMenuItem copyDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.TextBox txtTest;
		private System.Windows.Forms.Label lbTest;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportAscsvFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
		private System.Windows.Forms.PageSetupDialog psd;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
		private System.Windows.Forms.PrintDialog printDialog;
	}
}

