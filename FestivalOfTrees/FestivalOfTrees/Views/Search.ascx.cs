using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees.Views
{
    public partial class SearchItems : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SearchView.ActiveViewIndex = 0;
        }

        protected void SearchBuyer_Click(object sender, EventArgs e)
        {

        }

        protected void SearchItem_Click(object sender, EventArgs e)
        {

        }

        protected void ItemBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SearchView.ActiveViewIndex = 1;
            }
           
        }

        protected void Buyers_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SearchView.ActiveViewIndex = 0;
            }
            
        }
        protected void TableViewBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SearchResultView.ActiveViewIndex = 0;
            }

        }
        protected void CardViewBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SearchResultView.ActiveViewIndex = 1;
            }

        }

        protected void ViewSingleItem_Click(object sender, EventArgs e)
        {

        }


    }
}