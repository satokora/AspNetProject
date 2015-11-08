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

        protected void Menu1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?menu=1"); // Go to Quick Status View
        }

        protected void Menu2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?menu=2"); // Go to Enter new item
        }

        protected void Menu3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?menu=3"); // Go to search
        }
    }

    
}