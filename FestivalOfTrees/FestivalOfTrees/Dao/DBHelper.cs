using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Dao
{
    public class DBHelper
    {

        public static SqlConnection loadDB()
        {
            SqlConnection dbConnection = null; 
            try
            {
                dbConnection = new SqlConnection("Data Source=itksqlexp8;Integrated Security=true");
                dbConnection.Open();
                dbConnection.ChangeDatabase("it368_Auction_Project");
            }
            catch (SqlException exception)
            {
                Console.Write("<p>Error code " + exception.Number
                    + ": " + exception.Message + "</p>");
            }
            return dbConnection;
        }




    }
}