using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AuchParser
{
    public partial class AuchParser : Form
    {
        Parser theParser = new Parser();
        public AuchParser()
        {
            InitializeComponent();
        }

        private void OpenFileBTN_Click(object sender, EventArgs e)
        {
            theParser.OpenFile();


            string tempString = "";
            foreach (string line in theParser.getLines())
            {
                tempString += (line + "\n");
            }
            TestTextBox.Text = tempString;
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            TestTextBox.Text = theParser.search(searchTXT.Text);
        }

        private void ShowAllBTN_Click(object sender, EventArgs e)
        {
            TestTextBox.Text = theParser.splitData();
        }

        private void ExcelBTN_Click(object sender, EventArgs e)
        {
            TestTextBox.Text = theParser.splitData();
            theParser.makeSpeadSheet();
        }
    }
}
