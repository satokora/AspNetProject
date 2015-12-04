using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

/*
    For Use Case 9: Export selected information to Excel

*/
namespace FestivalOfTrees.Controller
{
    public class ExportToCsvController
    {
       
        public void ExportDataSetToExcelWithPlus(DataSet ds)
        {
            using (ExcelPackage pck = new ExcelPackage())
            {
                HttpResponse Response = HttpContext.Current.Response;

                //Create the worksheet
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("ItemList");

                string[] cellNames = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                DataTable tbl = ds.Tables[0];

                int cellRange = tbl.Columns.Count;

                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ws.Cells["A1"].LoadFromDataTable(tbl, true);

                //Format the header for column 1-3
                using (ExcelRange rng = ws.Cells[cellNames[0] + "1:" + cellNames[cellRange - 1] + "1"])
                {
                    rng.Style.Font.Bold = true;
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                    rng.Style.Font.Color.SetColor(Color.White);
                }

                ////Example how to Format Column 1 as numeric 
                //using (ExcelRange col = ws.Cells[2, 1, 2 + tbl.Rows.Count, 1])
                //{
                //    col.Style.Numberformat.Format = "#,##0.00";
                //    col.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                //}

                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment;  filename=ItemDataList.xlsx");
                Response.BinaryWrite(pck.GetAsByteArray());
                try { 
                Response.End();
                 }catch (Exception ex)
                {
                    if (!(ex is System.Threading.ThreadAbortException))
                    {
                        //Log other errors here
                    }
                }

            }
        }
    }
}