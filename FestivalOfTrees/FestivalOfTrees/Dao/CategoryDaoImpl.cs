using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FestivalOfTrees.Model;
using System.Data.SqlClient;

namespace FestivalOfTrees.Dao
{
    public class CategoryDaoImpl : CategoryDao
    {
        public Category getByID(string id)
        {
            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM CATEGORY WHERE "
                + "CATEGORYID = @ID";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@ID", id));
            Category cat = null;
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                cat = new Category()
                {
                    CategoryID = reader["CATEGORYID"].ToString(),
                    AuctionID = Convert.ToInt32(reader["AUCTIONID"]),
                    CategoryName = reader["CATEGORYNAME"].ToString(),
                    Sponsored = Convert.ToBoolean(reader["SPONSORED"]),
                    SponsorName = reader["SPONSORNAME"].ToString(),
                    ParentID = reader["PARENTID"].ToString(),
                    MinBidRate = Convert.ToDouble(reader["MINBIDRATE"]),
                    AngelRate = Convert.ToDouble(reader["ANGELPRICERATE"])
                };
            }
            catch(SqlException ex)
            {

            }
            return cat;
        }

        public List<Category> getAllCatItems()
        {
            //List<Item> iList = new List<Item>();
            List<Category> categories = new List<Category>();
            //C/*ategory catItem = null;*/
            //DropDownList dropdown = new DropDownList();
            SqlConnection conn = DBHelper.loadDB();
            String query = "SELECT * FROM CATEGORY";
            SqlCommand command = new SqlCommand(query, conn);
            //command.Parameters.Add(new SqlParameter("@CATEGORY", category));

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category catItem = new Category(reader["CATEGORYID"].ToString(), Convert.ToInt32(reader["AUCTIONID"]), reader["CATEGORYNAME"].ToString(), Convert.ToBoolean(reader["SPONSORED"]), reader["SPONSORNAME"].ToString(), reader["PARENTID"].ToString());

                    categories.Add(catItem);
                }




            }
            catch (SqlException ex)
            {

            }
            return categories;

        }
    }
}