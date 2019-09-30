using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace SelectConstraction {
    public partial class ReportForm : Form {
        public ReportForm() {
            InitializeComponent();
        }

        public DataGridView ReportTbl {
            get {
                return ReportTable;
            } 
            set {
                ReportTable.DataSource = value;
            }
        }

        private void ImportExcel_Click(object sender, EventArgs e) {
            string path = Directory.GetCurrentDirectory() + @"\" + "Report - " + DateTime.Now.ToString("yy.MM.dd HH.mm.ss") + ".xlsx";

            ExcelObj.Application excelObj = new ExcelObj.Application();
            ExcelObj.Workbook workbook = excelObj.Workbooks.Add();
            ExcelObj.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < ReportTable.ColumnCount + 1; i++) {
                worksheet.Rows[1].Columns[i] = ReportTable.Columns[i - 1].HeaderText;
            }

            for (int i = 2; i < ReportTable.RowCount + 2; i++) {
                for (int j = 1; j < ReportTable.ColumnCount + 1; j++) {
                    worksheet.Rows[i].Columns[j] = ReportTable.Rows[i - 2].Cells[j - 1].Value;
                }
            }

            excelObj.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelObj.Quit();
        }
    }
}
