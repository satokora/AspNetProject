using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class GoWith
    {
        private int goID;
        private int itemID;
        private string descr;


        public override string ToString()
        {
            return "Go With ID: " + GoID
                + "<br/>Item ID: " + ItemID
                + "</br>Description: " + Descr;
        }

        public int GoID
        {
            get
            {
                return goID;
            }

            set
            {
                goID = value;
            }
        }

        public int ItemID
        {
            get
            {
                return itemID;
            }

            set
            {
                itemID = value;
            }
        }

        public string Descr
        {
            get
            {
                return descr;
            }

            set
            {
                descr = value;
            }
        }
    }
}