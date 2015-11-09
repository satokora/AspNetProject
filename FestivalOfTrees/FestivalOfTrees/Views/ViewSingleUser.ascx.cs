using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;

namespace FestivalOfTrees.Views
{
    public partial class ViewSingleUser : System.Web.UI.UserControl
    {
        private SearchUserController userController;
        protected void Page_Load(object sender, EventArgs e)
        {
            userController = new SearchUserController();

            if (Request.QueryString["userId"] != null)
            {
                User singleUser = userController.getSingleUser(Request.QueryString["userId"]);

                if (singleUser != null)
                {
                    LblUserName.Text = singleUser.FirstName + " " + singleUser.LastName;
                    LblAddress.Text = singleUser.Address;
                    LblCity.Text =  singleUser.City;
                    LblState.Text = singleUser.State;
                    LblHomePhone.Text = singleUser.Phone;
                    LblMobilePhone.Text = singleUser.Phone;
                    lblZip.Text = singleUser.Zip.ToString();
                    LblEmail.Text = singleUser.Email;
                }
                
            }
        }
    }
}