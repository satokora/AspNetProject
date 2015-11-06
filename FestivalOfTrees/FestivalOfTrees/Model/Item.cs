using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class Item
    {
        private int itemID;
        private string categoryID;
        private int userID;
        private string itemName;
        private double itemValue;
        private double angelPrice;
        private double minBid;
        private bool paid;

        public override string ToString()
        {
            return "ItemID: " + ItemID
                + "</br>Category ID: " + CategoryID
                + "</br>User ID: " + UserID
                + "</br>Item Name: " + ItemName
                + "</br>Item Value: " + ItemValue
                + "</br>Angel Price: " + AngelPrice
                + "</br>Min Bid: " + MinBid
                + "</br>Paid: " + Paid;
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

        public string CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public double ItemValue
        {
            get
            {
                return itemValue;
            }

            set
            {
                itemValue = value;
            }
        }

        public double AngelPrice
        {
            get
            {
                return angelPrice;
            }

            set
            {
                angelPrice = value;
            }
        }

        public double MinBid
        {
            get
            {
                return minBid;
            }

            set
            {
                minBid = value;
            }
        }

        public bool Paid
        {
            get
            {
                return paid;
            }

            set
            {
                paid = value;
            }
        }
    }
}