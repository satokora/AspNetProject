using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Dao
{
    interface ItemDao
    {
        List<Item> getItemsByCategory(string category);

        Item getItemByNumber(string itemNum);

        void createItem(Item item);

        int updateItem(Item item);

    }
}