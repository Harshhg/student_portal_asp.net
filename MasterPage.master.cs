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
            Response.Redirect("login.aspx");
        }

        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand cmd = new OdbcCommand("Select * from student_details where  rollno = '" + rollno + "' ", con);

            con.Open();
            OdbcDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                name.Text = rd["name"].ToString();
                email.Text = rd["email"].ToString();
                hidden.Text = rd["photo"].ToString();
                sem.Text = rd["semester"].ToString();
                dept.Text = rd["department"].ToString();
                roll.Text = rd["rollno"].ToString();
            }



        }
        catch (Exception ae)
        {
            Response.Write(ae);
        }

    }

}
