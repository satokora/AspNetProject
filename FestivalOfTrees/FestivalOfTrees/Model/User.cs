using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class User
    {
        private string userID;
        private string email;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zip;
        private bool admin;
        private bool committee;
        private bool donor;
        private string phone;
        private bool text;

        public User(string userID, string email, string firstName, string lastName, 
                    string address, string city, string state, int zip, bool admin, 
                    bool committee, bool donor, string phone, bool text)
        {
            this.userID = userID;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.admin = admin;
            this.committee = committee;
            this.donor = donor;
            this.phone = phone;
            this.text = text;
        }

        public string UserID
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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public int Zip
        {
            get
            {
                return zip;
            }

            set
            {
                zip = value;
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

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public bool Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
    }
}