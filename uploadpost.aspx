<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="uploadpost.aspx.cs" Inherits="compose" %>

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
         
        
          <div class="table-users" >
              <div class="header">Upload Post</div><br>
              <form id="contacts-form" method = "post">
      
           <div style="margin-left:10px">
                    <div class="field" >
                    </label><asp:FileUpload ID ="document" runat="server"/>
                        </div>
                        <br />
                   
            
              
                    <div class="field extra">
                    <label>Enter Description</label>
                    <textarea cols="30" rows="3" name ="desc"></textarea>   
                    </div>
            </div><br />
            <div style="float:right">
            <asp:Button ID ="b1"  CssClass="myButton" runat="server" Text="Upload Post" 
                    onclick="b1_Click"  /> 
            <br />
            </div>
        <br />
        </form>
 
</div>
 
  
		  
		  
		  
		  
		   
       
      </div>
    </section>

</asp:Content>


<%-- Add content controls here --%>
