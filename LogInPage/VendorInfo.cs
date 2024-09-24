using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;

namespace LogInPage
{
    public partial class VendorInfo : Form
    {

        private Excel.Application xlApp;
        private string dbPath = @"C:\MiscMIS\Book1.xlsx";
        public VendorInfo()
        {
            InitializeComponent();

            xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xlWorkBook = xlApp.Workbooks.Open(dbPath);
            var xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];

            try
            {
                int iRow = 2;

                while (xlWorkSheet.Cells[iRow, 1].Value != null)
                {
                    iRow++;
                }

                xlWorkSheet.Cells[iRow, 1].Value = txtName.Text;
                xlWorkSheet.Cells[iRow, 2].Value = txtCompany.Text;
                xlWorkSheet.Cells[iRow, 3].Value = txtCell.Text;
                xlWorkSheet.Cells[iRow, 4].Value = txtCity.GetItemText(txtCity.SelectedItem);

                string product = rdCoffee.Checked ? "Coffee" :
                                 rdTea.Checked ? "Tea" :
                                 rdHerbs.Checked ? "Herbs" : "";
                xlWorkSheet.Cells[iRow, 5].Value = product;

                string dairyproduct = rdMilk.Checked ? "Milk" :
                                      rdCream.Checked ? "Cream" : "";
                xlWorkSheet.Cells[iRow, 6].Value = dairyproduct;

                string deliveryStatus = ckDelay.Checked ? "Delayed" :
                                        ckTime.Checked ? "On Time" : "";
                xlWorkSheet.Cells[iRow, 7].Value = deliveryStatus;

                string paymentStatus = ckPaid.Checked ? "Paid" :
                                       ckUnpaid.Checked ? "Unpaid" : "";
                xlWorkSheet.Cells[iRow, 8].Value = paymentStatus;

                MessageBox.Show("Vendor information saved successfully!");

                xlWorkBook.Save();
                xlWorkBook.Close(true);
                xlApp.Quit();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to write to Excel: " + ex.Message);
            }

            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
