using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class TestHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
            Response.Write("User: </br>");
            Response.Write(((User)Session["user"]).ToString());
            //Response.Write("</br>Credentials: </br>");
            //Response.Write(UserController.Credentials.ToString())
            }
            ;
        }
    }
}