<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="compose.aspx.cs" Inherits="compose" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

 <section id="content">
       
      <div class="inside"> 
         
        
          <div class="table-users">
              <div class="header">Compose Mail</div><br>
              <form id="contacts-form" method = "post">
      
           
            <div class="field">
              <label>Receiver E-mail:</label>
              <input type="email" value="" name ="rmail"/>
            </div>
            <div class="field">
              <label>Subject :</label>
              <input type="text" value="" name ="subject"/>
            </div>
            
              
            <div class="field extra">
              <label>Your Message:</label>
              <textarea cols="1" rows="1" name ="message"></textarea>
            </div>
            <div class="alignright"><input type ="submit" name = "submit" value ="Send Mail!"></div>
        
        </form>
 
</div>
 
  
		  
		  
		  
		  
		   
       
      </div>
    </section>

</asp:Content>


<%-- Add content controls here --%>
