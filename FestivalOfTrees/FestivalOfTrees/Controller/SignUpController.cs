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

                if (signUp.createUser(user))
                {
                    addSuccess = true;
                }
                else
                    addSuccess = false;
                return addSuccess;
            }
            return addSuccess;
        }
        public bool addUserCredentials(Credentials creds)
        {
            bool addSuccess = false;
            if(signUp.createCredentials(creds))
            {
                addSuccess = true;
            }
            return addSuccess;
        }
    }


}