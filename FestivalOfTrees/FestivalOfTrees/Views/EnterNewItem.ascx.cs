using FestivalOfTrees.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FestivalOfTrees.Model;


namespace FestivalOfTrees
{
    public partial class EnterNewItem : System.Web.UI.UserControl
    {
        ItemController itemCtrl;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            EditItem.Visible = false;
            itemCtrl = new ItemController();

            if (!Page.IsPostBack)
            {
                if (Request.QueryString["itemId"] != null)
                {
                    AddItem.Visible = false;
                    EditItem.Visible = true;
                    Item editItem = itemCtrl.getItemByID(Request.QueryString["itemId"].ToString());

                    if (editItem != null)
                    {
                        DropDownList1.SelectedValue = editItem.CategoryID;
                        ItemName.Text = editItem.ItemName;
                        Description.Text = editItem.Description;
                        TxtValPrice.Text = editItem.ItemValue.ToString();
                        TxtMinBid.Text = editItem.MinBid.ToString();
                        TxtAngPrice.Text = editItem.AngelPrice.ToString();


                        //List<User> designers = itemCtrl.getDesigners(editItem.ItemID.ToString());

                        //foreach (ListItem li in DesignerList.Items)
                        //{
                        //    foreach (User d in designers)
                        //    {
                        //        if (d.Email.Equals(li.Value))
                        //        {
                        //            li.Selected = true;
                        //        }
                        //    }
                        //}
                    }
                }
            }
            else
            {

            }
            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemCtrl = new ItemController();
            itemCtrl.selectCategory(DropDownList1.SelectedValue);
        }

        protected void TxtValPrice_TextChanged(object sender, EventArgs e)
        {
            itemCtrl.selectCategory(DropDownList1.SelectedValue);
            TxtMinBid.Text = itemCtrl.calcMinBid(Convert.ToDouble(TxtValPrice.Text)).ToString();
            TxtAngPrice.Text = itemCtrl.calcAngelPrice(Convert.ToDouble(TxtValPrice.Text)).ToString();
        }


        
        //protected void multiselect_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string designerNames = "";
        //    foreach (ListItem li in multiselect.Items)
        //    {
        //        if (li.Selected)
        //        {
        //            if (designerNames.Equals(""))
        //            {
        //                designerNames += li.Text;
        //            }
        //            else
        //            {
        //                designerNames += ", " + li.Text;
        //            }
        //            selectedDesignerIDs.Add(li.Value);
        //        }
        //    }

        //    DonorName.Text = designerNames;
        //}

        protected void SearchDesigner_Click(object sender, EventArgs e)
        {

            //designerNames = "";
            //foreach (ListItem li in multiselect.Items)
            //{
            //    if (li.Selected)
            //    {
            //        if (designerNames.Equals(""))
            //        {
            //            designerNames += li.Text;
            //        }
            //        else
            //        {
            //            designerNames += ", " + li.Text;
            //        }
            //        selectedDesignerIDs.Add(li.Value);
            //    }
            //}

            //DonorName.Text = designerNames;
        }

        protected void DesignerList_DataBound(object sender, EventArgs e)
        {
            DesignerList.Items.Insert(0, new ListItem("==Select Designer==", ""));
        }

        protected void AddItem_Click(object sender, EventArgs e)
        {
            Item newItem = new Item
            {
                CategoryID = DropDownList1.SelectedValue,
                ItemName = ItemName.Text,
                Description = Description.Text,
                ItemValue = Convert.ToDouble(TxtValPrice.Text),
                MinBid = Convert.ToDouble(TxtMinBid.Text),
                AngelPrice = Convert.ToDouble(TxtAngPrice.Text)
            };

            int newItemId = itemCtrl.createItem(newItem);

            
            List<string> emailList = new List<string>();

            foreach (ListItem li in DesignerList.Items)
            {
                if (li.Selected)
                {
                    emailList.Add(li.Value);
                }
            }

            itemCtrl.addDonors(emailList, newItemId);

            Response.Redirect("SingleView.aspx?ItemId=" + newItemId);

        }

        protected void EditItem_Click(object sender, EventArgs e)
        {
            Item updateItem = new Item
            {
                CategoryID = DropDownList1.SelectedValue,
                ItemName = ItemName.Text,
                Description = Description.Text,
                ItemValue = Convert.ToDouble(TxtValPrice.Text),
                MinBid = Convert.ToDouble(TxtMinBid.Text),
                AngelPrice = Convert.ToDouble(TxtAngPrice.Text)
            };

            // int newItemId = itemCtrl.u .createItem(updateItem);
            int modifiedId = itemCtrl.updateItem(updateItem);

            List<string> emailList = new List<string>();

            foreach (ListItem li in DesignerList.Items)
            {
                if (li.Selected)
                {
                    emailList.Add(li.Value);
                }
            }

            itemCtrl.removeDonors(emailList, modifiedId);
            itemCtrl.addDonors(emailList, modifiedId);
            
            

            Response.Redirect("SingleView.aspx?ItemId=" + modifiedId);
        }
    }
}