<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="~/results.aspx.cs" Inherits="results" %>


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
         
           <ul class="listcompose"> 
     <div class="field">
     
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
              <label>Select Semester :</label>
             <asp:DropDownList ID="semlist" runat="server">
                <asp:ListItem Value="1" Text="I"></asp:ListItem>
                <asp:ListItem Value="2" Text="II"></asp:ListItem>  
                <asp:ListItem Value="3" Text="III"></asp:ListItem>
                 <asp:ListItem Value="4" Text="IV"></asp:ListItem>
                <asp:ListItem Value="5" Text="V"></asp:ListItem>
                <asp:ListItem Value="6" Text="VI"></asp:ListItem>
            </asp:DropDownList>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
              <label>Select Year:</label>
             <asp:DropDownList ID="yearlist" runat="server">
                <asp:ListItem Value="2015" Text="2015"></asp:ListItem>
                <asp:ListItem Value="2016" Text="2016"></asp:ListItem>  
                <asp:ListItem Value="2017" Text="2017"></asp:ListItem>
                 <asp:ListItem Value="2018" Text="2018"></asp:ListItem>
                <asp:ListItem Value="2019" Text="2019"></asp:ListItem>
                <asp:ListItem Value="2020" Text="2020"></asp:ListItem>
            </asp:DropDownList>
             
             
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <%--<input type ="submit" class="myButton" value="Get Attendance" runat ="server" onserverclick="get_attendance">--%>
            <asp:Button ID ="b1" CssClass="myButton" runat="server" Text="Get Results" onclick="get_results" /> 
             </div>
            
            </ul> 





 
  	  <div class="table-users"> 
   		<div class="header">Internals</div>
 <div class ="scrollit1">
  <asp:Table ID="tbl_results" runat="server"   Width="100%" cssclass = "responstable" > 
  <asp:TableHeaderRow ID = "th1" runat="server">
  <asp:TableHeaderCell>Subjects</asp:TableHeaderCell>
  <asp:TableHeaderCell>Obtained Marks</asp:TableHeaderCell>
  <asp:TableHeaderCell>Total Marks</asp:TableHeaderCell>
<asp:TableHeaderCell>Percentage</asp:TableHeaderCell>
<asp:TableHeaderCell>Status</asp:TableHeaderCell>

  </asp:TableHeaderRow>
 </asp:Table>
  
  </div>
  </div>
  

  </section>
  
   </asp:Content>


<%-- Add content controls here --%>
