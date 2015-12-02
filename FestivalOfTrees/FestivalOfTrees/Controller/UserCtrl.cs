using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Controller
{
    public class UserCtrl
    { 

        private string sesId;

        public string SesId
        {
            get
            {
                return sesId;
            }

            set
            {
                sesId = value;
            }
        }
    
        public void createRequest(Request request)
        {
            UserDaoImpl uDao = new UserDaoImpl();
            uDao.createRequest(request);
        }

        public User getProfileInfo(string email)
        {
            UserDaoImpl uDao = new UserDaoImpl();
            User currentUser = uDao.getUserByEmail(email);

            return currentUser;
        }

        public bool authenticate(string userEmail, string pass)
        {
            bool valid = false;
            UserDaoImpl user = new UserDaoImpl();
            Credentials c = user.getCredentialsByEmail(userEmail);
            Credentials inputCreds = new Credentials(userEmail, pass);

            if (c.Password.Equals(inputCreds.Password) && c.Email.Equals(inputCreds.Email))
            {
                User u = user.getUserByEmail(c.Email);
                valid = true;  
            }
            return valid;
        }
        public bool isAdmin(string userEmail, string pass)
        {
            bool admin = false;
            UserDaoImpl user = new UserDaoImpl();
            Credentials c = user.getCredentialsByEmail(userEmail);

            if (c != null)
            {
                User u = user.getUserByEmail(c.Email);
                if (u.Admin)
                {
                    admin = true;
                }
            }
            return admin;
        }

        public User getBuyerInfo(string userId)
        {
            UserDaoImpl user = new UserDaoImpl();
            return user.getUserByNum(userId);
        }

        public void approveRequest(List<int> requestIDList)
        {
            UserDaoImpl userDao = new UserDaoImpl();
            List<Request> requestList = new List<Request>();
            foreach(int id in requestIDList)
            {
                requestList.Add(userDao.getRequestByID(id));
            }

            foreach(Request r in requestList)
            {
                userDao.approveRequest(r);
            }

            
        }
    }
}