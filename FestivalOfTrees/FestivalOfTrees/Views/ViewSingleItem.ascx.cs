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
                lblCurrentPrice.Text = String.Format("{0:0.##}", result.ItemValue); 
                lblMinPrice.Text = String.Format("{0:0.##}", result.MinBid); 
                lblAngelPrice.Text = String.Format("{0:0.##}", result.AngelPrice);
                ItemDesc.Text = result.Description.ToString();

                if (String.IsNullOrEmpty(result.UserID.ToString()))
                {
                    LblItemStatus.Text = "UnSold";
                    LblItemStatus.CssClass = "ui grey ribbon big label";
                }
                else
                {
                    if (result.Paid)
                    {
                        LblItemStatus.Text = "Paid";
                        LblItemStatus.CssClass = "ui green ribbon big label";
                    }
                    else
                    {
                        LblItemStatus.Text = "Sold";
                        LblItemStatus.CssClass = "ui red ribbon big label";
                    }
                }
                

                User buyer = userCtrl.getBuyerInfo(result.UserID.ToString());

                if (buyer !=null)
                {
                    BuyerName.Text = buyer.FirstName + " " + buyer.LastName;
                    BuyerEmail.Text = buyer.Email;
                    BuyerPhone.Text = "(" + buyer.Phone.Substring(0, 3) + ")" + buyer.Phone.Substring(3, 3) + "-" + buyer.Phone.Substring(6);
                }
                else
                {

                        LblItemStatus.Text = "UnSold";
                        LblItemStatus.CssClass = "ui grey ribbon big label";
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

        protected void BtnPrintBid_Click(object sender, EventArgs e)
        {
            PrintBidSheetController bsCtrl = new PrintBidSheetController();
            List<string> itemNumbersToPrint = new List<string>();
            itemNumbersToPrint.Add(ItemID.Text);
            string templatePath = Server.MapPath("~\\PDF\\BidSheet.pdf");
            string temporaryPath = Server.MapPath("~\\PDF\\temp.pdf");
            string savePath = Server.MapPath("~\\PDF\\Filled.pdf");

            int i = bsCtrl.PrintSheets(itemNumbersToPrint, savePath, templatePath, temporaryPath);
            if (i > 0)
            {
                Response.Redirect("BidSheets.aspx");
            }
        }

        protected void BtnEditItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx?menu=6&itemId=" + ItemID.Text);
        }
    }
}