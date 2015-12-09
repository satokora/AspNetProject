using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;
using System.Data;

namespace FestivalOfTrees.Views
{
    public partial class ViewSingleUser : System.Web.UI.UserControl
    {
        private SearchUserController userController;
        private ItemController itemCtrl;
        private User singleUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            userController = new SearchUserController();
            itemCtrl = new ItemController();

            if (Request.QueryString["userId"] != null)
            {
                singleUser = userController.getSingleUser(Request.QueryString["userId"]);

                if (singleUser != null)
                {
                    LblUserName.Text = singleUser.FirstName + " " + singleUser.LastName;
                    LblAddress.Text = singleUser.Address;
                    LblCity.Text = singleUser.City;
                    LblState.Text = singleUser.State;
                    LblHomePhone.Text = singleUser.Phone;
                    LblMobilePhone.Text = formatPhoneNum(singleUser.Phone);
                    lblZip.Text = singleUser.Zip.ToString();
                    LblEmail.Text = singleUser.Email;

                    if (!singleUser.Text)
                    {
                        BtnText.Visible = false;
                        SMSMessage.Visible = false;
                    }
                }
                
            }

            if (!Page.IsPostBack)
            {
                MessageSent.Visible = false;
                EmailSentMsg.Visible = false;
                
            }

            InvoiceView.DataBind();
            InvoiceView.Rows[InvoiceView.Rows.Count-1].Cells[6].Controls[0].Visible = false;
            InvoiceView.Rows[InvoiceView.Rows.Count-2].Cells[6].Controls[0].Visible = false;
            InvoiceView.Rows[InvoiceView.Rows.Count-3].Cells[6].Controls[0].Visible = false;
        }
        private string formatPhoneNum(string phoneNum)
        {
            return "(" + phoneNum.Substring(0, 3) + ")" + phoneNum.Substring(3, 3) + "-" + phoneNum.Substring(6);
        }

        protected void InvoiceView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = InvoiceView.SelectedRow;
            //Button selectedbtn = (Button)row.FindControl("Button1");
            int status = 0;
            if (row.Cells[5].Text.Equals("NO"))
            {
                status = 1;
            }
            else
            {
                status = 0;
            }

            int firstDigit = row.Cells[0].Text.IndexOfAny("0123456789".ToCharArray());
            string categoryID = row.Cells[0].Text.Substring(0, firstDigit);
            string itemNumber = row.Cells[0].Text.Substring(firstDigit);

            itemCtrl.updateToPaid(itemNumber, status);
            InvoiceView.DataBind();
        }

        protected void BtnText_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(SMSMessage.Text))
            {
                TextCallController txtCtrl = new TextCallController();

                txtCtrl.sendText(singleUser.Phone,SMSMessage.Text);
                MessageSent.Visible = true;
            }
        }

        protected void BtnEmail_Click(object sender, EventArgs e)
        {
            EmailToBidderController emailCtrl = new EmailToBidderController();

            DataView view = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

            DataTable table = view.ToTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(table);

            emailCtrl.sendInvoiceEmail(singleUser.Email, ds);
            EmailSentMsg.Visible = true;
        }
    }
}