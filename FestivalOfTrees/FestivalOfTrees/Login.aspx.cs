using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;
using FestivalOfTrees.Dao;

namespace FestivalOfTrees
{
    public partial class Login : System.Web.UI.Page
    {
        private UserCtrl loginCtrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            loginCtrl = new UserCtrl();
            if (Request.QueryString["signup"] != null)
            {
                MessagePanel.Visible = true;
            }
            else
            {
                MessagePanel.Visible = false;
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (loginCtrl.authenticate(userEmailTxt.Text, password.Text))
            {
                Response.Redirect("Profile.aspx");
            }
        }

        public bool signUp(User u, Credentials c)
        {
            bool valid = false;
            UserDaoImpl userDao = new UserDaoImpl();
            userDao.createUser(u);

            if (true)
            {
                userDao.createCredentials(c);
                if (true)
                {
                    Credentials creds = c;
                    valid = true;
                }
            }
            return valid;
        }

        public bool authenticate(string userEmail, string pass)
        {
            UserDaoImpl userDao = new UserDaoImpl();
            Credentials creds = userDao.getCredentialsByEmail(userEmail);
            if (creds.Password.Equals(pass))
            {
                return true;
            }
            else
                return false;
        }
    }
}
