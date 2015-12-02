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
        public int PrintSheets(List<string> itemNumbers, string destinationPath, string templatePath, string temporaryPath)
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
            return 1;

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
            else
            {
                int count = items.Count;
                int index = 0;
                while (count > 0)
                {

                    if (count >=2)
                    {
                        bsp.addToPDF(items[index], items[index + 1]);
                        count = count - 2;
                        index += 2;
                    }
                    else if(count ==1)
                    {
                        bsp.addToPDFWithOneItem(items[index]);
                        count = count - 1;
                        index -= 1;
                    }
                }
            }
            bsp.closePDF();
        }
    }
}