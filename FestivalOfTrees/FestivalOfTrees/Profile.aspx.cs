using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGoAuction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx");
            // Implement logic to select an auction and retrieve corresponding dataset
        }
    }
}