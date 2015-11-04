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
+        public int updateUser(User u)
        {
            SqlConnection conn = DBHelper.loadDB();
            String query = "UPDATE USERINFO SET "
                    + "FIRSTNAME = '" + u.FirstName
                    + "', LASTNAME = '" + u.LastName
                    + "', STREETADDRESS = '" + u.Address
                    + "', CITY = " + u.City
                    + "', USERSTATE = '" + u.State
                    + "', ZIP = " + u.Zip
                    + ", PHONE = '" + u.Phone
                    + "' WHERE EMAIL = '" + u.Email + "';";
            SqlCommand command = new SqlCommand(query, conn);
            int rows = command.ExecuteNonQuery();
            return rows;
        }

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

        public User getUserByEmail(string email)
        {
            User user = null;
            SqlConnection conn = DBHelper.loadDB();

            String query = "SELECT * FROM USERINFO WHERE EMAIL = @EMAIL";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@EMAIL", email));

            return user;
        }

        public User getUserByLastName(string lastName)
        {
            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM USERINFO WHERE LASTNAME = @LASTNAME";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@LASTNAME", lastName));

            User u = getUser(command);
            return u;
        }

        public User getUserByPhone(string phoneNumber)
        {
            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM USERINFO WHERE PHONE = @PHONE";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@PHONE", phoneNumber));

            User u = getUser(command);
            return u;
        }
        
        public User getUserByNum(string bidNum)
        {
            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM USERINFO WHERE USERID = @USERID";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@USERID", bidNum));

            User u = getUser(command);
            return u;
        }

        private User getUser(SqlCommand command)
        {
            User user = null;

            try
            {
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

        private Credentials readerToCredentials(SqlDataReader reader)
        {
            reader.Read();
            Credentials c = new Credentials() {
                Email = Convert.ToString(reader["email"]),
                Password = Convert.ToString(reader["userpassword"]),
                Question = Convert.ToString(reader["question"]),
                Answer = Convert.ToString(reader["answer"])
            };
            return c;
        }

        private User readerToUser(SqlDataReader reader)
        {
            reader.Read();
            User u = new User()
            {
                UserID = Convert.ToString(reader["userid"]),
                Email = Convert.ToString(reader["email"]),
                FirstName = Convert.ToString(reader["firstname"]),
                LastName = Convert.ToString(reader["lastname"]),
                Address = Convert.ToString(reader["streetaddress"]),
                City = Convert.ToString(reader["city"]),
                State = Convert.ToString(reader["userstate"]),
                Zip = Convert.ToInt32(reader["zip"]),
                Admin = Convert.ToBoolean(reader["admin"]),
                Committee = Convert.ToBoolean(reader["committee"]),
                Donor = Convert.ToBoolean(reader["donor"]),
                Phone = Convert.ToString(reader["phone"]),
                Text = Convert.ToBoolean(reader["text"])
            };
            return u;
        }

        public void createUser(User user)
        {
            SqlConnection conn = DBHelper.loadDB();
            string query = "INSERT INTO USERINFO OUTPUT INSERTED.USERID VALUES ("
                    + "'" + user.Email
                    + "', '" + user.FirstName
                    + "', '" + user.LastName
                    + "', '" + user.Address
                    + "', '" + user.City
                    + "', '" + user.State
                    + "', " + user.Zip
                    + ", " + user.Admin
                    + ", " + user.Committee
                    + ", '" + user.Phone
                    + "', " + user.Text
                    + ", " + user.Donor
                    + ")";
            SqlCommand command = new SqlCommand(query, conn);
            user.UserID = (int)command.ExecuteScalar();
        }

        public void createCredentials(Credentials creds)
        {
            SqlConnection conn = DBHelper.loadDB();
            string query = "INSERT INTO USERCREDENTIALS VALUES ("
                    + "'" + creds.Email
                    + "', '" + creds.Password
                    + "', '" + creds.Question
                    + "', '" + creds.Answer
                    + "')";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
        }
    }
}