<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="viewsentmail.aspx.cs" Inherits="readmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
<head>
<style> 

 
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


              <div class="header" style="text-transform:none"><asp:Label ID ="name" runat="server"></asp:Label></div><br>
                
           
                     <div class="rmfield">
                             <label>Subject : </label>
		                    <h5 style="color:#FF9900""> <asp:Label ID ="sub" runat="server" Text=""></asp:Label></h5>
                    </div>
                
                
                     <%--<div class="rmfield">
                             <label>Email : </label>
		                    <h5 style="color:#FF9900""> <asp:Label ID ="mail" runat="server" Text=""></asp:Label></h5>
                    </div>--%>
                    
                     <div class="rmfield">
                             <label>Date : </label>
		                    <h5 style="color:#FF9900""> <asp:Label ID ="date" runat="server" Text=""></asp:Label></h5>
                    </div>
              <asp:TextBox ID ="message" Visible=false runat="server"></asp:TextBox>

                <div class="rmfield extra">
                    <label>Your Message:</label>
            <textarea disabled cols="1" rows="1" name ="message" runat="server"><%Response.Write(message.Text); %></textarea> 
                    
                </div>
            
                <div class="rmalignright"><input type ="submit" name = "goback" value ="Go Back" runat="server" onserverclick="goback"></div>
            
        
            </div>
        </div>
 </section>














</asp:Content>

