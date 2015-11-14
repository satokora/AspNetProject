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
        ItemDaoImpl dao = new ItemDaoImpl();

        public Item getItemByID(string itemID)
        {
            return dao.getItemByNumber(itemID);
        }



    }
}