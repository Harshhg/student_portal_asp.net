<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="compose.aspx.cs" Inherits="compose" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
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

 
 fieldset {
	border:none;
	float:left;
}
 .rmfield {
	clear:both;
	height:30px;
}
 .rmfield.extra {
	height:268px;
}
 label {
	float:left;
	width:150px;
	font-weight:bold;
	color:#008cc4;
}
 input {
	width:277px;
	padding:2px 0 2px 3px;
	border:1px solid #d1d1d1;
	color:#70635b;
}
textarea {
	width:503px;
	height:252px;
	padding:2px 0 2px 3px;
	border:1px solid #d1d1d1;
	color:#70635b;
	overflow:auto;
}  
.rmalignright {
	text-align:right;
}
    
</style>

</head>
 <section id="content">
     <div class="inside"> 

      <div class="table-users">


             <div class="header">Compose Mail</div><br>
                
           
                   <div class="rmfield">
              <label>Receiver E-mail:</label>
              <input type="email" value="" name ="rmail"/>
            </div>
            <div class="rmfield">
              <label>Subject :</label>
              <input type="text" value="" name ="subject"/>
            </div>
            
              
            <div class="rmfield extra">
              <label>Your Message:</label>
              <textarea cols="1" rows="1" name ="message"></textarea>
            </div>
          


           <div style="float:right"><asp:Button ID ="b1" CssClass="myButton" runat="server" Text="Send Mail" onclick="send_mail" /> </div>

            </div>
        </div>
 </section>














</asp:Content>

