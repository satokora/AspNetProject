using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees.Views
{
    public partial class ViewSingleItem : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["itemId"] != null)
            {
                ItemController itemCtrl = new ItemController();
                Item result = itemCtrl.getItemByID(Request.QueryString["itemId"]);
                ItemID.Text = result.CategoryID + result.ItemID;
                ItemName.Text = result.ItemName;
                lblCurrentPrice.Text = result.ItemValue.ToString();
                lblMinPrice.Text = result.MinBid.ToString();
                lblAngelPrice.Text = result.AngelPrice.ToString();
            }
        }
    }
}