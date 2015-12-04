using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;
using System.Data;

namespace FestivalOfTrees.Views
{
    public partial class ItemSoldStatusView : System.Web.UI.UserControl
    {
        private ExportToCsvController exportCtrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            //BtnPrintSoldInvoices.Enabled = false;
            //ExportSoldBtn.Enabled = false;
            exportCtrl = new ExportToCsvController();

            if (SoldColumnList.Items.Count < 1)
            {
                ListItem defItem = new ListItem("&nbsp;");
                SoldColumnList.Items.Add(defItem);
                //ColumnList.Items[0].Enabled = false;
                foreach (TableCell col in SoldStatusGrid.HeaderRow.Cells)
                {
                    if (!col.Text.Contains("Print") && !col.Text.Equals("&nbsp;"))
                    {
                        if (!col.Text.Equals(""))
                        {
                            SoldColumnList.Items.Add(new ListItem(col.Text));
                        }

                    }
                }

                ListItem lastItem = new ListItem("&nbsp;");
                SoldColumnList.Items.Add(lastItem);

                defItem.Enabled = false;
                lastItem.Enabled = false;
            }

        }

        protected void SoldStatusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoldStatusGrid.DataBind();
        }
        protected void ItemSoldStatusGrid_CheckedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (GridViewRow row in SoldStatusGrid.Rows)
            {
                // Access the CheckBox
                CheckBox cb = (CheckBox)row.FindControl("CheckBox2");
                if (cb != null && cb.Checked)
                {
                    count++;
                }

            }

            if (count > 0)
            {
                BtnPrintSoldInvoices.Enabled = true;
                ExportSoldBtn.Enabled = true;
            }
            else
            {
                //BtnPrintSoldInvoices.Enabled = false;
                //ExportSoldBtn.Enabled = false;
            }
        }
        protected void ItemSoldStatusGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = SoldStatusGrid.SelectedRow;
            Response.Redirect("SingleView.aspx?itemId=" + row.Cells[2].Text.Substring(2));
        }

        protected void BtnPrintSoldInvoices_Click(object sender, EventArgs e)
        {
            PrintBidSheetController bspCtrl = new PrintBidSheetController();
            List<string> itemNumbersToPrint = new List<string>();
            string templatePath = Server.MapPath("~\\PDF\\BidSheet.pdf");
            string temporaryPath = Server.MapPath("~\\PDF\\temp.pdf");
            string savePath = Server.MapPath("~\\PDF\\Filled.pdf");
            foreach (GridViewRow row in SoldStatusGrid.Rows)
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
            bspCtrl.PrintSheets(itemNumbersToPrint, savePath, templatePath, temporaryPath);
            Response.Redirect("BidSheets.aspx");
        }

        protected void SelectSoldColBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedColumns = new List<string>();
            DataSet ds = new DataSet("ExportTables");
            DataTable dt = ds.Tables.Add("ItemList");
            int count = 0;
            foreach (ListItem i in SoldColumnList.Items)
            {

                if (i.Selected)
                {
                    count++;
                    selectedColumns.Add(i.Value);
                    dt.Columns.Add(i.Value, Type.GetType("System.String"));
                }
            }



            foreach (GridViewRow row in SoldStatusGrid.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("CheckBox3");
                if (cb != null && cb.Checked)
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < count; i++)
                    {


                        for (int j = 0; j < SoldStatusGrid.Columns.Count; j++)
                        {

                            if (SoldStatusGrid.Columns[j].HeaderText.Equals(selectedColumns[i]))
                            {
                                if (selectedColumns[i].Equals("Status"))
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