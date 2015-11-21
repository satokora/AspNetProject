using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Controller
{
    public class ItemController
    {
        CategoryDaoImpl catDao = new CategoryDaoImpl();
        ItemDaoImpl dao = new ItemDaoImpl();
        private Category category;

        public Category Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public void selectCategory(string catID)
        {
            category = catDao.getByID(catID);
        }


        public Item getItemByID(string itemID)
        {
            return dao.getItemByNumber(itemID);
        }

        public int createItem(Item item)
        {
             return dao.createItem(item);
        }

        public void createItem(Item item, List<string> emailList)
        {
            createItem(item);
            addDonors(emailList, item.ItemID);
        }

        public void addDonors(List<string> emailList, int itemID)
        {
            foreach (string email in emailList)
            {
                dao.createUserItem(email, itemID);
            }
        }

        public double calcMinBid(double value)
        {
            double min = 0;
            if (category != null)
            {
                min = value * category.MinBidRate;
            }
            return min;
        }

        public double calcAngelPrice(double value)
        {
            double angel = 0;
            if (Category != null)
            {
                angel = value * Category.AngelRate;
            }
            return angel;
        }

        public List<User> getDesigners(String itemId)
        {
            return dao.getDesignersByItemId(itemId);
        }
        public string getSponsorName(string catId)
        {
            return catDao.getByID(catId).SponsorName;
        }
    }
}