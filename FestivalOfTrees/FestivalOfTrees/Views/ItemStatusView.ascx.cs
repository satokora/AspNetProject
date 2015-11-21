using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees.Views
{
    public partial class ItemStatusView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SoldStatusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoldStatusGrid.DataBind();
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
        protected void ItemSoldStatusGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = SoldStatusGrid.SelectedRow;
            Response.Redirect("SingleView.aspx?itemId=" + row.Cells[2].Text.Substring(2));
        }

        protected void BtnPrintSoldInvoices_Click(object sender, EventArgs e)
        {

        }

        protected void BtnPrintPaidInvoices_Click(object sender, EventArgs e)
        {

        }
    }
}