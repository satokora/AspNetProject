using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using FestivalOfTrees.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Controller
{
    public class UserCtrl
    {
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
                SessionManager sm = SessionManager.getInstance();
                string sessionId = sm.createSessionId();
                ISession objS = (ISession)sm.getSession(sessionId);
                objS.setAttribute(sessionId, u);
                
            }
            return valid;
        }

        public User getBuyerInfo(string userId)
        {
            UserDaoImpl user = new UserDaoImpl();
            return user.getUserByNum(userId);
        }
    }
}