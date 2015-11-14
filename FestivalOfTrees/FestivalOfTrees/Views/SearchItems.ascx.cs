using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees.Views
{
    public class NewgvColumnField : DataControlField
    {

        protected override System.Web.UI.WebControls.DataControlField CreateField()
        {
            return new NewgvColumnField();

        }

        public DataControlField InsertNewColumn()
        {
            return CreateField();

        }
    }
    public partial class SearchItems : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //NewgvColumnField ngcf = new NewgvColumnField();
            //DataControlField dcf = ngcf.InsertNewColumn();
            //dcf.HeaderText = "THIS IS THE NEW COLUMN";
            //dcf.Visible = true;
            //dcf.ShowHeader = true;

            //GridViewItemsByItemId.Columns.Insert(0, dcf);
            //ItemsWithCatNameTableAdapters.CategoryItemsTableAdapter itemTableAdaptor = new ItemsWithCatNameTableAdapters.CategoryItemsTableAdapter();
            //GridViewItemsByItemId.DataSource = itemTableAdaptor.GetData();
            
            //GridViewItemsByItemId.DataBind();
            //BoundField test = new BoundField();
            //test.DataField = "New DATAfield Name";
            //test.HeaderText = "New Header";
            //GridViewItemsByItemId.Columns.Add(test);
        }

        protected void BtnGetItemsByItemId_Click(object sender, EventArgs e)
        {
            //ItemsTableAdapters.CategoryItemsTableAdapter itemTableAdaptor = new ItemsTableAdapters.CategoryItemsTableAdapter();
            //GridViewItemsByItemId.DataSource = itemTableAdaptor.GetDataByKey("%" + ItemIDBox.Text + "%");
            //GridViewItemsByItemId.DataBind();
        }

    }
}