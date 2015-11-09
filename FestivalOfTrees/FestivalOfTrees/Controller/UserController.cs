using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Controller
{
    public class UserController
    {

        private static User user;
        private UserDaoImpl userDao;
        private static Credentials credentials;

        

        public UserDaoImpl UserDao
        {
            get
            {
                return userDao;
            }

            set
            {
                userDao = value;
            }
        }

        public static Credentials Credentials
        {
            get
            {
                return credentials;
            }

            set
            {
                credentials = value;
            }
        }

        public static User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public bool signIn(Credentials c)
        {
            bool valid = false;
            UserDao = new UserDaoImpl();
            Credentials = userDao.getCredentialsByEmail(c.Email);

            if(Credentials != null && Credentials.Equals(c))
            {
                User = userDao.getUserByEmail(c.Email);
                valid = true;
            }
            return valid;
        }

        public bool signUp(User u, Credentials c)
        {
            bool valid = false;
            userDao = new UserDaoImpl();

            if (userDao.createUser(u))
            {
                User = u;
                if (userDao.createCredentials(c))
                {
                    Credentials = c;
                    valid = true;
                }
            }
            return valid;
        }
    }
}