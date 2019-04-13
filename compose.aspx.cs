using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class compose : System.Web.UI.Page
{
    String rollno = "";
    String senderid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        rollno = Convert.ToString(Session["user"]);
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }

    }

    protected void send_mail(object sender, EventArgs e)
    {
        String receiver = Convert.ToString(Request.Form["rmail"]);
        String subject = Convert.ToString(Request.Form["subject"]);
        String message = Convert.ToString(Request.Form["message"]);
        String date = DateTime.Now.ToString("dd-MM-yyyy");
        String time = DateTime.Now.ToString("hh:mm:ss");


        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_emailid = new OdbcCommand("Select * from student_details where rollno ='" + rollno + "' ", con);         //to get our email id...
            con.Open();
            OdbcDataReader myemail = get_emailid.ExecuteReader();
            while (myemail.Read())
            {
                senderid = myemail["email"].ToString();
            }
            
            OdbcCommand sendmail = new OdbcCommand("INSERT INTO tbl_emails(sender,receiver,subject,message,emaildate,emailtime,group_dept,group_sem,delete_inbox,delete_sent) values('"+senderid+"','"+receiver+"','"+subject+"','"+message+"','"+date+"','"+time+"','0','0','0','0')", con);         //to get emails 
            sendmail.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Sent!')", true);
        }
        catch (Exception ae)
        {
            Response.Write(ae);
        }

    }

}