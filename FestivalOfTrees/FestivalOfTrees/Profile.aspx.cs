using FestivalOfTrees.Controller;
using FestivalOfTrees.Model;
using FestivalOfTrees.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"].Equals("admin"))
            {
                UserRequest.Visible = true;
            }

            if (Session["Name"] != null)
            {
                UserDao dao = new UserDaoImpl();

                User u = dao.getUserByEmail(Session["Name"].ToString());
                LblUserName.Text = u.FirstName + "!";
            }
            
        }

        protected void BtnGoAuction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auction.aspx");
            // Implement logic to select an auction and retrieve corresponding dataset
        }

        //protected void AuctionGridView_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    GridViewRow row = AuctionGridView.Rows[AuctionGridView.SelectedIndex];
        //    Session["Auction"] = row.Cells[3].Text;
        //    Response.Redirect("Auction.aspx");
        //}

        protected void SelectAuctionBtn_Click(object sender, ListViewCommandEventArgs e)
        {
            Session["Auction"] = e.CommandArgument;
            Response.Redirect("Auction.aspx");
        }

        protected void BtnAccept_Click(object sender, EventArgs e)
        {
            //temp
            UserCtrl userCtrl = new UserCtrl();
            List<int> idList = new List<int>();
            foreach (GridViewRow row in UserRequestGrid.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("CheckBox1");
                if (cb != null && cb.Checked)
                {
                    idList.Add(Convert.ToInt32(row.Cells[5].Text));
                }
            }

            userCtrl.approveRequest(idList);
            UserRequestGrid.DataBind();
        }
    }
}