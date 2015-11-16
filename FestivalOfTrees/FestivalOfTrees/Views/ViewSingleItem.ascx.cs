using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees.Views
{
    public partial class ViewSingleItem : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["itemId"] != null)
            {
                string selectedItemId = Request.QueryString["itemId"];
                ItemController itemCtrl = new ItemController();
                UserCtrl userCtrl = new UserCtrl();

                Item result = itemCtrl.getItemByID(selectedItemId);
                ItemID.Text = result.CategoryID + result.ItemID;
                ItemName.Text = result.ItemName;
                lblCurrentPrice.Text = result.ItemValue.ToString();
                lblMinPrice.Text = result.MinBid.ToString();
                lblAngelPrice.Text = result.AngelPrice.ToString();
                ItemDesc.Text = result.Description.ToString();

                if (result.Paid)
                {
                    LblItemStatus.Text = "Paid";
                }
                else
                {
                    LblItemStatus.Text = "Unpaid";
                }

                User buyer = userCtrl.getBuyerInfo(result.UserID.ToString());

                if (buyer !=null)
                {
                    BuyerName.Text = buyer.FirstName + " " + buyer.LastName;
                    BuyerEmail.Text = buyer.Email;
                    BuyerPhone.Text = "(" + buyer.Phone.Substring(0, 3) + ")" + buyer.Phone.Substring(3, 3) + "-" + buyer.Phone.Substring(6);
                }

                List<User> designers = itemCtrl.getDesigners(selectedItemId);

                if (designers != null)
                {
                    foreach (User d in designers)
                    {
                        DesignerName.Text += d.FirstName + " " + d.LastName + " ";
                    }
                }
                

                SponsorName.Text = itemCtrl.getSponsorName(result.CategoryID);

            }
        }
    }
}