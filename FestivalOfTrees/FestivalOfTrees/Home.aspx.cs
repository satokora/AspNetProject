using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
            }
            
        }

        protected void Menu1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Menu2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Menu3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }
    }
}