using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/*
    For Use Case 4: Search User Info

*/
namespace FestivalOfTrees.Controller
{
    public class SearchUserController
    {
        public List<TableRow> getUserRows(string seachKey)
        {
            // this method is created by Satoko in order to check ui design.  Delete the following codes
            // when you implement data retrieval from user table.
            List<TableRow> rows = new List<TableRow>();

            TableHeaderRow itemHeader = new TableHeaderRow();
            string[] headerStrs = { "Name", "Phone", "Email", "Location", "" };
            foreach (string headerTitle in headerStrs)
            {
                TableHeaderCell titleCell = new TableHeaderCell();
                titleCell.Text = headerTitle;
                itemHeader.Cells.Add(titleCell);
            }

            rows.Add(itemHeader);

           
                
                TableCell nameCell = new TableCell();
                TableCell phoneCell = new TableCell();
                TableCell emailCell = new TableCell();
                TableCell locCell = new TableCell();
                TableCell btnCell = new TableCell();

                
                nameCell.Text = "Kora, Satoko";
                phoneCell.Text = "(309)310-3740";
                emailCell.Text = "satkora@aol.com";
                locCell.Text = "Normal,IL";
                btnCell.Text = "<a href='SingleView.aspx?userId=1101' class='ui button'>View</a>";


                TableRow newRow = new TableRow();
                newRow.Cells.Add(nameCell);
                newRow.Cells.Add(phoneCell);
                newRow.Cells.Add(emailCell);
                newRow.Cells.Add(locCell);
                newRow.Cells.Add(btnCell);

            rows.Add(newRow);
            

            return rows;
        }
    }
}