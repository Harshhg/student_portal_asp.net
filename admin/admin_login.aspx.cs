﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Xml.Linq;
using System.Data;
using System.Linq;
using System.Configuration; 
public partial class login : System.Web.UI.Page
{
    OdbcCommand cmd = new OdbcCommand();
    OdbcConnection con = new OdbcConnection();
    OdbcDataAdapter sda = new OdbcDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        Session.Abandon();
        //con.Open();
        //OdbcDataAdapter adap = new OdbcDataAdapter("Select * from student1",con);
        //DataSet ds = new DataSet();
        //adap.Fill(ds, "login");

    }

protected void logincheck(object sender, EventArgs e)
    {
            String uname = Convert.ToString(Request.Form["email"]);
            String password = Convert.ToString(Request.Form["pass"]);
        try
            {
                String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
                OdbcConnection con = new OdbcConnection(strcon);
                OdbcCommand cmd = new OdbcCommand("Select * from admin_login where  email = '" + uname + "' and password  = '" + password + "'", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                OdbcDataReader rd = cmd.ExecuteReader();
                 

                    if (rd.HasRows)
                    {
                        Session["admin"] = rd["id"];
                        Response.Redirect("~/admin/Default.aspx");
                    }
                    else
                    {
                        
                        alert.ForeColor = System.Drawing.Color.Red;
                        alert.Text = "Invalid Username or Password";
                    }
                



            }
            catch (Exception ae)
            {
                Response.Write(ae);
            }

        
    
        }


    

}