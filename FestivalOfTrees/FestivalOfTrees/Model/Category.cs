using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class Category
    {
        private int categoryID;
        private int auctionID;
        private string categoryName;
        private bool sponsored;
        private string sponsorName;
        private int parentID;


        public override string ToString()
        {
            return "Category ID: " + CategoryID
                + "</br>Auction ID: " + AuctionID
                + "</br>Category Name: " + CategoryName
                + "</br>Sponsored: " + Sponsored
                + "</br>Sponsor Name: " + SponsorName
                + "</br>Parent ID: " + ParentID;
        }

        public int CategoryID
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

        public int AuctionID
        {
            get
            {
                return auctionID;
            }

            set
            {
                auctionID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }

        public bool Sponsored
        {
            get
            {
                return sponsored;
            }

            set
            {
                sponsored = value;
            }
        }

        public string SponsorName
        {
            get
            {
                return sponsorName;
            }

            set
            {
                sponsorName = value;
            }
        }

        public int ParentID
        {
            get
            {
                return parentID;
            }

            set
            {
                parentID = value;
            }
        }
    }
}