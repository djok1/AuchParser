using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace AuchParser
{
    class Parser
    {
        private StreamReader input;
        private List<string> Lines = new List<string>();
        private string Data = "";
        private List<string> Auctions = new List<string>();
        private List<string> searchData = new List<string>();
        private List<Listing> listings = new List<Listing>();

        
        public void OpenFile()
        {
            DialogResult result;
            string fileName;
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        input = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
                        AddLines();
                        Data = combineLines();
                        findAuctions();

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void AddLines()
        {
            try
            {
                while (!input.EndOfStream)
                {
                    Lines.Add(input.ReadLine());
                }
                input.Close();
            }
            catch
            {
                MessageBox.Show("Please selecet a file");
            }

        }
        public List<string> getLines()
        {
            return Lines;
        }

        private string combineLines()
        {
            string tempString = "";
            foreach(string line in Lines)
            {
                tempString += line;
            }
            return tempString;
        }

        private void findAuctions()
        {
            string[] tempStrings = Data.Split('{');
            Auctions = new List<string>();
            foreach (string auction in tempStrings)
            {
                if (auction.Contains("Hitem"))
                {
                    Auctions.Add(auction);
                }

            }
        }
        public string search(string searchTXT)
        {
            string tempString = "";
            searchData = new List<string>();
            foreach(string auction in Auctions)
            {
                if (auction.Contains(searchTXT))
                {
                    searchData.Add(auction);
                }
            }
            parseSearch();
            foreach(Listing listItem in listings)
            {

                tempString += listItem.listView() + "\n";
            }
            return tempString;
        }

        private void parseSearch()
        {
            string[] tempStrings;
            foreach(string auction in searchData)
            {
                tempStrings = auction.Split(',');
                listings.Add(new Listing(int.Parse(tempStrings[16]), int.Parse(tempStrings[10]), tempStrings[8]/*.Remove('/')*/, int.Parse(tempStrings[22])));
            }

        }
        public string splitData()
        {
            string tempString = "";
            searchData = new List<string>();
            foreach (string auction in Auctions)
            {
                searchData.Add(auction);
            }
            parseSearch();
            return tempString;
        }

        public void makeSpeadSheet()
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;

            try
            {
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                oSheet.Cells[1, 1] = "Name";
                oSheet.Cells[1, 2] = "ID";
                oSheet.Cells[1, 3] = "Price";
                oSheet.Cells[1, 4] = "Price Per Item";

                int index = 2;
                foreach (Listing listItem in listings)
                {
                    oSheet.Cells[index, 1] = listItem.getName();
                    oSheet.Cells[index, 2] = listItem.getID();
                    oSheet.Cells[index, 3] = listItem.getPrice();
                    oSheet.Cells[index, 4] = listItem.pricePer();
                    index++;
                }
                oXL.Visible = true;
                oXL.UserControl = true;
            }
            catch
            {

            }
        }
    }
}
