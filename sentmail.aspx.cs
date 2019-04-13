using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class sentmail : System.Web.UI.Page
{
    String idofemail = "";
    String rollno = "";
    String myemailid = "";
    String receiverid = "";
    String receivername = "h";
    String receiverphoto = "";
    String receiverdept = "";
    String receiversem = "";
    String subject = "";
    String message = "";
    String date = "";
    String time = "";

    public void Page_Load(object sender, EventArgs e)
    {
        rollno = Convert.ToString(Session["user"]);
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }


        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_emailid = new OdbcCommand("Select * from student_details where rollno ='" + rollno + "' ", con);         //to get our email id...
            con.Open();
            OdbcDataReader myemail = get_emailid.ExecuteReader();
            while (myemail.Read()) //getting subject lists from database according to semester and year
            {
                myemailid = myemail["email"].ToString();
            }
            
            OdbcCommand get_emails = new OdbcCommand("Select * from tbl_emails where sender ='" + myemailid + "' and delete_sent = '0' order by ID desc", con);         //to get emails 
            OdbcDataReader mails = get_emails.ExecuteReader();
            while (mails.Read())
            {
                receiverid = mails["receiver"].ToString();  //fetch the receiver email id...
                subject = mails["subject"].ToString();
                message = mails["message"].ToString();
                date = mails["emaildate"].ToString();
                time = mails["emailtime"].ToString();

                get_receiver_details(receiverid);  //get all the sender details


                TableRow row = new TableRow();

                TableCell photo = new TableCell();
                Image img = new Image();
                String imgurl = "userimage/";
                img.CssClass = "tbimg";
                img.ImageUrl = imgurl + receiverphoto;
                photo.Controls.Add(img);
                row.Cells.Add(photo);

                TableCell name = new TableCell();
                name.Text = receivername;
                row.Cells.Add(name);

                TableCell email = new TableCell();
                email.Text = receiverid + "<br>(" + receiverdept + "-" + receiversem + ")";
                row.Cells.Add(email);

                TableCell dateandtime = new TableCell();
                dateandtime.Text = date + "<br>(" + time + ")";
                row.Cells.Add(dateandtime);

                TableCell sub = new TableCell();
                sub.Text = subject;
                row.Cells.Add(sub);

                TableCell msg = new TableCell();
                idofemail = mails["ID"].ToString();
                msg.Text = "<a href ='?idofemail=" + idofemail + "'>View Mail</a>";
                row.Cells.Add(msg);

                TableCell trash = new TableCell();
                trash.Text = "<a href ='?trashid=" + idofemail + "'><img style='height:20px;width:20px' src='images/trash.png'/></a>";
                row.Cells.Add(trash);

                tbl_sent.Rows.Add(row);

            }

            if (Request.QueryString["idofemail"] != null)
            {
                Response.Redirect("viewsentmail.aspx?idofemail=" + Request.QueryString["idofemail"]);
            }
            if (Request.QueryString["trashid"] != null)
            {
                Int32 trashid = Convert.ToInt32(Request.QueryString["trashid"]);
                OdbcCommand delete = new OdbcCommand("Update tbl_emails set delete_sent = '1' where ID=" + trashid + " ", con);  //Setting delete_inbox to 1 so that email would not show in inbox
                delete.ExecuteNonQuery();
                con.Close();
                Response.Redirect("sentmail.aspx");
            }



            con.Close();
        }


        catch (Exception ae)
        {
            Response.Write(ae);
        }

    }

    public void get_receiver_details(String receiveremailid)
    {
        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_receiverdetails = new OdbcCommand("Select * from student_details where email ='" + receiveremailid + "' ", con);         //to get our email id...
            con.Open();
            OdbcDataReader receiverdetails = get_receiverdetails.ExecuteReader();
            while (receiverdetails.Read()) //getting subject lists from database according to semester and year
            {
                receivername = receiverdetails["name"].ToString();
                receiverdept = receiverdetails["department"].ToString();
                receiversem = receiverdetails["semester"].ToString();
                receiverphoto = receiverdetails["photo"].ToString();
            }
            con.Close();
        }
        catch (Exception ae)
        {
            Response.Write(ae);
        }

    }



}