using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Dao
{
    public class ItemDaoImpl : ItemDao
    {

        public void createUserItem(string email, int itemID)
        {
            SqlConnection conn = DBHelper.loadDB();
            string query = "INSERT INTO USERITEM VALUES ("
                + "'@EMAIL'"
                + ", @ITEMID);";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@EMAIL", email));
            command.Parameters.Add(new SqlParameter("@ITEMID", itemID));

            int rows = command.ExecuteNonQuery();
        }

        public void deleteUserItem(string email, int itemID)
        {
            SqlConnection conn = DBHelper.loadDB();
            string query = "DELETE USERITEM where EMAIL='@EMAIL' and ITEMID = @ITEMID";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@EMAIL", email));
            command.Parameters.Add(new SqlParameter("@ITEMID", itemID));

            int rows = command.ExecuteNonQuery();
        }

        public int createItem(Item item)
        {
            SqlConnection conn = DBHelper.loadDB();
            string query = "INSERT INTO ITEM (CATEGORYID, USERID, ITEMNAME, ITEMVALUE, ANGELPRICE, MINBID, DESCR) OUTPUT INSERTED.ITEMID  "
                            + "VALUES (@CATEGORYID, @USERID, @ITEMNAME, @ITEMVALUE, @ANGELPRICE, @MINBID, @DESCRIPTION)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@CATEGORYID", item.CategoryID));
            command.Parameters.Add(new SqlParameter("@USERID", item.UserID));
            command.Parameters.Add(new SqlParameter("@ITEMNAME", item.ItemName));
            command.Parameters.Add(new SqlParameter("@ITEMVALUE", item.ItemValue));
            command.Parameters.Add(new SqlParameter("@ANGELPRICE", item.AngelPrice));
            command.Parameters.Add(new SqlParameter("@MINBID", item.MinBid));
            command.Parameters.Add(new SqlParameter("@DESCRIPTION", item.Description));
            item.ItemID = (int)command.ExecuteScalar();
            return item.ItemID;

        }

        public int updateItem(Item item)
        {

            SqlConnection conn = DBHelper.loadDB();
            String query = "UPDATE ITEM SET "
                    + "CATEGORYID = '" + item.CategoryID
                    + "', USERID = '" + item.UserID
                    + "', ITEMNAME = '" + item.ItemName
                    + "', ITEMVALUE = " + item.ItemValue
                    + ", ANGELPRICE = " + item.AngelPrice
                    + ", MINBID = " + item.MinBid
                    + ", PAID = " + Convert.ToInt32(item.Paid)
                    + ", DESCR = '" + item.Description
                    + "' WHERE ITEMID = " + item.ItemID + ";";
            SqlCommand command = new SqlCommand(query, conn);
            int rows = command.ExecuteNonQuery();
            return rows;
        }
        
        //This itemNum can contain the letter prefix. G307 will return item with itemNum 307.
        public Item getItemByNumber(string itemNum)
        {
            int firstDigit = itemNum.IndexOfAny("0123456789".ToCharArray());
            string categoryID = itemNum.Substring(0, firstDigit);
            string itemNumber = itemNum.Substring(firstDigit);

            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM ITEM WHERE ITEMID = @ITEMID";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@ITEMID", itemNumber));

            Item i = getItem(command);
            return i;
        }

        public List<Item> getItemsByCategory(string category)
        {
            List<Item> iList = new List<Item>();
            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM CATEGORYITEMS WHERE CATEGORYNAME = @CATEGORY";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@CATEGORY", category));

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Item i = new Item()
                        {
                            ItemID = Convert.ToInt32(reader["itemid"]),
                            CategoryID = Convert.ToString(reader["categoryid"]),
                            UserID = Convert.ToInt32(reader["userid"]),
                            ItemName = Convert.ToString(reader["itemname"]),
                            ItemValue = Convert.ToDouble(reader["itemvalue"]),
                            AngelPrice = Convert.ToDouble(reader["angelprice"]),
                            MinBid = Convert.ToDouble(reader["minbid"]),
                            Paid = Convert.ToBoolean(reader["paid"])
                        };
                        iList.Add(i);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return iList;
        }

        public List<User> getDesignersByItemId(string itemId)
        {
            List<User> uList = new List<User>();
            int firstDigit = itemId.IndexOfAny("0123456789".ToCharArray());
            string categoryID = itemId.Substring(0, firstDigit);
            string itemNumber = itemId.Substring(firstDigit);

            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM USERINFO WHERE EMAIL IN (SELECT EMAIL FROM USERITEM WHERE ITEMID = @ITEMID)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@ITEMID", itemId));

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User u = new User()
                        {
                            UserID = Convert.ToInt32(reader["userid"]),
                            Email = Convert.ToString(reader["email"]),
                            FirstName = Convert.ToString(reader["firstname"]),
                            LastName = Convert.ToString(reader["lastname"]),
                            Address = Convert.ToString(reader["streetadress"]),
                            City = Convert.ToString(reader["city"]),
                            State = Convert.ToString(reader["usertsate"]),
                            Zip = Convert.ToInt32(reader["zip"]),
                            Admin = Convert.ToBoolean(reader["admin"]),
                            Committee = Convert.ToBoolean(reader["committee"]),
                            Phone = Convert.ToString(reader["phone"]),
                            Text = Convert.ToBoolean(reader["text"]),
                            Donor = Convert.ToBoolean(reader["donor"])
                        };
                        
                        uList.Add(u);
                    }
                }
            }
            catch (SqlException ex)
            {

            }

            return uList;
        }
        
        private Item getItem(SqlCommand command)
        {
            Item item = null;

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    item = readerToItem(reader);
                }
            }
            catch (SqlException ex)
            {
                // error handling
            }
            return item;
        }

        private Item readerToItem(SqlDataReader reader)
        {
            reader.Read();
            Item i = new Item()
            {
                ItemID = Convert.ToInt32(reader["itemid"]),
                CategoryID = Convert.ToString(reader["categoryid"]),
                UserID = Convert.ToInt32(reader["userid"]),
                ItemName = Convert.ToString(reader["itemname"]),
                ItemValue = Convert.ToDouble(reader["itemvalue"]),
                AngelPrice = Convert.ToDouble(reader["angelprice"]),
                MinBid = Convert.ToDouble(reader["minbid"]),
                Paid = Convert.ToBoolean(reader["paid"]),
                Description = Convert.ToString(reader["descr"])
            };
            return i;
        }
    }
}