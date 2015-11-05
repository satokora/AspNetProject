using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class DBTestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                UserDaoImpl dao = new UserDaoImpl();
                //ItemDaoImpl dao = new ItemDaoImpl();

                //Credentials creds = dao.getCredentialsByEmail(TextBox1.Text.ToString());
                //User user = dao.getUserByEmail(TextBox1.Text.ToString());
                //List<Item> list = dao.getItemsByCategory(TextBox1.Text.ToString());
                //Item item = dao.getItemByNumber(TextBox1.Text.ToString());
                //Response.Write(list.Count);
                //list.ForEach(printItem );
                //Response.Write(item.ToString());

                //Item i = new Item()
                //{
                //    CategoryID = "CP",
                //    UserID = 100,
                //    ItemName = "TestItem",
                //    ItemValue = 100,
                //    AngelPrice = 75,
                //    MinBid = 50,
                //    Paid = false
                //};


                User u = new User()
                {
                    Email = "tlenahan@ilstu.edu",
                    FirstName = "Tim",
                    LastName = "Lenahan",
                    Address = "123 Easy st",
                    City = "Normal",
                    State = "IL",
                    Zip = 61761,
                    Admin = true,
                    Committee = false,
                    Donor = false,
                    Phone = "6303106285",
                    Text = true
                };
                dao.createUser(u);


                //int newID = dao.createItem(i);
                //Response.Write(i.ItemID);

            }
        }
        protected void printItem(Item i)
        {
            Response.Write(i.ToString()+ "</br>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}