<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">



  	<section id="content">
      
      <div class="inside">
       <h2>Your <span>DashBoard </span>:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color:#006600">
	   
	   </span></h2><hr>          
        <ul class="list">
         <a href="attendance.aspx">
		  <li><img src="images/attendance.jpg" height="140" width="150">
            <blockquote>
             <h3>Attendance </h3>
                </blockquote>
          </li></a>
          <a href="examination.aspx">
           <li><img src="images/examination.jpg" height="140" width="150">
            <blockquote>
             <h3>Examinations</h3>
                </blockquote>
          </li></a>
          <a href="results.aspx">
 <li><img src="images/results.jpg" height="140" width="150">
            <blockquote>
             <h3 align="center">Results</h3>
                </blockquote>
          </li></a>



        </ul>
      
		
      </div>
 
     

   </section>

   </asp:Content>


<%-- Add content controls here --%>
