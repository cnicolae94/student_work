
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
            this.listView1 = new System.Windows.Forms.ListView();
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 288);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 435);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnNewT);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewT;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListView listView1;
    }
}

