using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*
    For Use Case 1: Sign-in User

*/
namespace FestivalOfTrees.Controller
{
    // 10.30.15 satoko I added this code just as a reference so you can delete the following one and build your own code
    public class LoginController
    {
        private UserDao userDao;
        public LoginController()
        {
            userDao = new UserDaoImpl();
        }
        public bool authenticate(string userEmail, string pass)
        {
            User loginUser = null;
            loginUser = userDao.getUserByEmail(userEmail);
            if (loginUser != null)
            {
                //if (loginUser.getPassword().equals(pass)) // 
                //{
                    return true;
                //}
                //else
                //{
                //    return false;
                //}
                    
            }
            else
            {
                return false;
            }
        }
    }
}