﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class attendance: System.Web.UI.Page
{
    String rollno;
    Int32 minimumpercentage = 75;
    protected void Page_Load(object sender, EventArgs e)
    {
        rollno = Convert.ToString(Session["user"]);
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
    }
  
    protected void get_attendance(object sender, EventArgs e)
    {       
        
        String sub1="", sub2="", sub3="", sub4="", sub5="";
        String sem = semlist.SelectedValue;
        String year = yearlist.SelectedValue;
        String table = "mca" + sem + "semattendance";
        tbl_attend.Rows.Clear();
        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_subjects = new OdbcCommand("Select * from " + table + " where  rollno ='0' ", con);
            OdbcCommand cmd = new OdbcCommand("Select * from " + table + " where  rollno ='" + rollno + "' and year='" + year + "' order by id asc ", con);
            con.Open();
            OdbcDataReader subject = get_subjects.ExecuteReader();
            OdbcDataReader rd = cmd.ExecuteReader();
            while (subject.Read())
            {
                sub1 = subject["s1"].ToString();
                sub2 = subject["s2"].ToString();
                sub3 = subject["s3"].ToString();
                sub4 = subject["s4"].ToString();
                sub5 = subject["s5"].ToString();

            }
            
            TableHeaderRow thr = new TableHeaderRow();
            TableHeaderCell thc = new TableHeaderCell();
            thc.Text = "Month";
            thr.Cells.Add(thc);

            TableHeaderCell thcs1 = new TableHeaderCell();
            thcs1.Text = sub1;
            thr.Cells.Add(thcs1);

            TableHeaderCell thcs2 = new TableHeaderCell();
            thcs2.Text = sub2;
            thr.Cells.Add(thcs2);

            TableHeaderCell thcs3 = new TableHeaderCell();
            thcs3.Text = sub3;
            thr.Cells.Add(thcs3);

            TableHeaderCell thcs4 = new TableHeaderCell();
            thcs4.Text = sub4;
            thr.Cells.Add(thcs4);

            TableHeaderCell thcs5 = new TableHeaderCell();
            thcs5.Text = sub5;
            thr.Cells.Add(thcs5);
            
            tbl_attend.Rows.Add(thr);
            
            while (rd.Read())
            {
                
                TableRow tr = new TableRow();
                TableHeaderCell month = new TableHeaderCell();
                month.Text = rd["month"].ToString();
                tr.Cells.Add(month);

                TableCell s1 = new TableCell();
                s1.Text = rd["s1"].ToString()+" %";
                if (Convert.ToInt32(rd["s1"]) < minimumpercentage) { s1.ForeColor = System.Drawing.Color.Red; }
                tr.Cells.Add(s1);

                TableCell s2 = new TableCell();
                s2.Text = rd["s2"].ToString()+" %";
                if (Convert.ToInt32(rd["s2"]) < minimumpercentage) { s2.ForeColor = System.Drawing.Color.Red; }
                tr.Cells.Add(s2);

                TableCell s3 = new TableCell();
                s3.Text = rd["s3"].ToString() + " %";
                if (Convert.ToInt32(rd["s3"]) < minimumpercentage) { s3.ForeColor = System.Drawing.Color.Red; }
                tr.Cells.Add(s3);

                TableCell s4 = new TableCell();
                s4.Text = rd["s4"].ToString() + " %";
                if (Convert.ToInt32(rd["s4"]) < minimumpercentage) { s4.ForeColor = System.Drawing.Color.Red; }
                tr.Cells.Add(s4);

                TableCell s5 = new TableCell();
                s5.Text = rd["s5"].ToString() + " %";
                if (Convert.ToInt32(rd["s5"]) < minimumpercentage) { s5.ForeColor = System.Drawing.Color.Red; }
                tr.Cells.Add(s5);

                tbl_attend.Rows.Add(tr);
            }
            con.Close();
                
        }
        catch (Exception ae)
        {
            
           //Response.Write("<script>alert('Data Not Found')</script>");
        }


    }
}