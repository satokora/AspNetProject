using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class Request
    {
        private int requestID;
        private string requestEmail;
        private bool admin;
        private bool committee;
        private bool donor;

        public override string ToString()
        {
            return "Request ID: " + RequestID
                + "</br>Request Email: " + RequestEmail
                + "</br>Admin: " + Admin
                + "</br>Committee: " + Committee
                + "</br>Donor: " + Donor;
        }


        public int RequestID
        {
            get
            {
                return requestID;
            }

            set
            {
                requestID = value;
            }
        }

        public string RequestEmail
        {
            get
            {
                return requestEmail;
            }

            set
            {
                requestEmail = value;
            }
        }

        public bool Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        public bool Committee
        {
            get
            {
                return committee;
            }

            set
            {
                committee = value;
            }
        }

        public bool Donor
        {
            get
            {
                return donor;
            }

            set
            {
                donor = value;
            }
        }
    }
}