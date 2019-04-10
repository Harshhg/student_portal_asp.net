using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class results : System.Web.UI.Page
{
    String rollno;
    int minimumpercentage = 40;
    protected void Page_Load(object sender, EventArgs e)
    {
        rollno = Convert.ToString(Session["user"]);
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
    }

    protected void get_results(object sender, EventArgs e)
    {
        int count=0;
        String sem = semlist.SelectedValue;
        String year = yearlist.SelectedValue;
        String table = "mca" + sem + "semresult";  //getting table name dynamically according to selected semester and year
        String[] sub_array = new String[5];
        int[] om;   //obtained marks for each subjects
        double[] per; //percentage array for each subject
        String[] status; //status for each subjects
        int total_om=0; //total obtained marks
        int total_marks=0;  //total marks
        double total_per=0; //total percentage
        String total_status="FAIL"; //final status
        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_subjects = new OdbcCommand("Select * from " + table + " where  rollno ='0' ", con);         //to get subjects list only
            OdbcCommand cmd = new OdbcCommand("Select * from " + table + " where  rollno ='" + rollno + "' and year='" + year + "' ", con);  //to get results by rollno
            con.Open();
            OdbcDataReader subject = get_subjects.ExecuteReader();
            OdbcDataReader rd = cmd.ExecuteReader();
            while (subject.Read()) //getting subject lists from database according to semester and year
            {
                sub_array[0] = subject["s1"].ToString();
                sub_array[1] = subject["s2"].ToString();
                sub_array[2] = subject["s3"].ToString();
                sub_array[3] = subject["s4"].ToString();
                sub_array[4] = subject["s5"].ToString();

            }
           
        while (rd.Read())
            {
                om = new int[5];
                per = new double[5];
                om[0] = Convert.ToInt32(rd["s1"]);  //fetching marks for each subjects
                om[1] = Convert.ToInt32(rd["s2"]);
                om[2] = Convert.ToInt32(rd["s3"]);
                om[3] = Convert.ToInt32(rd["s4"]);
                om[4] = Convert.ToInt32(rd["s5"]);
                int total = Convert.ToInt32(rd["total"]);   //getting total marks
                per[0] = (Convert.ToDouble(om[0]) / Convert.ToDouble(total)) * 100; //calculating percentage for each subjects
                per[1] = (Convert.ToDouble(om[1]) / Convert.ToDouble(total)) * 100;
                per[2] = (Convert.ToDouble(om[2]) / Convert.ToDouble(total)) * 100;
                per[3] = (Convert.ToDouble(om[3]) / Convert.ToDouble(total)) * 100;
                per[4] = (Convert.ToDouble(om[4]) / Convert.ToDouble(total)) * 100;

                total_om = om[0] + om[1] + om[2] + om[3] + om[4];  //calculating total obtained marks
                total_marks = total * 5;            //calculating total marks
                total_per = (Convert.ToDouble(total_om) / Convert.ToDouble(total_marks) ) *100;  //calculating total percentage
                if (total_per >= 40)        //getting final status
                    total_status = "PASS";

                status = new String[5];
                if (per[0] >= 40)       //getting status for each subjects
                    status[0] = "Pass";
                else
                    status[0] = "Fail";
                if (per[1] >= 40)
                    status[1] = "Pass";
                else
                    status[1] = "Fail";
                if (per[2] >= 40)
                    status[2] = "Pass";
                else
                    status[2] = "Fail";
                if (per[3] >= 40)
                    status[3] = "Pass";
                else
                    status[3] = "Fail";
                if (per[4] >= 40)
                    status[4] = "Pass";
                else
                    status[4] = "Fail";
                while (count < 5)       //for 5 subjects
                {
                    TableHeaderRow thr = new TableHeaderRow();
                    
                    TableHeaderCell sub = new TableHeaderCell();
                    sub.Text = sub_array[count];        //column for subject name
                    thr.Cells.Add(sub);

                    TableCell omc = new TableCell();
                    if (per[count] < minimumpercentage) { omc.ForeColor = System.Drawing.Color.Red; }
                    omc.Text = om[count].ToString();    // column for obtained marks of each subject
                    thr.Cells.Add(omc);

                    TableCell tmc = new TableCell();
                    if (per[count] < minimumpercentage) { tmc.ForeColor = System.Drawing.Color.Red; }
                    tmc.Text = total.ToString();    //column for total marks of each subject
                    thr.Cells.Add(tmc);

                    TableCell perc = new TableCell();
                    if (per[count] < minimumpercentage) { perc.ForeColor = System.Drawing.Color.Red; }
                    perc.Text = per[count].ToString()+" %";   //column for percentage of each subject
                    thr.Cells.Add(perc);

                    TableCell statusc = new TableCell();
                    if (per[count] < minimumpercentage) { statusc.ForeColor = System.Drawing.Color.Red; }
                    statusc.Text = status[count].ToString();    //column for status of each subject
                    thr.Cells.Add(statusc);
                    
                    tbl_results.Rows.Add(thr);      //adding 1 row for 1 subject

                    count++;
                }
                TableFooterRow tfr = new TableFooterRow();   //last row for TOTAL
                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "TOTAL";   //column for TOTAL
                tfr.Cells.Add(cell1);

                TableHeaderCell tomc = new TableHeaderCell();
                if (total_per < minimumpercentage) { tomc.ForeColor = System.Drawing.Color.Red; }
                tomc.Text = total_om.ToString();    //column for total obtained marks
                tfr.Cells.Add(tomc);

                TableHeaderCell ttmc = new TableHeaderCell();
                if (total_per < minimumpercentage) { ttmc.ForeColor = System.Drawing.Color.Red; }
                ttmc.Text = total_marks.ToString();  //column for final total marks
                tfr.Cells.Add(ttmc);

                TableHeaderCell tperc = new TableHeaderCell();
                if (total_per < minimumpercentage) { tperc.ForeColor = System.Drawing.Color.Red; }
                tperc.Text = total_per.ToString()+" %";   //column for total percentage
                tfr.Cells.Add(tperc);

                TableHeaderCell tstatusc = new TableHeaderCell();
                if (total_per < minimumpercentage) { tstatusc.ForeColor = System.Drawing.Color.Red; }
                tstatusc.Text = total_status;       //column for final status
                tfr.Cells.Add(tstatusc);

                tbl_results.Rows.Add(tfr);        
            
     
             
            }
        con.Close();
        }
        catch (Exception ae)
        {
          
          Response.Write("<script>alert('Please Try Later')</script>");
        }





    }




}