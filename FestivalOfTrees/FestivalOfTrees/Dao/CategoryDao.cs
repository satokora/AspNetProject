using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FestivalOfTrees.Model;

namespace FestivalOfTrees.Dao
{
    interface CategoryDao
    {
        List<Category> getAllCatItems();
    }
}