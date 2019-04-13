<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>
<!DOCTYPE HTML>
<html lang="zxx">


<head>
	<title>Student Login</title>
	<link href="css/loginstyle.css" rel='stylesheet' type='text/css' />
	<!--// Stylesheets -->
	<!--online fonts-->
	<link href="http://fonts.googleapis.com/css?family=Catamaran:100,200,300,400,500,600,700,800,900" rel="stylesheet">
	<!--//online fonts-->
</head>

<body>
  
<body>
	<!---728x90--->

	<asp:HyperLink  id= "l1" runat= "server" NavigateUrl="~/admin/admin_login.aspx"><h1>Student Login </h1></asp:HyperLink>
	<!---728x90--->

	<div class="w3ls-login box">
		<img src="images/logo.png" alt="logo_img" />
		<!-- form starts here -->
		<form method="post" runat="server">
			 

             <div class="agile-field-txt">
				<asp:Label ID ="alert" runat="server" />
                <input type="email" name="email" placeholder="Your email" required="" id="email"/>
                
			
            </div>

			<div class="agile-field-txt">
				
				<input type="password" name="pass" placeholder="password" required="" id="pass" />
				 
                <div class="agile_label">
					<input id="Checkbox1" name="check3" type="checkbox" value="show password">
					<label class="check" for="check3">Remember me</label>
				</div>
			</div>

			<div class="w3ls-bot">
               
			    <a href ="registration.aspx" >New user? Click here</a>
            <input id="Submit1" type="submit" value="LOGIN" runat="server" onserverclick="logincheck" />
			</div>

			 
		</form>
	</div>
	<!-- //form ends here -->
	<!---728x90--->

</body>



</html>
























