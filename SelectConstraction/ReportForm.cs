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
//using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Diagnostics;
using ClosedXML.Excel;
//using ExcelObj = Microsoft.Office.Interop.Excel;

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

        Microsoft.Office.Interop.Excel.Application excel;
        Microsoft.Office.Interop.Excel.Workbook excelworkBook;
        Microsoft.Office.Interop.Excel.Worksheet excelSheet;
        Microsoft.Office.Interop.Excel.Range excelCellrange;
        string path;
        private void ImportExcel_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            path = folderBrowserDialog1.SelectedPath + @"\" + "Report - " + DateTime.Now.ToString("yy.MM.dd HH.mm.ss") + ".xlsx";
             
            DataTable dt = new DataTable();
            dt = ReportTable.DataSource as DataTable;
            var workbook = new XLWorkbook();
            var worksheet1 = workbook.AddWorksheet(dt, "Лист 1");
            worksheet1.Columns().AdjustToContents(); //ширина столбца по содержимому
            workbook.SaveAs(path);
            /*using (FileStream stream = new FileStream(path, FileMode.Create)) {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Default)) {
                    for (int i = 0; i < ReportTbl.ColumnCount; i++) {
                        if (i != ReportTbl.ColumnCount - 1) {
                            writer.Write(ReportTbl.Columns[i].HeaderText.ToString() + ";");
                        } else {
                            writer.Write(ReportTbl.Columns[i].HeaderText.ToString());
                        }
                    }
                    writer.WriteLine();
                    for (int i = 0; i < ReportTbl.RowCount; i++) {
                        for (int j = 0; j < ReportTbl.ColumnCount; j++) {
                            if (j != ReportTbl.ColumnCount - 1) {
                                writer.Write(ReportTbl.Rows[i].Cells[j].Value.ToString() + ";");
                            } else {
                                writer.Write(ReportTbl.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }*/
            /*path = Directory.GetCurrentDirectory() + @"\" + "Report - " + DateTime.Now.ToString("yy.MM.dd HH.mm.ss") + ".xlsx";
            
            excel = new Microsoft.Office.Interop.Excel.Application();
            // for making Excel visible  
            excel.Visible = false;
            excel.DisplayAlerts = false;
            // Creation a new Workbook  
            excelworkBook = excel.Workbooks.Add(Type.Missing);
            // Workk sheet  
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            for (int i = 1; i < ReportTable.ColumnCount + 1; i++) {
                excelSheet.Rows[1].Columns[i] = ReportTable.Columns[i - 1].HeaderText;
            }

            for (int i = 2; i < ReportTable.RowCount + 2; i++) {
                for (int j = 1; j < ReportTable.ColumnCount + 1; j++) {
                    excelSheet.Rows[i].Columns[j] = ReportTable.Rows[i - 2].Cells[j - 1].Value;
                }
            }

            // now we resize the columns  
            excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[ReportTable.Rows.Count + 1, ReportTable.Columns.Count]];
            excelCellrange.EntireColumn.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;

            excel.AlertBeforeOverwriting = false;
            excelworkBook.SaveAs(path);
            excel.Quit();*/
        }
    }
}
