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
    public partial class SignUp : System.Web.UI.Page
    {
        private User toAdd;
        private SignUpController signUp; 
        protected void Page_Load(object sender, EventArgs e)
        {
            signUp = new SignUpController();
        }

        protected void SignUpBtn_Click(object sender, EventArgs e)
        {
            
            string role = Request.QueryString["role"];

            bool ADMIN = false;
            bool COMMITTEE = false;
            bool DONOR = false;

            string EMAIL = email.Text;
            string FNAME = firstName.Text;
            string LNAME = lastName.Text;
            string ADDRESS = address1.Text;
            string CITY = address2.Text;
            string STATE = DropDownList1.SelectedValue;
            int ZIP = Convert.ToInt32(zipCode.Text);

            if (role.Equals("a"))
            {
                ADMIN = true;
                COMMITTEE = false;
            }
            if (role.Equals("s"))
            {
                ADMIN = false;
                COMMITTEE = true;
            }
            if (role.Equals("d"))
            {
                DONOR = true;
            }

            string HPHONE = phone.Text;
            string MPHONE = TextBox1.Text;
            bool TEXT = checkToText.Checked;

            toAdd = new User()
            {
                Email = EMAIL,
                FirstName = FNAME,
                LastName = LNAME,
                Address = ADDRESS,
                City = CITY,
                State = STATE,
                Zip = ZIP,
                Admin = ADMIN,
                Committee = COMMITTEE,
                Donor = DONOR,
                Phone = MPHONE,
                Text = TEXT
            };

            if (signUp.addUser(toAdd))
            {
                //Do we wnat to add a message here letting user know request was submitted successfully?
            }
            else
            {
                //Is this the preferred action if a user is already signed up or sign up fails?
                Response.Redirect("Login.aspx");
            }

            //This adds usercredentials right away ... needs to be modified if there is an approval action
            Credentials creds = new Credentials()
            {
                Email = EMAIL,
                Password = password1.Text.ToString()
            };
            signUp.addUserCredentials(creds);
        }
    }
}