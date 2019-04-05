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
        String sub1 = "", sub2 = "", sub3 = "", sub4 = "", sub5 = "";
        String sem = semlist.SelectedValue;
        String year = yearlist.SelectedValue;
        String table = "mca" + sem + "semresult";
        String[] sub_array = new String[5];
        int[] om;
        double[] per;
        String[] status;
        int total_om=0;
        int total_marks=0;
        double total_per=0;
        String total_status="FAIL";
        try
        {
            String strcon = System.Configuration.ConfigurationManager.ConnectionStrings["studentdbconnectionstring"].ConnectionString.ToString();
            OdbcConnection con = new OdbcConnection(strcon);
            OdbcCommand get_subjects = new OdbcCommand("Select * from " + table + " where  rollno ='0' ", con);
            OdbcCommand cmd = new OdbcCommand("Select * from " + table + " where  rollno ='" + rollno + "' and year='" + year + "' ", con);
            con.Open();
            OdbcDataReader subject = get_subjects.ExecuteReader();
            OdbcDataReader rd = cmd.ExecuteReader();
            while (subject.Read())
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
                om[0] = Convert.ToInt32(rd["s1"]);
                om[1] = Convert.ToInt32(rd["s2"]);
                om[2] = Convert.ToInt32(rd["s3"]);
                om[3] = Convert.ToInt32(rd["s4"]);
                om[4] = Convert.ToInt32(rd["s5"]);
                int total = Convert.ToInt32(rd["total"]);
                per[0] = (Convert.ToDouble(om[0]) / Convert.ToDouble(total)) * 100;
                per[1] = (Convert.ToDouble(om[1]) / Convert.ToDouble(total)) * 100;
                per[2] = (Convert.ToDouble(om[2]) / Convert.ToDouble(total)) * 100;
                per[3] = (Convert.ToDouble(om[3]) / Convert.ToDouble(total)) * 100;
                per[4] = (Convert.ToDouble(om[4]) / Convert.ToDouble(total)) * 100;

                total_om = om[0] + om[1] + om[2] + om[3] + om[4];
                total_marks = total * 5;
                total_per = (Convert.ToDouble(total_om) / Convert.ToDouble(total_marks) ) *100;
                if (total_per >= 40)
                    total_status = "PASS";

                status = new String[5];
                if (per[0] >= 40)
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
                while (count < 5)
                {
                    TableHeaderRow thr = new TableHeaderRow();
                    TableHeaderCell sub = new TableHeaderCell();
                    sub.Text = sub_array[count];
                    thr.Cells.Add(sub);

                    TableCell omc = new TableCell();
                    omc.Text = om[count].ToString();
                    thr.Cells.Add(omc);

                    TableCell tmc = new TableCell();
                    tmc.Text = total.ToString();
                    thr.Cells.Add(tmc);

                    TableCell perc = new TableCell();
                    perc.Text = per[count].ToString()+" %";
                    thr.Cells.Add(perc);

                    TableCell statusc = new TableCell();
                    statusc.Text = status[count].ToString();
                    thr.Cells.Add(statusc);

                    tbl_results.Rows.Add(thr);

                    count++;
                }
                TableFooterRow tfr = new TableFooterRow();
                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "TOTAL";
                tfr.Cells.Add(cell1);

                TableHeaderCell tomc = new TableHeaderCell();
                tomc.Text = total_om.ToString();
                tfr.Cells.Add(tomc);

                TableHeaderCell ttmc = new TableHeaderCell();
                ttmc.Text = total_marks.ToString();
                tfr.Cells.Add(ttmc);

                TableHeaderCell tperc = new TableHeaderCell();
                tperc.Text = total_per.ToString()+" %";
                tfr.Cells.Add(tperc);

                TableHeaderCell tstatusc = new TableHeaderCell();
                tstatusc.Text = total_status;
                tfr.Cells.Add(tstatusc);

                tbl_results.Rows.Add(tfr);        
            
     
             
            }

        }
        catch (Exception ae)
        {
            Response.Write(ae);
            //Response.Write("<script>alert('Data Not Found')</script>");
        }





    }




}