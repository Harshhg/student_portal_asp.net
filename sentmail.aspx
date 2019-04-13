<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sentmail.aspx.cs" Inherits="sentmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">






    <section id="content">
       
      <div class="inside"> 
         
         
          <div class="table-users"> 
   		<div class="header">Sent Mail</div>
 <div class ="scrollit">
  <asp:Table ID="tbl_sent" runat="server"   Width="100%" cssclass = "responstable" > 
  <asp:TableHeaderRow ID = "th1" runat="server">
  <asp:TableHeaderCell>Photo</asp:TableHeaderCell>
  <asp:TableHeaderCell>Name</asp:TableHeaderCell>
  <asp:TableHeaderCell>Email</asp:TableHeaderCell>
<asp:TableHeaderCell>Date</asp:TableHeaderCell>
<asp:TableHeaderCell>Subject</asp:TableHeaderCell>
<asp:TableHeaderCell>Message</asp:TableHeaderCell>
<asp:TableHeaderCell></asp:TableHeaderCell>

  </asp:TableHeaderRow>
 </asp:Table>
  
   <%--<table cellspacing="0">  
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
          <td><b> aaaaaa </b></td>
           <td>aaaaaaaa</td>
          <td>aaaaaaaaaaa</td>
            <td> <a href = "#abc" >View Mail </a></td> 
         <td><input type ="checkbox" name ="c1[]" value="" </td>
       </tr>
 </table> --%>
     
	</form> 
   </div>
      
      
</div>
          </div>
    </div>
		  
		
		  
		  
		   
     
    </section>

      
   </asp:Content>

<%-- Add content controls here --%>
