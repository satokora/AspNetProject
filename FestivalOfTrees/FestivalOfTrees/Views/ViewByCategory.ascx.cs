using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;

namespace FestivalOfTrees.Views
{
    public partial class ViewByCategory : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //searchCatItem = new SearchItemController();

            //if (CatList.Items.Count <= 1)
            //{
            //    List<ListItem> listCatItems = searchCatItem.allItemCategories();
            //    int index = 1;
            //    foreach (ListItem result in listCatItems)
            //    {

            //        CatList.Items.Insert(index, result);
            //        index++;
            //    }
            //}
        }

        protected void GridViewItemsByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewItemsByCategory.Rows[GridViewItemsByCategory.SelectedIndex];
            Session["Category"] = row.Cells[1].Text;
            Response.Redirect("Auction.aspx?menu=9");
        }
    }
}