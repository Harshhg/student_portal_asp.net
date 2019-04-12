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
    String rollno,sem="",year="",month="",table="";
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
         
        String[] sub_array = new String[5];
        table = "mca" + sem + "semresult";

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



    protected void submit_result(object sender, EventArgs e)
    {
        String resultrollno = roll.Text;
        sem = semlist.SelectedValue;
        year = yearlist.SelectedValue;
        
        table = "mca" + sem + "semresult";

        Int32 oms1 = Convert.ToInt32(ps1.Text);
        Int32 oms2 = Convert.ToInt32(ps2.Text);
        Int32 oms3 = Convert.ToInt32(ps3.Text);
        Int32 oms4 = Convert.ToInt32(ps4.Text);
        Int32 oms5 = Convert.ToInt32(ps5.Text);
        Int32 total_om = oms1 + oms2 + oms3 + oms4 + oms5;

        Int32 tts1 = Convert.ToInt32(ts1.Text);
        Int32 tts2 = Convert.ToInt32(ts2.Text);
        Int32 tts3 = Convert.ToInt32(ts3.Text);
        Int32 tts4 = Convert.ToInt32(ts4.Text);
        Int32 tts5 = Convert.ToInt32(ts5.Text);
        Int32 total_marks = tts1 + tts2 + tts3 + tts4 + tts5;
        
        Double per = (Convert.ToDouble(total_om) / Convert.ToDouble(total_marks) ) *100;  
        
        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand insertresult = new OdbcCommand("insert into " + table + "(rollno,year,s1,s2,s3,s4,s5,total)values('" + resultrollno + "','" + year + "','" + oms1 + "','" + oms2 + "','" + oms3 + "','" + oms4 + "','" + oms5 + "', '"+tts1+"')", con);
            OdbcCommand insertleaderboard = new OdbcCommand("insert into leaderboard(rollno, semester, year, percentage) values('"+resultrollno+"','"+sem+"', '"+year+"','"+per+"')", con);
            con.Open();
            insertresult.ExecuteNonQuery();
            insertleaderboard.ExecuteNonQuery();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Result Submitted!')", true);
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
            Response.Write(ae);
        }

    }










}