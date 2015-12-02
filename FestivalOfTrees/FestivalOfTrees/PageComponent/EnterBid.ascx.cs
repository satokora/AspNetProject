using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;

namespace FestivalOfTrees.PageComponent
{
    public partial class EnterBid : System.Web.UI.UserControl
    {
        private ItemController itemCtrl;
        private UserCtrl userCtrl;
        private Item closeItem;
        private User bidUser;
        private string winPrice;
        private string itemNumberTxt;
        private string bidNoTxt;

        public Item CloseItem
        {
            get
            {
                return closeItem;
            }

            set
            {
                closeItem = value;
            }
        }

        public User BidUser
        {
            get
            {
                return bidUser;
            }

            set
            {
                bidUser = value;
            }
        }

        public string ItemNumberTxt
        {
            get
            {
                return CloseItemNoTxt.Text;
            }

            set
            {
                CloseItemNoTxt.Text = value;
            }
        }

        public string BidNoTxt
        {
            get
            {
                return BidNumTxt.Text;
            }

            set
            {
                BidNumTxt.Text = value;
            }
        }

        public string WinPrice
        {
            get
            {
                return WinPriceTxt.Text;
            }

            set
            {
                WinPriceTxt.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            itemCtrl = new ItemController();
            userCtrl = new UserCtrl();
        }

        protected void CloseItemNoTxt_TextChanged(object sender, EventArgs e)
        {     
            CloseItem= itemCtrl.getItemByID(CloseItemNoTxt.Text);
            if (CloseItem != null)
            {
                LblItemNo.Text = CloseItem.CategoryID + CloseItem.ItemID + " "
                + CloseItem.ItemName;
                ItemNoPnl.Visible = true;
            }
            
        }

        protected void BidNumTxt_TextChanged(object sender, EventArgs e)
        {
            BidUser = userCtrl.getBuyerInfo(BidNumTxt.Text);

            if (BidUser != null)
            {
                LblBidNo.Text = BidUser.LastName + ", " + BidUser.FirstName;
                BidNoPnl.Visible = true;
            }
        }

        protected void WinPriceTxt_TextChanged(object sender, EventArgs e)
        {
            WinPrice = WinPriceTxt.Text;
        }
    }
}