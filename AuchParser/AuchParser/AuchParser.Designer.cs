namespace AuchParser
{
    partial class AuchParser
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
            this.OpenFileBTN = new System.Windows.Forms.Button();
            this.TestTextBox = new System.Windows.Forms.RichTextBox();
            this.searchTXT = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.showAllBTN = new System.Windows.Forms.Button();
            this.excelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileBTN
            // 
            this.OpenFileBTN.Location = new System.Drawing.Point(253, 355);
            this.OpenFileBTN.Name = "OpenFileBTN";
            this.OpenFileBTN.Size = new System.Drawing.Size(75, 23);
            this.OpenFileBTN.TabIndex = 0;
            this.OpenFileBTN.Text = "Open";
            this.OpenFileBTN.UseVisualStyleBackColor = true;
            this.OpenFileBTN.Click += new System.EventHandler(this.OpenFileBTN_Click);
            // 
            // TestTextBox
            // 
            this.TestTextBox.Location = new System.Drawing.Point(12, 26);
            this.TestTextBox.Name = "TestTextBox";
            this.TestTextBox.Size = new System.Drawing.Size(620, 280);
            this.TestTextBox.TabIndex = 1;
            this.TestTextBox.Text = "";
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(655, 26);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(100, 20);
            this.searchTXT.TabIndex = 2;
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(655, 52);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 23);
            this.searchBTN.TabIndex = 3;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // showAllBTN
            // 
            this.showAllBTN.Location = new System.Drawing.Point(655, 81);
            this.showAllBTN.Name = "showAllBTN";
            this.showAllBTN.Size = new System.Drawing.Size(75, 23);
            this.showAllBTN.TabIndex = 4;
            this.showAllBTN.Text = "Showall";
            this.showAllBTN.UseVisualStyleBackColor = true;
            this.showAllBTN.Click += new System.EventHandler(this.ShowAllBTN_Click);
            // 
            // excelBTN
            // 
            this.excelBTN.Location = new System.Drawing.Point(655, 110);
            this.excelBTN.Name = "excelBTN";
            this.excelBTN.Size = new System.Drawing.Size(75, 23);
            this.excelBTN.TabIndex = 5;
            this.excelBTN.Text = "Excel";
            this.excelBTN.UseVisualStyleBackColor = true;
            this.excelBTN.Click += new System.EventHandler(this.ExcelBTN_Click);
            // 
            // AuchParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excelBTN);
            this.Controls.Add(this.showAllBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTXT);
            this.Controls.Add(this.TestTextBox);
            this.Controls.Add(this.OpenFileBTN);
            this.Name = "AuchParser";
            this.Text = "DJ  Rocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileBTN;
        private System.Windows.Forms.RichTextBox TestTextBox;
        private System.Windows.Forms.TextBox searchTXT;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Button showAllBTN;
        private System.Windows.Forms.Button excelBTN;
    }
}

