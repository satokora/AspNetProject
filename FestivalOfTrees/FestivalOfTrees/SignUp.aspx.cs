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
    public partial class SignUp1 : System.Web.UI.Page
    {

        private User toAdd;
        private SignUpController signUp;
        private UserCtrl userControl;
        private User u;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            signUp = new SignUpController();
            userControl = new UserCtrl();
            
            if (IsPostBack)
            {
                ResultLabel.Visible = true;
            }

            if (!IsPostBack)
            {
                EditProfileTitle.Visible = false;

                //if (Session["name"]!= null)
                if (Page.PreviousPage == null && Session["name"]!= null)
                {
                    //Manage title and button visibility for Edit Profile
                    EditProfileBtn.Visible = true;
                    SignUpBtn.Visible = false;
                    BackButton.Visible = true;
                    SignUpTitle.Visible = false;
                    EditProfileTitle.Visible = true;
                    ResultLabel.Visible = false;

                    email.ReadOnly = true;
                    confEmail.ReadOnly = true;
                    string emailString = Session["name"].ToString();

                    u = userControl.getProfileInfo(emailString);

                    email.Text = u.Email;
                    confEmail.Text = u.Email;
                    firstName.Text = u.FirstName;
                    lastName.Text = u.LastName;
                    address.Text = u.Address;
                    city.Text = u.City;
                    DropDownList1.SelectedValue = u.State;
                    zipCode.Text = u.Zip.ToString();
                    //Phone.Text = u.Phone;
                    MobilePhone.Text = u.Phone;
                    checkToText.Checked = u.Text;

                }
            }

            ServiceReference1.SUSMSClient isuService = new ServiceReference1.SUSMSClient();

            string[] carriers = isuService.getCarriers();

            if (carriers.Length > 0 && CarrierList.Items.Count <= 1)
            {
                foreach (string carrier in carriers)
                {
                    CarrierList.Items.Add(new ListItem(carrier, carrier));
                }
            }

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
            string ADDRESS = address.Text;
            string CITY = city.Text;
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

            string HPHONE = Phone.Text;
            string MPHONE = MobilePhone.Text;
            bool TEXT = checkToText.Checked;
            string CARRIER = CarrierList.SelectedValue;

            //ID is produced in database
            toAdd = new User(-1, EMAIL, FNAME, LNAME, ADDRESS, CITY, STATE, ZIP, ADMIN, COMMITTEE, DONOR, MPHONE, TEXT, CARRIER);
            if (signUp.addUser(toAdd))
            {
                signUp.addUserCredentials(email.Text, password1.Text);
                if (role.Equals("a"))
                {
                    Request r = new Request()
                    {
                        RequestEmail = EMAIL,
                        Admin = true,
                        Committee = false,
                        Donor = false
                    };
                    UserCtrl uCtrl = new UserCtrl();
                    uCtrl.createRequest(r);
                }
                //Do we wnat to add a message here letting user know request was submitted successfully?
                Response.Redirect("Default.aspx?signup=1");
            }
            else
            {
                //Is this the preferred action if a user is already signed up or sign up fails?
                Response.Redirect("Default.aspx");
            }

            //This adds usercredentials right away ... needs to be modified if there is an approval action
            signUp.addUserCredentials(email.Text, password1.Text);
        }

        protected void EditProfileBtn_Click(object sender, EventArgs e)
        {
            int rows = 0;
            UserDaoImpl dao = new UserDaoImpl();
            u = new User();
            u.Email = email.Text;
            u.Address = address.Text;
            u.City = city.Text;
            u.LastName = lastName.Text;
            u.Phone = MobilePhone.Text;
            u.FirstName = firstName.Text;
            u.State = DropDownList1.SelectedValue;
            u.Zip = Convert.ToInt32(zipCode.Text);
            u.Text = checkToText.Checked;
            u.Carrier = CarrierList.SelectedValue;

            //Verifies correct password was input to modify profile info
            if (userControl.authenticate(email.Text, password1.Text))
            {
                rows = dao.updateUser(u);
            }
            else
            {
                ResultLabel.Text = "Password was incorrect.  Please try again.";
                return;
            }
            //Upon successful update of profile user is redirected back to Auction.asp
            if (rows == 1)
                ResultLabel.Text = "Changes Successfully Saved!";
            else
            {
                ResultLabel.Text = "Unable to update your profile at this time.";
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx");
        }
    }

}