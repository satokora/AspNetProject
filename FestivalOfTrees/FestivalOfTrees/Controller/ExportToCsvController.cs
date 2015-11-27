using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

/*
    For Use Case 9: Export selected information to Excel

*/
namespace FestivalOfTrees.Controller
{
    public class ExportToCsvController
    {
        public void ExportDataSetToExcel(DataSet ds)
        {
            //Creae an Excel application instance
           
            Excel.Application excelApp = new Excel.Application();

            //Create an Excel workbook instance and open it from the predefined location
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string pathDownload = Path.Combine(pathUser, "Downloads");
            string fullFileName = pathDownload + "\\ItemList.xlsx";
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();

            foreach (DataTable table in ds.Tables)
            {
                //Add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = table.TableName;

                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }
            }

            excelWorkBook.SaveAs(fullFileName);
            excelWorkBook.Close();
            excelApp.Quit();

        }
    }
}