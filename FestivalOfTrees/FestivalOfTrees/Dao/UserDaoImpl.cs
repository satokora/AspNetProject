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
        public int updateUser(User user)
        {
            int admin = 0, committee = 0, donor = 0, text = 0;
            if (user.Admin)
                admin = 1;
            if (user.Committee)
                committee = 1;
            if (user.Donor)
                donor = 1;
            if (user.Text)
                text = 1;
            SqlConnection conn = DBHelper.loadDB();
            String query = "UPDATE USERINFO SET "
                    + "FIRSTNAME = '" + user.FirstName
                    + "', LASTNAME = '" + user.LastName
                    + "', STREETADDRESS = '" + user.Address
                    + "', CITY = " + user.City
                    + "', USERSTATE = '" + user.State
                    + "', ZIP = " + user.Zip
                    + ", PHONE = '" + user.Phone
                    + "', ADMIN = '" + admin
                    + ", COMMITTEE = '" + committee
                    + ", DONOR = '" + donor
                    + ", TEXT = '" + text
                    + " WHERE EMAIL = '" + user.Email + "';";
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

            user = getUser(command);

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
            Credentials c = new Credentials()
            {
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
                UserID = Convert.ToInt32(reader["userid"]),
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

        public bool createUser(User user)
        {
            int admin = 0, committee = 0, donor = 0, text = 0;
            if (user.Admin)
                admin = 1;
            if (user.Committee)
                committee = 1;
            if (user.Donor)
                donor = 1;
            if (user.Text)
                text = 1;
            bool added = true;
            SqlConnection conn = DBHelper.loadDB();
            String query = "INSERT INTO USERINFO VALUES (@EMAIL, @FNAME, @LNAME, @ADDRESS, @CITY, @STATE, @ZIP, @ADMIN, @COMMITTEE, @PHONE, @TEXT, @DONOR)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@EMAIL", user.Email));
            command.Parameters.Add(new SqlParameter("@FNAME", user.FirstName));
            command.Parameters.Add(new SqlParameter("@LNAME", user.LastName));
            command.Parameters.Add(new SqlParameter("@ADDRESS", user.Address));
            command.Parameters.Add(new SqlParameter("@CITY", user.City));
            command.Parameters.Add(new SqlParameter("@STATE", user.State));
            command.Parameters.Add(new SqlParameter("@ZIP", user.Zip));
            command.Parameters.Add(new SqlParameter("@ADMIN", admin));
            command.Parameters.Add(new SqlParameter("@COMMITTEE", committee));
            command.Parameters.Add(new SqlParameter("@PHONE", user.Phone));
            command.Parameters.Add(new SqlParameter("@TEXT", text));
            command.Parameters.Add(new SqlParameter("@DONOR", donor));
            try
            {
                user.UserID = (int)command.ExecuteScalar();
            }
            catch (SqlException e)
            {
                added = false;
            }
            return added;
        }

        public bool createCredentials(Credentials creds)
        {
            bool added = true;
            SqlConnection conn = DBHelper.loadDB();
            string query = "INSERT INTO USERCREDENTIALS VALUES (@EMAIL, @PASSWORD, @QUESTION, @ANSWER)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@EMAIL", creds.Email));
            command.Parameters.Add(new SqlParameter("@PASSWORD", creds.Password));
            command.Parameters.Add(new SqlParameter("@QUESTION", creds.Question));
            command.Parameters.Add(new SqlParameter("@ANSWER", creds.Answer));
            try
            {
                command.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                added = false;
            }
            return added;
        }
    }
}