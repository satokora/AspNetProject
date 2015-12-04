using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;
using System.Data;
using OfficeOpenXml;

namespace FestivalOfTrees.Views
{
    public partial class ItemStatusView : System.Web.UI.UserControl
    {
        private ExportToCsvController exportCtrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            //BtnPrintPaidInvoices.Enabled = false;
            //LinkButton1.Enabled = false;
            exportCtrl = new ExportToCsvController();

            if(ColumnList.Items.Count < 1)
            {
                ListItem defItem = new ListItem("&nbsp;");
                ColumnList.Items.Add(defItem);
                //ColumnList.Items[0].Enabled = false;
                foreach (TableCell col in ItemStatusGrid.HeaderRow.Cells)
                {
                    if (!col.Text.Contains("Print") && !col.Text.Equals("&nbsp;"))
                    {
                        if (!col.Text.Equals(""))
                        {
                            ColumnList.Items.Add(new ListItem(col.Text));
                        }

                    }
                }

                ListItem lastItem = new ListItem("&nbsp;");
                ColumnList.Items.Add(lastItem);

                defItem.Enabled = false;
                lastItem.Enabled = false;
            }
            
        }

        protected void PaidStatusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemStatusGrid.DataBind();
        }
        protected void ItemPaidStatusGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = ItemStatusGrid.SelectedRow;
            Response.Redirect("SingleView.aspx?itemId=" + row.Cells[2].Text.Substring(2));
        }
        protected void ItemPaidStatusGrid_CheckedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (GridViewRow row in ItemStatusGrid.Rows)
            {
                // Access the CheckBox
                CheckBox cb = (CheckBox)row.FindControl("CheckBox2");
                if (cb != null && cb.Checked)
                {
                    count++;
                }
                
            }

            //if (count > 0)
            //{
            //    BtnPrintPaidInvoices.Enabled = true;
            //    LinkButton1.Enabled = true;
            //}
            //else
            //{
            //    BtnPrintPaidInvoices.Enabled = false;
            //    LinkButton1.Enabled = false;
            //}
        }

        protected void BtnPrintPaidInvoices_Click(object sender, EventArgs e)
        {
            PrintBidSheetController bspCtrl = new PrintBidSheetController();
            List<string> itemNumbersToPrint = new List<string>();
            string templatePath = Server.MapPath("~\\PDF\\BidSheet.pdf");
            string temporaryPath = Server.MapPath("~\\PDF\\temp.pdf");
            string savePath = Server.MapPath("~\\PDF\\Filled.pdf");
            foreach (GridViewRow row in ItemStatusGrid.Rows)
            {
                // Access the CheckBox
                CheckBox cb = (CheckBox)row.FindControl("CheckBox2");
                if (cb != null && cb.Checked)
                {
                    int firstDigit = row.Cells[2].Text.IndexOfAny("0123456789".ToCharArray());
                    string categoryID = row.Cells[2].Text.Substring(0, firstDigit);
                    string itemNumber = row.Cells[2].Text.Substring(firstDigit);
                    itemNumbersToPrint.Add(itemNumber);
                }
            }
            int i = bspCtrl.PrintSheets(itemNumbersToPrint, savePath, templatePath, temporaryPath);
            if(i>0)
            {
                Response.Redirect("BidSheets.aspx");
            }
            
        }


        protected void SelectColBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedColumns = new List<string>();
            DataSet ds = new DataSet("ExportTables");
            DataTable dt = ds.Tables.Add("ItemList");
            int count = 0;
            foreach(ListItem i in ColumnList.Items)
            {
                
                if(i.Selected)
                {
                    count++;
                    selectedColumns.Add(i.Value);
                    dt.Columns.Add(i.Value, Type.GetType("System.String"));
                }
            }

           

            foreach(GridViewRow row in ItemStatusGrid.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("CheckBox2");
                if (cb != null && cb.Checked)
                {
                    DataRow dr = dt.NewRow();
                    
                    for (int i=0;i< count;i++)
                    {
                        
                        for (int j=0;j< ItemStatusGrid.Columns.Count;j++)
                        {
                            if (ItemStatusGrid.Columns[j].HeaderText.Equals(selectedColumns[i]))
                            {
                                if(selectedColumns[i].Equals("Status"))
                                {
                                    Label lb = (Label)row.FindControl("Label1");
                                    dr[selectedColumns[i]] = lb.Text;
                                }
                                else
                                {
                                    
                                    dr[selectedColumns[i]] = row.Cells[j].Text;
                                    
                                }
                                
                            }
                        }
                    }

                    dt.Rows.Add(dr);
                }
            }

            exportCtrl.ExportDataSetToExcelWithPlus(ds);
            
        }
    }
}