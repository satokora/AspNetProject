using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class Auction
    {
        private int auctionID;
        private string auctionName;
        private DateTime auctionDate;
        private bool active;


        public override string ToString()
        {
            return "Auction ID: " + AuctionID
                + "</br>Auction Name: " + AuctionName
                + "</br>Auction Date: " + AuctionDate
                + "</br>Active: " + Active;
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

        public string AuctionName
        {
            get
            {
                return auctionName;
            }

            set
            {
                auctionName = value;
            }
        }

        public DateTime AuctionDate
        {
            get
            {
                return auctionDate;
            }

            set
            {
                auctionDate = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }
    }
}