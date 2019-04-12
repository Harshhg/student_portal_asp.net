<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="~/admin/publicposts.aspx.cs" Inherits="publicposts" %>


<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
<head>
<style>
.myButton {
	-moz-box-shadow:inset 0px -1px 0px 0px #97c4fe;
	-webkit-box-shadow:inset 0px -1px 0px 0px #97c4fe;
	box-shadow:inset 0px -1px 0px 0px #97c4fe;
	background:-webkit-gradient(linear, left top, left bottom, color-stop(0.05, #fafafa), color-stop(1, #daeff1));
	background:-moz-linear-gradient(top, #fafafa 5%, #daeff1 100%);
	background:-webkit-linear-gradient(top, #fafafa 5%, #daeff1 100%);
	background:-o-linear-gradient(top, #fafafa 5%, #daeff1 100%);
	background:-ms-linear-gradient(top, #fafafa 5%, #daeff1 100%);
	background:linear-gradient(to bottom, #fafafa 5%, #daeff1 100%);
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#fafafa', endColorstr='#daeff1',GradientType=0);
	background-color:#fafafa;
	-moz-border-radius:6px;
	-webkit-border-radius:6px;
	border-radius:6px;
	border:1px solid #4087eb;
	display:inline-block;
	cursor:pointer;
	color:#ad9bad;
	font-family:Georgia;
	font-size:16px;
	font-weight:bold;
	padding:4px 12px;
	text-decoration:none;
	text-shadow:0px 1px 0px #1570cd;
}
.myButton:hover {
	background:-webkit-gradient(linear, left top, left bottom, color-stop(0.05, #daeff1), color-stop(1, #fafafa));
	background:-moz-linear-gradient(top, #daeff1 5%, #fafafa 100%);
	background:-webkit-linear-gradient(top, #daeff1 5%, #fafafa 100%);
	background:-o-linear-gradient(top, #daeff1 5%, #fafafa 100%);
	background:-ms-linear-gradient(top, #daeff1 5%, #fafafa 100%);
	background:linear-gradient(to bottom, #daeff1 5%, #fafafa 100%);
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#daeff1', endColorstr='#fafafa',GradientType=0);
	background-color:#daeff1;
}
.myButton:active {
	position:relative;
	top:1px;
}
 

</style>
</head> 
<section id="content">
       
      <div class="inside"> 
         
          
   
    
            
          




 
  	  <div class="table-users"> 
   		<div class="header">Public Posts   <div style="float:right"> <a href ="uploadpost.aspx" class="myButton"  >Upload</a> </div></div>
 <div class ="scrollit1">
  <asp:Table ID="tbl_posts" runat="server"   Width="100%" cssclass = "responstable" > 
  <asp:TableHeaderRow ID = "th1" runat="server">
  <asp:TableHeaderCell>Uploaded By</asp:TableHeaderCell>
  <asp:TableHeaderCell>Date</asp:TableHeaderCell>
  <asp:TableHeaderCell>Description</asp:TableHeaderCell>
<asp:TableHeaderCell>FileName</asp:TableHeaderCell>
<asp:TableHeaderCell>Views</asp:TableHeaderCell>

  </asp:TableHeaderRow> 


 </asp:Table>
  
  </div>
  </div>
  

  </section>
  
   </asp:Content>


<%-- Add content controls here --%>
