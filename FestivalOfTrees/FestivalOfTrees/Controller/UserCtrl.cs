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


        public bool authenticate(string userEmail, string pass)
        {
            bool valid = false;
            UserDaoImpl user = new UserDaoImpl();
            Credentials c = user.getCredentialsByEmail(userEmail);

            if (c != null)
            {
                User u = user.getUserByEmail(c.Email);
                valid = true;

                //Setting session data here
                //SessionManager sm = SessionManager.getInstance();
                //string sessionId = sm.createSessionId(u);
                //ISession objS = (ISession)sm.getSession(sessionId);   
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