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
        protected void Page_Load(object sender, EventArgs e)
        {
            itemCtrl = new ItemController();
            userCtrl = new UserCtrl();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string errorNumbers = "";

            errorNumbers += updateBidItems(EnterBid1);
            errorNumbers += updateBidItems(EnterBid2);
            errorNumbers += updateBidItems(EnterBid3);
            errorNumbers += updateBidItems(EnterBid4);
            errorNumbers += updateBidItems(EnterBid5);

            if (!errorNumbers.Equals(""))
            {
                ErrorNumsLbl.Text = errorNumbers;
                MsgPanel.Visible = true;
            }
            else
            {
                
                Response.Redirect("Auction.aspx?menu=8&success=1");
               
            }


        }
        private string updateBidItems(EnterBid updateItemPnl)
        {
            string errorNum = "";

            if (updateItemPnl.ItemNumberTxt.Length > 0 && updateItemPnl.BidNoTxt.Length>0)
            {
                Item closeItem = itemCtrl.getItemByID(updateItemPnl.ItemNumberTxt);
                User bidUser = userCtrl.getBuyerInfo(updateItemPnl.BidNoTxt);


                if (closeItem != null && bidUser != null)
                {
                    int i = itemCtrl.updateBidItem(closeItem, bidUser, updateItemPnl.WinPrice);
                    if (i <= 0)
                    {
                        errorNum = " " + updateItemPnl.CloseItem.CategoryID + updateItemPnl.CloseItem.ItemID;
                    }
                }
            }
            

            return errorNum;
        }
    }
}