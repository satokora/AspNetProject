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
        bool checkDB(string email);

        Credentials getCredentialsByEmail(string email);

        User getUserByEmail(string email);

        void getUserByNum(string bidNum);

        User readerToUser(SqlDataReader reader);
    }
}
