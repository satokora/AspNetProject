using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;

/*
    For Use Case 4: Search Item Info

*/
namespace FestivalOfTrees.Controller
{
    public class SearchItemController
    {
        public List<ListItem> allItemCategories()
        {
            CategoryDaoImpl auctionItem = new CategoryDaoImpl();
            List<ListItem> itemcategories = new List<ListItem>();
            List<Category> catObjects = auctionItem.getAllCatItems();
            foreach (Category result in catObjects)
            {
                ListItem item = new ListItem();
                item.Attributes.Add("id", result.CategoryID);

                item.Value = result.CategoryName;
                itemcategories.Add(item);
            }
            return itemcategories;

        }
    }
}