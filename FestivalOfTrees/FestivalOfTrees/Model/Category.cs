using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class Category
    {
        private string categoryID;
        private int auctionID;
        private string categoryName;
        private bool sponsored;
        private string sponsorName;
        private string parentID;

        public Category(string categoryID, int auctionID, string categoryName, bool sponsored, string sponsorName, string parentID)
        {
            this.categoryID = categoryID;
            this.auctionID = auctionID;
            this.categoryName = categoryName;
            this.sponsored = sponsored;
            this.sponsorName = sponsorName;
            this.parentID = parentID;
        }

        public override string ToString()
        {
            return "Category ID: " + CategoryID
                + "</br>Auction ID: " + AuctionID
                + "</br>Category Name: " + CategoryName
                + "</br>Sponsored: " + Sponsored
                + "</br>Sponsor Name: " + SponsorName
                + "</br>Parent ID: " + ParentID;
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

        public string ParentID
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