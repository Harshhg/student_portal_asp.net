<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"  CodeFile="~/attendance.aspx.cs" Inherits="attendance" %>


<asp:Content ContentPlaceHolderID="c1" runat="server">
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
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#fafafa'WWWW, endColorstr='#daeff1',GradientType=0);
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
    
    
  <ul class="listcompose"><br> <br>
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

              <asp:Button ID ="b1" CssClass="myButton" runat="server" Text="Get Attendance" onclick="get_attendance" /> 
            </div>
            
            </ul><br />
    <div class = "scrollit">


   <asp:Table ID="tbl_attend" runat="server"   Width="100%" class = "responstable" >
                <asp:TableHeaderRow id ="th1" runat="server">
                 <asp:TableHeaderCell ID="TableCell10" runat="server">MONTH</asp:TableHeaderCell>
                <asp:TableHeaderCell ID="TableCell11" runat="server">Subject1</asp:TableHeaderCell>
                <asp:TableHeaderCell ID="TableCell12" runat="server">Subject2</asp:TableHeaderCell>
                <asp:TableHeaderCell ID="TableHeaderCell1" runat="server">Subject3</asp:TableHeaderCell>
                <asp:TableHeaderCell ID="TableHeaderCell2" runat="server">Subject4</asp:TableHeaderCell>
                <asp:TableHeaderCell ID="TableHeaderCell3" runat="server">Subject5</asp:TableHeaderCell>
                </asp:TableHeaderRow>

            
        </asp:Table>
  </div>

  </section>
  </div>
   </asp:Content>


<%-- Add content controls here --%>
