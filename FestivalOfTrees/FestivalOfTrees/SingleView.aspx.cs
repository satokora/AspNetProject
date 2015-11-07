using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class SingleView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["item"] != null)
            {
                MultiView1.ActiveViewIndex = 0;
            }
            else if (Request.QueryString["user"] != null)
            {
                MultiView1.ActiveViewIndex = 1;
            }
        }

        protected void Menu1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?menu=1");
        }

        protected void Menu2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?menu=2");
        }

        protected void Menu3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?menu=3");
        }
    }
}