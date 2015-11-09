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
    public partial class TestSignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserController ctrl = new UserController();
            Credentials creds = new Credentials()
            {
                Email = TextBox1.Text.ToString(),
                Password = TextBox2.Text.ToString()
            };

            if (ctrl.signIn(creds))
            {
                Response.Redirect("TestHome.aspx");
            }
            else
            {
                Label3.Text = "Failed";
            }


        }
    }
}