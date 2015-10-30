using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FestivalOfTrees.Model;
using System.Data.OleDb;

namespace FestivalOfTrees.Dao
{
    public class UserDaoImpl : UserDao
    {


        public User getUserByEmail(string email)
        {
            User user = null;
            SqlConnection conn = DBHelper.loadDB();

            String query =
                        "SELECT * FROM USERINFO WHERE EMAIL = @EMAIL";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@EMAIL", email));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    user = readerToUser(reader);
                }
            }
            catch (SqlException ex)
            {
                // error handling
            }
            return user;
        }

        public void getUserByNum(string bidNum)
        {
            throw new NotImplementedException();
        }

        public User readerToUser(SqlDataReader reader)
        {
            reader.Read();
            User u = new User(Convert.ToString(reader["userid"]), Convert.ToString(reader["email"]), Convert.ToString(reader["firstname"]),
                                Convert.ToString(reader["lastname"]), Convert.ToString(reader["streetaddress"]), Convert.ToString(reader["city"]),
                                Convert.ToString(reader["userstate"]), Convert.ToInt32(reader["zip"]), Convert.ToBoolean(reader["admin"]),
                                Convert.ToBoolean(reader["committee"]), Convert.ToBoolean(reader["donor"]), Convert.ToString(reader["phone"]), 
                                Convert.ToBoolean(reader["text"]));
            return u;
        }
    }
}