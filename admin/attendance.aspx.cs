using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class attendance: System.Web.UI.Page
{
    String rollno,sem="",year="",month="",table="dsad";
    String id = "s";
    String sub1 = "", sub2 = "", sub3 = "", sub4 = "", sub5 = "";
    Int32 i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            submit.Visible = false;
            roll.Visible = false;
            label.Visible = false;
            tbl_attend.Visible = false;
            rollno = Convert.ToString(Session["user"]);
            if (Session["user"] == null)
            {
                // Response.Redirect("login.aspx");
            }
        }
    }
  
    protected void fetch(object sender, EventArgs e)
    {

        sem =semlist.SelectedValue;
        year = yearlist.SelectedValue;
        month = monthlist.SelectedValue;
        String[] sub_array = new String[5];
        table = "mca" + sem + "semattendance";

        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_subjects = new OdbcCommand("Select * from " + table + " where  rollno ='0' ", con);
            //OdbcCommand cmd = new OdbcCommand("Select * from " + table + " where  rollno ='" + rollno + "' and year='" + year + "' ", con);
            con.Open();
            OdbcDataReader subject = get_subjects.ExecuteReader();
           // OdbcDataReader rd = cmd.ExecuteReader();
            while (subject.Read())
            {
                sub_array[0] = subject["s1"].ToString();
                sub_array[1] = subject["s2"].ToString();
                sub_array[2] = subject["s3"].ToString();
                sub_array[3] = subject["s4"].ToString();
                sub_array[4] = subject["s5"].ToString();
                

                //while (i < 5)
                //{
                //    TableRow thr = new TableRow();
                //    TableHeaderCell sub = new TableHeaderCell();
                //    sub.Text = sub_array[i];
                //    thr.Cells.Add(sub);

                    
                //    TableCell c2 = new TableCell();
                //    id=id+Convert.ToString(i);
                //    TextBox t1 = new TextBox();
                //    t1.ID = "s" + i;
                //    c2.Controls.Add(t1);
                //    thr.Cells.Add(c2);

                //    TableCell c3 = new TableCell();
                //    TextBox t2 = new TextBox();
                //    t2.ID = "t" + i;
                //    c3.Controls.Add(t2); 
                //    thr.Cells.Add(c3);

                //    tbl_attend.Rows.Add(thr);

                //    i++;
                //}

                 

            }
            s1.Text = sub_array[0];
            s2.Text = sub_array[1];
            s3.Text = sub_array[2];
            s4.Text = sub_array[3];
            s5.Text = sub_array[4];
            table1.Visible = false;
            tbl_attend.Visible = true;
            submit.Visible = true;
            roll.Visible = true;
            label.Visible = true;
            con.Close();
        }
        catch (Exception ae)
        {
            Response.Write(ae);
        }

    }



    protected void submit_attendance(object sender, EventArgs e)
    {
        String attendrollno = roll.Text;
        sem = semlist.SelectedValue;
        year = yearlist.SelectedValue;
        month = monthlist.SelectedValue;
        table = "mca" + sem + "semattendance";

        Double prs1 = Convert.ToDouble(ps1.Text);
        Double prs2 = Convert.ToDouble(ps2.Text);
        Double prs3 = Convert.ToDouble(ps3.Text);
        Double prs4 = Convert.ToDouble(ps4.Text);
        Double prs5 = Convert.ToDouble(ps5.Text);

        Double tts1 = Convert.ToDouble(ts1.Text);
        Double tts2 = Convert.ToDouble(ts2.Text);
        Double tts3 = Convert.ToDouble(ts3.Text);
        Double tts4 = Convert.ToDouble(ts4.Text);
        Double tts5 = Convert.ToDouble(ts5.Text);

        String ress1 = Convert.ToString(Math.Round((prs1 / tts1) * 100));
        String ress2 = Convert.ToString(Math.Round((prs2 / tts2) * 100));
        String ress3 = Convert.ToString(Math.Round((prs3 / tts3) * 100));
        String ress4 = Convert.ToString(Math.Round((prs4 / tts4) * 100));
        String ress5 = Convert.ToString(Math.Round((prs5 / tts5) * 100));
        

        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand insertattendance = new OdbcCommand("insert into " + table + "(month,rollno,year,s1,s2,s3,s4,s5)values('" + month + "','" + attendrollno + "','" + year + "','" + ress1 + "','" + ress2 + "','" + ress3 + "','" + ress4 + "','" + ress5 + "')", con);
            //OdbcCommand cmd = new OdbcCommand("Select * from " + table + " where  rollno ='" + rollno + "' and year='" + year + "' ", con);
            con.Open();
            insertattendance.ExecuteNonQuery();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Submitted!')", true);
            ps1.Text = "";
            ps2.Text = "";
            ps3.Text = "";
            ps4.Text = "";
            ps5.Text = "";
            ts1.Text = "";
            ts2.Text = "";
            ts3.Text = "";
            ts4.Text = "";
            ts5.Text = "";
            roll.Text = "";

        }
        catch (Exception ae)
        {
        }

    }










}