using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3;

/*
    For Use Case 5: Print bid sheets

*/
namespace FestivalOfTrees.Controller
{
    public class PrintBidSheetController
    {
        private BidSheetPrinter bsp;
        ItemDaoImpl dao = new ItemDaoImpl();
        public void PrintSheets(List<string> itemNumbers, string destinationPath, string templatePath, string temporaryPath)
        {
            bsp = new BidSheetPrinter();
            bsp.formPath = templatePath;
            bsp.savePath = destinationPath;
            bsp.tempFilePath = temporaryPath;
            List<Item> itemList = new List<Item>();
            Item t;
            foreach(string i in itemNumbers)
            {
                t = dao.getItemByNumber(i);
                itemList.Add(t);
            }
            Print(itemList);
            
        }
        private void Print(List<Item> items)
        {
            bsp.openPDF();
            if (items.Count % 2 == 0)
            {
                int count = 0;
                while(count < items.Count)
                {
                    bsp.addToPDF(items[count], items[count +1]);
                    count = count + 2;
                }
            }
            bsp.closePDF();
        }
    }
}