using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using FestivalOfTrees.Model;
using FestivalOfTrees.Dao;

/*
    For Use Case 4: Search User Info

*/
namespace FestivalOfTrees.Controller
{
    public class SearchUserController
    {
        private UserDaoImpl userDaoImpl;
        public SearchUserController()
        {
            userDaoImpl = new UserDaoImpl();
        }
        
        public List<TableRow> getUserRows(string lastName, string phoneNum)
        {
            // this method is created by Satoko in order to check ui design.  Delete the following codes
            // when you implement data retrieval from user table.
            List<TableRow> rows = new List<TableRow>();
            User auctionUser = null;
            List<User> auctionUserlastName = new List<User>();

            if (!phoneNum.Equals(""))
            {
                auctionUser = userDaoImpl.getUserByPhone(phoneNum);
            }

            if (!lastName.Equals(""))
            {
                auctionUserlastName = userDaoImpl.getUserByLastName(lastName);
            }
            

            TableHeaderRow userHeader = new TableHeaderRow();
            string[] headerStrs = { "Email", "Name", "Location", "PHONE", "" };
            foreach (string headerTitle in headerStrs)
            {
                TableHeaderCell titleCell = new TableHeaderCell();
                titleCell.Text = headerTitle;
                userHeader.Cells.Add(titleCell);
            }

            rows.Add(userHeader);

            if (auctionUser != null)
                {
                    
                    TableCell emailCell = new TableCell();
                    TableCell fullNameCell = new TableCell();
                    TableCell locCell = new TableCell();
                    TableCell phoneCell = new TableCell();
                    TableCell btnCell = new TableCell();
                
                    emailCell.Text = auctionUser.Email.ToString();
                    fullNameCell.Text = auctionUser.LastName.ToString() + ", " + auctionUser.FirstName.ToString();
                    locCell.Text = auctionUser.City.ToString() + ", "+ auctionUser.State.ToString();
                    phoneCell.Text = auctionUser.Phone.ToString();
                    btnCell.Text = "<a class='ui button' href='SingleView.aspx?userId=" + auctionUser.UserID +"'>View</a>";


                    TableRow newRow = new TableRow();
                    newRow.Cells.Add(emailCell);
                    newRow.Cells.Add(fullNameCell);
                    newRow.Cells.Add(locCell);
                    newRow.Cells.Add(phoneCell);
                    newRow.Cells.Add(btnCell);

                    rows.Add(newRow);
                }
            

            
                if (auctionUserlastName != null)
                {
                    
                    foreach(User u in auctionUserlastName)
                    {

                        if (!u.UserID.Equals(auctionUser.UserID))
                        {
                            TableCell emailCell = new TableCell();
                            TableCell fullNameCell = new TableCell();
                            TableCell locCell = new TableCell();
                            TableCell phoneCell = new TableCell();
                            TableCell btnCell = new TableCell();

                            emailCell.Text = u.Email.ToString();
                            fullNameCell.Text = u.LastName.ToString() + ", " + u.FirstName.ToString();
                            locCell.Text = u.City.ToString() + ", " + u.State.ToString();
                            phoneCell.Text = u.Phone.ToString();
                            btnCell.Text = "<a class='ui button' href='SingleView.aspx?userId=" + u.UserID + "'>View</a>";


                            TableRow newRow = new TableRow();
                            newRow.Cells.Add(emailCell);
                            newRow.Cells.Add(fullNameCell);
                            newRow.Cells.Add(locCell);
                            newRow.Cells.Add(phoneCell);
                            newRow.Cells.Add(btnCell);

                            rows.Add(newRow);
                        }
                        
                    }

                    
                }
            

            return rows;
        }
        public User getSingleUser(string userId)
        {
            return userDaoImpl.getUserByNum(userId);
        }
    }
}