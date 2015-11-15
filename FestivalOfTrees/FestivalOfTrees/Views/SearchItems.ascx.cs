using FestivalOfTrees.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees.Views
{
    public class NewgvColumnField : DataControlField
    {

        protected override System.Web.UI.WebControls.DataControlField CreateField()
        {
            return new NewgvColumnField();

        }

        public DataControlField InsertNewColumn()
        {
            return CreateField();

        }
    }
    public partial class SearchItems : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnGetItemsByItemId_Click(object sender, EventArgs e)
        {
            
        }

        protected void GridViewItemsByItemId_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow row = GridViewItemsByItemId.SelectedRow;
            Response.Redirect("SingleView.aspx?itemId=" + row.Cells[3].Text);
        }

        protected void BtnPrintInvoices_Click(object sender, EventArgs e)
        {
            PrintBidSheetController bspCtrl = new PrintBidSheetController();
            List<string> itemNumbersToPrint = new List<string>();
            string templatePath = Server.MapPath("~\\PDF\\BidSheet.pdf");
            string temporaryPath = Server.MapPath("~\\PDF\\temp.pdf");
            string savePath = Server.MapPath("~\\PDF\\Filled.pdf");
            foreach (GridViewRow row in GridViewItemsByItemId.Rows)
            {
                // Access the CheckBox
                CheckBox cb = (CheckBox)row.FindControl("CheckBox2");
                if (cb != null && cb.Checked)
                {
                    itemNumbersToPrint.Add(row.Cells[3].Text);
                }
            }
            bspCtrl.PrintSheets(itemNumbersToPrint, savePath, templatePath, temporaryPath);
            Response.Redirect("BidSheets.aspx");
        }
        protected void ChkbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool chkFlag = false;
            if (((CheckBox)GridViewItemsByItemId.FindControl("ChkbSelectAll")).Checked) chkFlag = true;
            foreach (GridViewRow dr in GridViewItemsByItemId.Rows)
            {
                CheckBox chk = (CheckBox)dr.Cells[1].FindControl("Select");
                chk.Checked = chkFlag;
            }
        }
    }
}