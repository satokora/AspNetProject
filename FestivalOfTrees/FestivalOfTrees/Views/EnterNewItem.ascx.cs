using FestivalOfTrees.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace FestivalOfTrees
{
    public partial class EnterNewItem : System.Web.UI.UserControl
    {
        ItemController itemCtrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            itemCtrl = new ItemController();
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

        //[System.Web.Services.WebMethod]
        //[System.Web.Script.Services.ScriptMethod]
        //public string[] GetCompletionList(string prefixText, int count)
        //{
        //    return null;
        //}
    }
}