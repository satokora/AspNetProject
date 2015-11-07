using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
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
        private UserDaoImpl signUp;

        public SignUpController()
        {
            signUp = new UserDaoImpl();
        }
        public bool addUser(User user)
        {
            bool addSuccess = false;

            if (signUp.checkDB(user.Email))
            {

                if (signUp.addNewUser(user))
                {
                    addSuccess = true;
                }
                else
                    addSuccess = false;
                return addSuccess;
            }
            return addSuccess;
        }
        public bool addUserCredentials(string email, string password)
        {
            bool addSuccess = false;
            if(signUp.addNewUserCredentials(email, password))
            {
                addSuccess = true;
            }
            return addSuccess;
        }
    }


}