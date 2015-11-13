using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Controller;

namespace FestivalOfTrees.Views
{
    public partial class SearchItemUser : System.Web.UI.UserControl
    {
        private SearchUserController searchUser;
        private SearchItemController searchCatItem;
        protected void Page_Load(object sender, EventArgs e)
        {
            searchUser = new SearchUserController();
            
            
            
        }

        protected void SearchBuyer_Click(object sender, EventArgs e)
        {
            

            string phone = PhoneNumBox.Text;
            string lastName = LastNameBox.Text;

            if ((phone.Equals("")) && (lastName.Equals("")))
            {
                //searchlabel.Text = "Please search using user's name or phone number";
            }
            else
            {
                //List<TableRow> resultRows = searchUser.getUserRows(lastName, phone);
                //Table1.Rows.Clear();
                //foreach (TableRow row in resultRows)
                //{
                //    Table1.Rows.Add(row);
                //}
            }

            


        }

        protected void SearchItem_Click(object sender, EventArgs e)
        {

        }


      
    }
}