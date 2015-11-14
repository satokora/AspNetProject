using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FestivalOfTrees
{
    public partial class BidSheets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Set the appropriate ContentType.
            Response.ContentType = "Application/pdf";
            //Get the physical path to the file.
            string savePath = Server.MapPath("~\\PDF\\Filled.pdf");
            //Write the file directly to the HTTP content output stream.
            Response.WriteFile(savePath);
            Response.End();
        }
    }
}