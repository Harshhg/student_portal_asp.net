using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
             
    }
    protected void register(object sender, EventArgs e)
    {
        String userphoto = "";
        String photoname = "";
        String name = Convert.ToString(Request.Form["name"]);
        String email = Convert.ToString(Request.Form["email"]);
        String pass = Convert.ToString(Request.Form["password"]);
        String contact = Convert.ToString(Request.Form["contact"]);
        String dept = Convert.ToString(Request.Form["dept"]);
        String sem = Convert.ToString(Request.Form["sem"]);
        String rollno = Convert.ToString(Request.Form["roll"]);
        if (photo.HasFile)
        {
             
            userphoto = System.IO.Path.GetFileName(photo.FileName);
            photoname = email + userphoto;
            photo.SaveAs(Server.MapPath("./userimage/") + photoname);
             
        }
        else
        {
            Response.Write("please select photo");
        }

        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand checkid = new OdbcCommand("Select * from student_details where email='" + email + "' ", con);
            con.Open();
            OdbcDataReader rd = checkid.ExecuteReader();
            if (rd.HasRows)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Already in Use')", true);
            }
            else
            {
                String id = "";
                OdbcCommand cmd = new OdbcCommand("INSERT INTO student_details(rollno,name,email,department,semester,contact,photo,verified)values('"+rollno+"','" + name + "','" + email + "', '" + dept + "', '" + sem + "', '" + contact + "','" + photoname + "', 0)", con);
                cmd.ExecuteNonQuery();
                OdbcCommand getid = new OdbcCommand("Select * from student_details where email='" + email + "'", con);
                OdbcDataReader rdgetid = getid.ExecuteReader();
                while (rdgetid.Read())
                {
                    id = Convert.ToString(rdgetid["id"]);
                   
                }
                OdbcCommand cmd1 = new OdbcCommand("INSERT INTO login(id,rollno,email,password)values('" + id + "', '"+rollno+"','" + email + "', '" + pass + "')", con);
                cmd1.ExecuteNonQuery();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfully Registered !')", true);
               }
        }
        catch (Exception ae)
        {
            Response.Write(ae);
        }





    }
}