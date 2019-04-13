using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
using System.IO;
public partial class publicposts : System.Web.UI.Page
{
    String rollno,filename="",sem="";
    int fileid;
    int view=0;
    protected void Page_Load(object sender, EventArgs e)
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
            OdbcCommand get_sem = new OdbcCommand("Select * from student_details where rollno = '"+rollno+"' ", con);
            con.Open();
            OdbcDataReader semrd  = get_sem.ExecuteReader();
            while (semrd.Read())
            {
                sem = semrd["semester"].ToString();
            }
            OdbcCommand get_posts = new OdbcCommand("Select * from publicposts where semester = '"+sem+"' order by ID desc", con);
            OdbcDataReader rd = get_posts.ExecuteReader();
            while (rd.Read())
            {
                view = Convert.ToInt32(rd["views"]);            //gets number of views of that file
                fileid = Convert.ToInt32(rd["id"]);
                TableRow tr = new TableRow();
                TableCell uby = new TableCell();
                uby.Text = rd["uploadedby"].ToString();
                tr.Cells.Add(uby);

                TableCell date = new TableCell();
                date.Text = rd["uploadeddate"].ToString();
                tr.Cells.Add(date);

                TableCell desc = new TableCell();   
                desc.Text = rd["description"].ToString();
                tr.Cells.Add(desc);

                TableCell fn = new TableCell();
                filename = rd["filename"].ToString();
                fn.Text = "<a href = '?fn="+filename+"&views="+view+"&fileid="+fileid+"'  >Download</a>";
                tr.Cells.Add(fn);

                TableCell views = new TableCell();
                views.Text = rd["views"].ToString();
                tr.Cells.Add(views);

                tbl_posts.Rows.Add(tr);
            }
            if (Request.QueryString["fn"] != null)
            {
               filename = Request.QueryString["fn"];
                string filePath = Server.MapPath("~")+"\\publicposts\\"+filename;
                
                FileInfo file = new FileInfo(filePath);
                 
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "text/plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                     
                view = Convert.ToInt32(Request.QueryString["views"]);
                fileid = Convert.ToInt32(Request.QueryString["fileid"]);

                view++;
                OdbcCommand increment_views = new OdbcCommand("update publicposts set views = " + view + " where id=" + fileid + "", con);
                increment_views.ExecuteNonQuery();
                Response.Redirect("publicposts.aspx");
                   
                }
                else
                {
                    Response.Write("<script>alert('Please Try Later..')</script>");
                }


                con.Close();
            }

        }

        catch (Exception ae)
        {
            Response.Write(ae);
        }
    
    
    
    
    
    
    
    
    
    
    
    }
}