using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*
    For Use Case 1: Sign-in User
    This method is completed and passed alpha testing
*/
namespace FestivalOfTrees.Controller
{
    
    public class LoginController
    {
        private UserDaoImpl user;

        public LoginController()
        {
            user = new UserDaoImpl();
        }
        public bool authenticate(string userEmail, string pass)
        {
            Credentials creds = user.getCredentialsByEmail(userEmail);
            if (creds.Password.Equals(pass))
            {
                return true;
            }
            else
                return false;
        }
    }
}