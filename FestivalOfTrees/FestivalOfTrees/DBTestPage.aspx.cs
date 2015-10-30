using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class DBTestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                UserDaoImpl dao = new UserDaoImpl();

                Credentials creds = dao.getCredentialsByEmail(TextBox1.Text.ToString());
                User user = dao.getUserByEmail(TextBox1.Text.ToString());

                Response.Write(creds.ToString());

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}