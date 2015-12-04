
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Name"]!=null)
            {
                if (Session["Admin"].Equals("admin"))
                {
                    MenuMultiView.ActiveViewIndex = 0;
                }
                else
                {
                    MenuMultiView.ActiveViewIndex = 1;
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            
        }
    }
}