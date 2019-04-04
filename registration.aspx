<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="login" %>
<!DOCTYPE HTML>
<html lang="zxx">


<head>
	<title>Student Registration</title>
	<link href="css/registrationstyle.css" rel='stylesheet' type='text/css' />
	<!--// Stylesheets -->
	<!--online fonts-->
	<link href="http://fonts.googleapis.com/css?family=Catamaran:100,200,300,400,500,600,700,800,900" rel="stylesheet">
	<!--//online fonts-->
</head>

<body>
  
<body>
	<!---728x90--->

	<h1>Student Registration Form</h1>
	<!---728x90--->

	<div class="w3ls-login box">
		<img src="images/logo.png" alt="logo_img" />
		<!-- form starts here -->
		<form  method="post" runat="server">
			 

            <div class="agile-field-txt">
				<input type="text" name="name" placeholder="Your Name" required="" id="name"/>
			
            </div>

            <div class="agile-field-txt">
				<input type="email" name="email" placeholder="Your email" required="" id="email"/>
			
            </div>
            <div class="agile-field-txt">
				<input type="text" name="contact" placeholder="Your contact" required="" id="contact"/>
			
            </div>

            <div class="agile-field-txt">
				<input type="text" name="dept" placeholder="Your Department ( BCA/MCA..)" required="" id="dept"/>
			
            </div>

            
            <div class="agile-field-txt">
				<input type="text" name="sem" placeholder="Your Semester" required="" id="Text1"/>
                			
            </div>
              <div class="agile-field-txt">
				<input type="text" name="roll" placeholder="Your Roll Number" required="" id="Text2"/>
                			
            </div>


			<div class="agile-field-txt">
				<input type="password" name="password" placeholder="Enter password" required="" id="password" />
				<div class="agile_label">
										
				</div>
			</div>
            <asp:FileUpload ID ="photo" runat="server" />
                        
			<div class="w3ls-bot">
			<a href ="login.aspx" >Already Registered? Click here</a>
            	<input type="submit" value="Register" runat="server" onserverclick="register" > 
			</div>
		</form>
	</div>
	<!-- //form ends here -->
	<!---728x90--->

</body>



</html>
