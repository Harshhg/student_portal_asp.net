<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="select_attendance.aspx.cs" Inherits="select_attendance" %>



<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

<section id="content">
       
      <div class="inside"> 
         
        
          <div class="table-users">
   		<div class="header">Select Semester</div>
                
  
</div>
 
  <ul class="listcompose"><br> <br>
     <div class="field">
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
              <label>Select Semester :</label>
              
               <select name ="semester">
                  <option value ="1">I</option>
                  <option value ="2">II</option>
                  <option value ="3">III</option>
                  <option value ="4">IV</option>
                  <option value ="5">V</option>
                  <option value ="6">VI</option>
              </select>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
              <label>Select Year:</label>
             <select name ="Year">
                <option value ="I">2015</option>
			    <option value ="II">2016</option>
			    <option value ="III">2017</option>
			    <option value ="IV">2018</option>
			    <option value ="V">2019</option>
			    <option value ="VI">2020</option>
          </select>
            </div>
            </ul>
      
		  
		  
		  
		  
		   
       
      </div>
    </section>



</asp:Content>










<%-- Add content controls here --%>

