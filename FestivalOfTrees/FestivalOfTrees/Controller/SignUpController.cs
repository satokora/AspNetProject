using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using FestivalOfTrees.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
    For Use Case 2: Sign up Account 

*/
namespace FestivalOfTrees.Controller
{
    public class SignUpController
    {
        private UserDaoImpl userDao;

        public SignUpController()
        {
            userDao = new UserDaoImpl();
        }
        public bool addUser(User user)
        {
            bool addSuccess = false;

            addSuccess = userDao.checkDB(user.Email);
            if(addSuccess)
                addSuccess = userDao.addNewUser(user);
                
            return addSuccess;
        }
        public bool addUserCredentials(string email, string password)
        {
            bool addSuccess = false;
            if(userDao.addNewUserCredentials(email, password))
            {
                addSuccess = true;
                UserCtrl newUser = new UserCtrl();
                newUser.authenticate(email, password);
            }
            return addSuccess;
        }
    }


}