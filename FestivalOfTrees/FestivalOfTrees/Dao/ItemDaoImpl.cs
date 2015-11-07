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
        public void createItem(Item item)
        {
            SqlConnection conn = DBHelper.loadDB();
            string query = "INSERT INTO ITEM OUTPUT INSERTED.ITEMID VALUES ("
                    + "'" + item.CategoryID + "'"
                    + ", " + item.UserID
                    + ", '" + item.ItemName + "'"
                    + ", " + item.ItemValue
                    + ", " + item.AngelPrice
                    + ", " + item.MinBid
                    + ", 0)";
            SqlCommand command = new SqlCommand(query, conn);
            int id = (int)command.ExecuteScalar();
            item.ItemID = id;
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
                    + ", PAID = " + item.Paid
                    + " WHERE ITEMID = " + item.ItemID + ";";
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
                Paid = Convert.ToBoolean(reader["paid"])
            };
            return i;
        }
    }
}