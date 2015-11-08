using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;

namespace FestivalOfTrees.Views
{
    public partial class Search1 : System.Web.UI.UserControl
    {
        private SearchUserController searchUser;
        private SearchItemController searchItem;
        protected void Page_Load(object sender, EventArgs e)
        {
            searchUser = new SearchUserController();
            SearchView.ActiveViewIndex = 0;

            searchItem = new SearchItemController();

            List<ListItem> listCatItems = searchItem.allItemCategories();
            int index = 1;
            foreach (ListItem result in listCatItems)
            {

                CatList.Items.Insert(index, result);
                index++;
            }
        }

        protected void SearchBuyer_Click(object sender, EventArgs e)
        {
            SearchResultView.ActiveViewIndex = 0;
            

            List<TableRow> resultRows = searchUser.getUserRows("whatever");
            Table1.Rows.Clear();
            foreach (TableRow row in resultRows)
            {
                Table1.Rows.Add(row);
            }
        }

        protected void SearchItem_Click(object sender, EventArgs e)
        {

        }

        protected void ItemBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SearchView.ActiveViewIndex = 1;
                CardViewIcon.Enabled = true;
                
            }
           
        }

        protected void Buyers_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SearchView.ActiveViewIndex = 0;
                CardViewIcon.Enabled = false;
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