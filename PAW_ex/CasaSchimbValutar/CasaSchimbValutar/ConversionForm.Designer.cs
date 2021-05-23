
namespace CasaSchimbValutar
{
    partial class ConversionForm
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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.cbCurr1 = new System.Windows.Forms.ComboBox();
            this.cbCurr2 = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.errTxtFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbOriginal = new System.Windows.Forms.Label();
            this.lbConverted = new System.Windows.Forms.Label();
            this.errCurr1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCurr2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelConverter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errTxtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurr2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.AcceptsReturn = true;
            this.txtFrom.Location = new System.Drawing.Point(25, 41);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(145, 20);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            this.txtFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtFrom_Validating);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(245, 41);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(145, 20);
            this.txtTo.TabIndex = 2;
            // 
            // cbCurr1
            // 
            this.cbCurr1.FormattingEnabled = true;
            this.cbCurr1.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD",
            "GBP",
            "CHF"});
            this.cbCurr1.Location = new System.Drawing.Point(68, 67);
            this.cbCurr1.Name = "cbCurr1";
            this.cbCurr1.Size = new System.Drawing.Size(102, 21);
            this.cbCurr1.TabIndex = 3;
            this.cbCurr1.Validating += new System.ComponentModel.CancelEventHandler(this.cbCurr1_Validating);
            // 
            // cbCurr2
            // 
            this.cbCurr2.FormattingEnabled = true;
            this.cbCurr2.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD",
            "GBP",
            "CHF"});
            this.cbCurr2.Location = new System.Drawing.Point(245, 67);
            this.cbCurr2.Name = "cbCurr2";
            this.cbCurr2.Size = new System.Drawing.Size(96, 21);
            this.cbCurr2.TabIndex = 4;
            this.cbCurr2.Validating += new System.ComponentModel.CancelEventHandler(this.cbCurr2_Validating);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConvert.Location = new System.Drawing.Point(319, 109);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(1);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(71, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // errTxtFrom
            // 
            this.errTxtFrom.ContainerControl = this;
            // 
            // lbOriginal
            // 
            this.lbOriginal.AutoSize = true;
            this.lbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginal.Location = new System.Drawing.Point(22, 19);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(101, 16);
            this.lbOriginal.TabIndex = 8;
            this.lbOriginal.Text = "Original amount";
            // 
            // lbConverted
            // 
            this.lbConverted.AutoSize = true;
            this.lbConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConverted.Location = new System.Drawing.Point(242, 19);
            this.lbConverted.Name = "lbConverted";
            this.lbConverted.Size = new System.Drawing.Size(117, 16);
            this.lbConverted.TabIndex = 9;
            this.lbConverted.Text = "Converted amount";
            // 
            // errCurr1
            // 
            this.errCurr1.ContainerControl = this;
            // 
            // errCurr2
            // 
            this.errCurr2.ContainerControl = this;
            // 
            // btnCancelConverter
            // 
            this.btnCancelConverter.Location = new System.Drawing.Point(25, 109);
            this.btnCancelConverter.Name = "btnCancelConverter";
            this.btnCancelConverter.Size = new System.Drawing.Size(75, 23);
            this.btnCancelConverter.TabIndex = 11;
            this.btnCancelConverter.Text = "Cancel";
            this.btnCancelConverter.UseVisualStyleBackColor = true;
            this.btnCancelConverter.Click += new System.EventHandler(this.btnCancelConverter_Click);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 157);
            this.Controls.Add(this.btnCancelConverter);
            this.Controls.Add(this.lbConverted);
            this.Controls.Add(this.lbOriginal);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbCurr2);
            this.Controls.Add(this.cbCurr1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Name = "ConversionForm";
            this.Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)(this.errTxtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurr2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ComboBox cbCurr1;
        private System.Windows.Forms.ComboBox cbCurr2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ErrorProvider errTxtFrom;
        private System.Windows.Forms.Label lbConverted;
        private System.Windows.Forms.Label lbOriginal;
        private System.Windows.Forms.ErrorProvider errCurr1;
        private System.Windows.Forms.ErrorProvider errCurr2;
        private System.Windows.Forms.Button btnCancelConverter;
    }
}