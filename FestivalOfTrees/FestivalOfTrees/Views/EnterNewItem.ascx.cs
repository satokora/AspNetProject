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
        private int itemID;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                EditItem.Visible = false;
                itemCtrl = new ItemController();

                string tempId = Request.QueryString["itemId"].ToString();
                int firstDigit = tempId.IndexOfAny("0123456789".ToCharArray());
                tempId = tempId.Substring(firstDigit);

                itemID = Convert.ToInt32(tempId);

                if (!Page.IsPostBack)
                {
                    if (Request.QueryString["itemId"] != null)
                    {
                        AddItem.Visible = false;
                        EditItem.Visible = true;
                        itemCtrl = new ItemController();
                        Item editItem = itemCtrl.getItemByID(itemID.ToString());

                        if (editItem != null)
                        {
                            DropDownList1.SelectedValue = editItem.CategoryID;
                            ItemName.Text = editItem.ItemName;
                        DescriptionTxtBox.Text = editItem.Description;
                            TxtValPrice.Text = editItem.ItemValue.ToString();
                            TxtMinBid.Text = editItem.MinBid.ToString();
                            TxtAngPrice.Text = editItem.AngelPrice.ToString();

                            

                        }
                    }
                }
                //else
                //{

                //}
            }catch(Exception ex)
            {
                Console.Write(ex.Message);
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


                if (Request.QueryString["itemId"] != null)
                {
                 

                        List<User> designers = itemCtrl.getDesigners(itemID.ToString());

                        if (designers != null)
                        {
                            foreach (User des in designers)
                            {
                                foreach (ListItem item in DesignerList.Items)
                                {
                                    if (des.Email.Equals(item.Value))
                                    {
                                        item.Selected = true;
                                    }
                                }
                            }


                        }

                    }

        }

        protected void AddItem_Click(object sender, EventArgs e)
        {
            Item newItem = new Item
            {
                CategoryID = DropDownList1.SelectedValue,
                ItemName = ItemName.Text,
                Description = DescriptionTxtBox.Text,
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
            Item updateItem = new Item()
            {
                ItemID = itemID,
                CategoryID = DropDownList1.SelectedValue,
                ItemName = ItemName.Text,
                Description = DescriptionTxtBox.Text,
                ItemValue = Math.Round(Convert.ToDouble(TxtValPrice.Text),2,MidpointRounding.AwayFromZero) ,
                MinBid = Math.Round(Convert.ToDouble(TxtMinBid.Text), 2, MidpointRounding.AwayFromZero),
                AngelPrice = Math.Round(Convert.ToDouble(TxtAngPrice.Text), 2, MidpointRounding.AwayFromZero)
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

            if(emailList.Count > 0)
            {
                if(itemCtrl.getDesigners(modifiedId.ToString()).Count > 0)
                {
                    itemCtrl.removeDonors(modifiedId);
                }

                    itemCtrl.addDonors(emailList, modifiedId);

                
            }

 

            Response.Redirect("SingleView.aspx?ItemId=" + modifiedId);
        }
    }
}