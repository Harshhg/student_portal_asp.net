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
    String rollno = "",name,sem;
    protected void Page_Load(object sender, EventArgs e)
    {
        rollno = Convert.ToString(Session["user"]);
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
    }





    protected void b1_Click(object sender, EventArgs e)
    {
        String userdoc = "";
        String docname = "";
        String desc = Convert.ToString(Request.Form["desc"]);
        String date= DateTime.Now.ToString("dd-MM-yyyy");
        String h = DateTime.Now.ToString("hh");
        String m = DateTime.Now.ToString("mm");
        String s = DateTime.Now.ToString("ss");
      
        if (document.HasFile)
        {

            userdoc = System.IO.Path.GetFileName(document.FileName);
            docname = date+"_"+h+m+s+"_"+userdoc;
            document.SaveAs(Server.MapPath("./publicposts/") + docname);
        }
        else
        {
            Response.Write("please select document");
        }


        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_name = new OdbcCommand("Select * from student_details where  rollno ='"+rollno+"' ", con);
            con.Open();
            OdbcDataReader namerd = get_name.ExecuteReader();
            while (namerd.Read())
            {
                name = namerd["name"].ToString();
                sem = namerd["semester"].ToString();
            }

            OdbcCommand it = new OdbcCommand("INSERT INTO publicposts (uploadedby,uploadeddate,description,filename,views,semester) VALUES ('" + name + "', '" + date + "','" + desc + "','" + docname + "',0,'" + sem + "') ", con);

            
            it.ExecuteNonQuery();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Uploaded Successfully')", true);
            con.Close();
        }
        catch (Exception ae)
        {
            Response.Write(ae);
        }









    }
}