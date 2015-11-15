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
        public bool authenticate(string userEmail, string pass)
        {
            bool valid = false;
            UserDaoImpl user = new UserDaoImpl();
            Credentials c = user.getCredentialsByEmail(userEmail);

            if (c != null)
            {
                User u = user.getUserByEmail(c.Email);
                valid = true;

                //I think this is where we want to populate the session data
                new SessionManager(SessionEnum.LogInName).Add(u.Email);
                new SessionManager(SessionEnum.LogInTime).Add(DateTime.Now);

                string sessionId = new SessionManager().GetSessionId();
                bool hasSession = new SessionManager().HasAnySessions();

            }
            return valid;
        }
    }
}