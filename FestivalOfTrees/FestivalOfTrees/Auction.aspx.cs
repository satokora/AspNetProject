using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class Auction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if(Session["Name"] != null)
                {
                    
                
                    if (Request.QueryString["menu"] != null)
                    {
                        if (Request.QueryString["menu"].Equals("1"))
                        {
                            MainContentMultiView.ActiveViewIndex = 0;
                        }
                        else if (Request.QueryString["menu"].Equals("2"))
                        {
                            MainContentMultiView.ActiveViewIndex = 1;
                        }
                        else if (Request.QueryString["menu"].Equals("3"))
                        {
                            MainContentMultiView.ActiveViewIndex = 2;
                        }
                        else if (Request.QueryString["menu"].Equals("4"))
                        {
                            MainContentMultiView.ActiveViewIndex = 3;
                        }
                        else if (Request.QueryString["menu"].Equals("5"))
                        {
                            MainContentMultiView.ActiveViewIndex = 4;
                        }
                        else if (Request.QueryString["menu"].Equals("6"))
                        {
                            MainContentMultiView.ActiveViewIndex = 5;
                        }
                        else if (Request.QueryString["menu"].Equals("7"))
                        {
                            MainContentMultiView.ActiveViewIndex = 6;
                        }
                        else if (Request.QueryString["menu"].Equals("8"))
                        {
                            MainContentMultiView.ActiveViewIndex = 7;
                        }
                        else if (Request.QueryString["menu"].Equals("9"))
                        {
                            MainContentMultiView.ActiveViewIndex = 8;
                        }
                    }
                    else
                    {
                        if (Session["Admin"].Equals("admin"))
                        {
                            MainContentMultiView.ActiveViewIndex = 0;
                        }
                        else
                        {
                            MainContentMultiView.ActiveViewIndex = 1;
                        }
                    
                    }

                }
                else
                {
                    Response.Redirect("Default.aspx");
                }

            }
        }
    }
}