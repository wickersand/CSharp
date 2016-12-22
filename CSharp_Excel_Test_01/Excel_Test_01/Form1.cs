using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excel_Test_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application(); // Verifica se o Excel está instalado.

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not Properly Installed!!!");
                return;
            }

            Excel.Workbook xlWorkbook;
            Excel.Worksheet xlWorksheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkbook = xlApp.Workbooks.Add(misValue);
            xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            xlWorksheet.Cells[1, 1] = "Sheet 1 content";

            xlWorkbook.SaveAs("D:\\ExcelCSharpText.xlsx", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorksheet);
            releaseObject(xlWorkbook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created, you can find the file D:\\");

        }

        private void releaseObject(object obj)
        {

            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {

                obj = null;
                MessageBox.Show("Exception Occured while releasing Object" + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
