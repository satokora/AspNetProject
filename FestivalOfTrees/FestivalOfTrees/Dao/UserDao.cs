using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FestivalOfTrees.Dao
{
    interface UserDao
    {
        int updateUser(User u);

        void createUser(User user);

        void createCredentials(Credentials creds);

        User getUserByLastName(string lastName);

        bool checkDB(string email);

        Credentials getCredentialsByEmail(string email);

        User getUserByEmail(string email);

        User getUserByPhone(string phoneNumber);

        User getUserByNum(string bidNum);
    }
}
