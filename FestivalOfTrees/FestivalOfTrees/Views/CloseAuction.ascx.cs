using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;
using FestivalOfTrees.PageComponent;

namespace FestivalOfTrees.Views
{
    public partial class CloseAuction : System.Web.UI.UserControl
    {
        private ItemController itemCtrl;
        private UserCtrl userCtrl;
        private TextCallController smsCtrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            itemCtrl = new ItemController();
            userCtrl = new UserCtrl();
            smsCtrl = new TextCallController();
            MsgPanel.Visible = false;
            if(Request.QueryString["success"] != null)
            {
                SuccessPanel.Visible = true;
            }
            else
            {
                SuccessPanel.Visible = false;
            }
            
        }

        

        protected void CloseItemView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = CloseItemView.SelectedRow;

            Label lb = (Label)row.FindControl("Label1");
            TextBox bidTxt = (TextBox)row.FindControl("BidTextBox");
            TextBox winText = (TextBox)row.FindControl("WinValTextBox");

            Item closeItem = itemCtrl.getItemByID(row.Cells[0].Text);
            User winUser = userCtrl.getBuyerInfo(bidTxt.Text);

            if(closeItem != null && winUser !=null)
            {
                int i = itemCtrl.updateBidItem(closeItem, winUser, winText.Text);
                if (i <= 0)
                {
                    ErrorNumsLbl.Text = closeItem.CategoryID + closeItem.ItemID;
                }

                if (winUser.Text)
                {
                    string msg = "Hello, we're BabyFold's Festival of Trees. We're pleased to let you know that you won the item: " + closeItem.ItemName + " with $" + winText.Text + "!";
                    smsCtrl.sendText(winUser.Phone, msg);
                }
            }

            CloseItemView.DataBind();     

        }
    }
}