using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 rollno = Convert.ToInt32(Session["user"]);

        if (Session["user"] == null)
        {   
            //Response.Redirect("login.aspx");
        }

         

    }

}
