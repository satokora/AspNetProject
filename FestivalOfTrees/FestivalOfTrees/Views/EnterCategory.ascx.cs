using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;

namespace FestivalOfTrees.Views
{
    public partial class EnterCategory : System.Web.UI.UserControl
    {
        private CategoryDao dao;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnAddCategory_Click(object sender, EventArgs e)
        {
            
            Category newCat = new Category()
            {
                CategoryID = TxtNewCatId.Text,
                AuctionID = Convert.ToInt32(Session["Auction"].ToString()),
                CategoryName = TxtNewCatName.Text,
                Sponsored = ChkSponsored.Checked,
                SponsorName = TxtSponsorName.Text,
                ParentID = ParentCatList.SelectedValue,
                MinBidRate = Convert.ToDouble(MinBidRate.Text) / 100,
                AngelRate = Convert.ToDouble(AngPriceRate.Text) / 100

            };
                
        }

        protected void ChkSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            ParentCatList.Enabled = ChkSubCategory.Checked;
        }
    }
}