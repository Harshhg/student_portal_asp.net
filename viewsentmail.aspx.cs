using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class readmail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            Int32 id = Convert.ToInt32(Request.QueryString["idofemail"]);
            
            OdbcCommand getemail = new OdbcCommand("Select * from tbl_emails where id  = "+id+" ", con);         //to get emails 
            con.Open();
            OdbcDataReader email = getemail.ExecuteReader();
            while (email.Read())
            {

                sub.Text = email["subject"].ToString();
                name.Text = email["receiver"].ToString();
                date.Text = email["emaildate"].ToString()+ " [" +email["emailtime"].ToString()+"]";
                message.Text = email["message"].ToString();
                

            }
            con.Close();
        }
        catch (Exception ae)
        {
            Response.Write(ae);
        }

    }

    protected void goback(object sender, EventArgs e)
    {
        Response.Redirect("sentmail.aspx");
    }

}