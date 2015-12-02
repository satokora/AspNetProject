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
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void SearchBuyer_Click(object sender, EventArgs e)
        {
            
        }

        protected void SearchItem_Click(object sender, EventArgs e)
        {

        }

        protected void GridViewItemsByItemId_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow row = GridViewUsers.SelectedRow;
            Response.Redirect("SingleView.aspx?userId=" + row.Cells[1].Text);
        }

    }
}