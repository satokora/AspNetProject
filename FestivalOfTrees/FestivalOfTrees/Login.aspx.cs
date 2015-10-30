using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;

namespace FestivalOfTrees
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginController loginCtrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            loginCtrl = new LoginController();
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            // delete the following line if you are done with implementing authentication logic here

            if (loginCtrl.authenticate(userEmailTxt.Text, password.Text))
            {
                Response.Redirect("Home.aspx");
            }

        }
    }
}