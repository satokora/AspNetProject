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
                if (Request.QueryString["menu"] != null)
                {
                    if (Request.QueryString["menu"].Equals("1"))
                    {
                        MultiView1.ActiveViewIndex = 0;
                    }
                    else if (Request.QueryString["menu"].Equals("2"))
                    {
                        MultiView1.ActiveViewIndex = 1;
                    }
                    else if (Request.QueryString["menu"].Equals("3"))
                    {
                        MultiView1.ActiveViewIndex = 2;
                    }
                }
                else
                {
                    MultiView1.ActiveViewIndex = 0;
                }
                    
            }
            
        }

        
    }
}