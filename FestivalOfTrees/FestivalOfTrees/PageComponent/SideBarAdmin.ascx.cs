using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees.PageComponent
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnViewItems_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=1");
        }

        protected void BtnEnterItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=5");
        }

        protected void BtnViewByCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=2");
        }

        protected void BtnEnterCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=6");
        }

        protected void BtnSearchItems_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=3");
        }

        protected void BtnSearchUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=4");
        }

        protected void BtnCloseAuction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=7");
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }

    
}