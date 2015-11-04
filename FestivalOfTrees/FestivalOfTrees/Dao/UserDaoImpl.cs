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
        public Credentials getCredentialsByEmail(string email)
        {
            Credentials creds = null;
            SqlConnection conn = DBHelper.loadDB();

            String query = "SELECT * FROM USERCREDENTIALS WHERE EMAIL = @EMAIL";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@EMAIL", email));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    creds = readerToCredentials(reader);
                }
            }
            catch (SqlException ex)
            {
                // error handling
            }
            return creds;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns>True if email is NOT present in DB</returns>
        public bool checkDB(string email)
        {
            bool valid = false;
            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT EMAIL FROM USERINFO WHERE EMAIL = @EMAIL";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@EMAIL", email));
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    valid = true;
                }
            }
            catch (SqlException ex)
            {
                // error handling
            }
            return valid;
        }

        //Added this method to process sign ups specifically putting data in dob.USERINFO
        public bool addNewUser(User user)
        {
            bool added = false;
            SqlConnection conn = DBHelper.loadDB();
            String query = "INSERT INTO USERINFO VALUES (@EMAIL, @FNAME, @LNAME, @ADDRESS, @CITY, @STATE, @ZIP, @ADMIN, @COMMITTEE, @PHONE, @TEXT, @DONOR)";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@EMAIL", user.Email));
                command.Parameters.Add(new SqlParameter("@FNAME", user.FirstName));
                command.Parameters.Add(new SqlParameter("@LNAME", user.LastName));
                command.Parameters.Add(new SqlParameter("@ADDRESS", user.Address));
                command.Parameters.Add(new SqlParameter("@CITY", user.City));
                command.Parameters.Add(new SqlParameter("@STATE", user.State));
                command.Parameters.Add(new SqlParameter("@ZIP", user.Zip));
                command.Parameters.Add(new SqlParameter("@ADMIN", user.Admin));
                command.Parameters.Add(new SqlParameter("@COMMITTEE", user.Committee));
                command.Parameters.Add(new SqlParameter("@PHONE", user.Phone));
                command.Parameters.Add(new SqlParameter("@TEXT", user.Text));
                command.Parameters.Add(new SqlParameter("@DONOR", user.Donor));

                int result = command.ExecuteNonQuery();

                if (result == 1)
                    added = true;
                else
                    added = false;
            }
            catch(SqlException ex)
            {
                //error handling
            }
            return added;
        }

        public bool addNewUserCredentials(string email, string password)
        {
            bool added = false;
            SqlConnection conn = DBHelper.loadDB();
            String query = "INSERT INTO USERCREDENTIALS VALUES (@EMAIL, @PASSWORD, @QUESTION, @ANSWER)";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@EMAIL", email));
                command.Parameters.Add(new SqlParameter("@PASSWORD", password));
                command.Parameters.Add(new SqlParameter("@QUESTION", ""));
                command.Parameters.Add(new SqlParameter("@ANSWER", ""));

                int result = command.ExecuteNonQuery();

                if (result == 1)
                    added = true;
                else
                    added = false;
            }
            catch (SqlException ex)
            {
                //error handling
            }


            return added;
        }

        public User getUserByEmail(string email)
        {
            User user = null;
            SqlConnection conn = DBHelper.loadDB();

            String query = "SELECT * FROM USERINFO WHERE EMAIL = @EMAIL";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@EMAIL", email));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.Error.Write("No Rows");
                    
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

        private Credentials readerToCredentials(SqlDataReader reader)
        {
            reader.Read();
            Credentials c = new Credentials(Convert.ToString(reader["email"]), Convert.ToString(reader["userpassword"]),
                                            Convert.ToString(reader["question"]), Convert.ToString(reader["answer"]));
            return c;
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