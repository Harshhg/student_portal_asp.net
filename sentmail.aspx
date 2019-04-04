<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sentmail.aspx.cs" Inherits="sentmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

<section id="content">
       
      <div class="inside"> 
         
         
          <div class="table-users"> 
   		<div class="header">Sent Mail</div>
 <div class ="scrollit">
   <table cellspacing="0">  
      <tr>
         <th><b>Picture</b> </th>
         <th><b>Name</b></th>
         <th><b>Email</b></th>
          <th><b>Subject</b></th>
         <th><b>Message</b></th>
      <form>
    <th><b>  <input type = 'submit' value = 'Trash' name = 'bt' ></b></th>
	 </tr>
	
			

      
<tr> 
         <td><img src="images/group.jpg"alt="" class="tbimg"/></td>
          <td><b> aa </b></td>
           <td>aa</td>
          <td><b>aa</b></td>
            <td> <a href = "readsentmail.php">View Mail </a></td> 
         <td><input type ="checkbox" name ="c1[]" value=""> </td>
       </tr>
     


 
 
       
   </table></div>
      
      
</div>
          </div>
   
      
  
    
 
</div>
		  
		  
		  
		  
		   
       
      </div>
    </section>











</asp:Content>

