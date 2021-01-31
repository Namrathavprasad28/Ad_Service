<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Ad_Service_Management.Visitor.User" %>

<%--<!DOCTYPE html>
<html lang="en">
<head>
<title>User Register Form</title>
<!-- metatags-->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="wedlock register form a Flat Responsive Widget,Login form widgets, Sign up Web forms , Login signup Responsive web form,Flat Pricing table,Flat Drop downs,Registration Forms,News letter Forms,Elements" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Meta tag Keywords -->
<!-- css -->
<link rel="stylesheet" href="Register/css/style.css" type="text/css" media="all" />
<!--// css -->
<link href="//fonts.googleapis.com/css?family=Cabin" rel="stylesheet">
<link href="//fonts.googleapis.com/css?family=Titillium+Web" rel="stylesheet">
<link href="//fonts.googleapis.com/css?family=Philosopher" rel="stylesheet">
</head>
<body>
	<section class="agile-header">
		<div class="agile-heading">
			<h1><span class="image"></span><label>U</label>ser <label>R</label>egister form</h1>
		</div>
		<div class="agile-form">
			<form id="Form1" action="#" method="get" runat="server" enctype="multipart/form-data">
				<div class="agile-email">
					<p>email-address</p>
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="email-address"></asp:TextBox>
				</div>
				<div class="agile-password">
					<p>password</p>
                    <asp:TextBox ID="txtPas" runat="server" placeholder="password" 
                        TextMode="Password"></asp:TextBox>
				</div>
				<div class="agile-profile">
					<p>mobile number</p>
                    <asp:TextBox ID="txtMob" runat="server" placeholder="mobile"></asp:TextBox>
				</div>
				<div class="agile-fname">
					<p>first name</p>
                    <asp:TextBox ID="txtName" runat="server" placeholder="first name"></asp:TextBox>
				</div>
				<div class="agile-lname">
					<p>last name</p>
                    <asp:TextBox ID="txtLstNm" runat="server" placeholder="last name"></asp:TextBox>
				</div>
				<div class="clear"></div>
				<div class="agile-gender">
					<p>gender</p>
					<div class="agile-mgender">
						
                        <asp:RadioButton ID="rdbMale" runat="server" Text="Male" Checked="True" 
                            GroupName="x"></asp:RadioButton>
					</div>
					<div class="agile-fgender">
						
                        <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" GroupName="x"></asp:RadioButton>
					</div>
					<div class="clear"></div>
				</div>
				<div class="agile-dob">
					<p>date of birth</p>
                    <asp:DropDownList ID="ddlMnt" runat="server" class="agile-month">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>january</asp:ListItem>
                        <asp:ListItem>febuary</asp:ListItem>
						<asp:ListItem>march</asp:ListItem>
						<asp:ListItem>april</asp:ListItem>
						<asp:ListItem>may</asp:ListItem>
						<asp:ListItem>june</asp:ListItem>
						<asp:ListItem>july</asp:ListItem>
						<asp:ListItem>august</asp:ListItem>
						<asp:ListItem>september</asp:ListItem>
						<asp:ListItem>october</asp:ListItem>
						<asp:ListItem>november</asp:ListItem>
						<asp:ListItem>december</asp:ListItem>
                    </asp:DropDownList>
					<asp:DropDownList ID="ddlDate" runat="server" class="agile-date">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
						<asp:ListItem>3</asp:ListItem>
						<asp:ListItem>4</asp:ListItem>
						<asp:ListItem>5</asp:ListItem>
						<asp:ListItem>6</asp:ListItem>
						<asp:ListItem>7</asp:ListItem>
						<asp:ListItem>8</asp:ListItem>
						<asp:ListItem>9</asp:ListItem>
						<asp:ListItem>10</asp:ListItem>
						<asp:ListItem>11</asp:ListItem>
						<asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
						<asp:ListItem>16</asp:ListItem>
						<asp:ListItem>17</asp:ListItem>
						<asp:ListItem>18</asp:ListItem>
						<asp:ListItem>19</asp:ListItem>
						<asp:ListItem>20</asp:ListItem>
						<asp:ListItem>21</asp:ListItem>
						<asp:ListItem>22</asp:ListItem>
						<asp:ListItem>23</asp:ListItem>
						<asp:ListItem>24</asp:ListItem>
						<asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
						<asp:ListItem>27</asp:ListItem>
						<asp:ListItem>28</asp:ListItem>
						<asp:ListItem>29</asp:ListItem>
						<asp:ListItem>30</asp:ListItem>
						<asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
					 <asp:DropDownList ID="ddlYear" runat="server" class="agile-year">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
						<asp:ListItem>2016</asp:ListItem>
						<asp:ListItem>2015</asp:ListItem>
						<asp:ListItem>2014</asp:ListItem>
						<asp:ListItem>2013</asp:ListItem>
						<asp:ListItem>2012</asp:ListItem>
						<asp:ListItem>2011</asp:ListItem>
						<asp:ListItem>2010</asp:ListItem>
						<asp:ListItem>2009</asp:ListItem>
						<asp:ListItem>2008</asp:ListItem>
						<asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                        <asp:ListItem>2004</asp:ListItem>
						<asp:ListItem>2003</asp:ListItem>
						<asp:ListItem>2002</asp:ListItem>
						<asp:ListItem>2001</asp:ListItem>
						<asp:ListItem>2000</asp:ListItem>
						<asp:ListItem>1999</asp:ListItem>
						<asp:ListItem>1998</asp:ListItem>
						<asp:ListItem>1997</asp:ListItem>
						<asp:ListItem>1996</asp:ListItem>
						<asp:ListItem>1995</asp:ListItem>
						<asp:ListItem>1994</asp:ListItem>
                    </asp:DropDownList>
					<div class="clear"></div>
				</div>
				<div class="agile-religion">
					<p>City</p>
                    <asp:DropDownList ID="ddlCty" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlCty_SelectedIndexChanged"></asp:DropDownList>
				</div>
				<div class="agile-tongue">
					<p>Area</p>
                        <asp:DropDownList ID="ddlAr" runat="server"></asp:DropDownList>
				</div>
                <div>
					<p>Upload Image</p>
                    <input type="file" id="avatar" name="avatar" accept="image/png, image/jpeg" required="">
				</div>
				<div class="agile-submit">
                    <asp:Button ID="Button1" runat="server" Text="Register" onclick="Button1_Click"></asp:Button>
				</div>
			</form>
		</div>
		<div class="clear"></div>
		 <footer>
			&copy;2019 Register Form. All Rights Reserved <a href="#" target="blank"></a>
		  </footer>
		
	</section>

</body>
</html>--%>

<!DOCTYPE HTML>
<html lang="zxx">

<head>
    <link rel="icon" href="images/salesman.ico" />
	<title>Student Register Form</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="keywords" content="Appraise Register Form template Responsive, Login form web template,Flat Pricing tables,Flat Drop downs Sign up Web Templates, 
 Flat Web Templates, Login sign up Responsive web template, SmartPhone Compatible web template, free web designs for Nokia, Samsung, LG, SonyEricsson, Motorola web design">
	<script type="application/x-javascript">
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
	<!-- Custom Theme files -->
	<link href="User_Register/css/font-awesome.css" rel="stylesheet">
	<link href="User_Register/css/style.css" rel='stylesheet' type='text/css' />
	<!--fonts-->
	<link href="//fonts.googleapis.com/css?family=Josefin+Sans:100,100i,300,300i,400,400i,600,600i,700,700i" rel="stylesheet">
	<link href="//fonts.googleapis.com/css?family=PT+Sans:400,400i,700,700i" rel="stylesheet">
	<!--//fonts-->
</head>

<body>
	<!-- login -->
	<h1 class="wthree">User Register Form</h1>
	<div class="login-section-agileits">
		<form id="Form1" action="#" method="post" runat="server">
            <div class="w3ls-icon">
				<span class="fa fa-book" aria-hidden="true"></span>
                <asp:DropDownList ID="ddlCty" runat="server" class="example" 
                    AutoPostBack="True" onselectedindexchanged="ddlCty_SelectedIndexChanged1">
                </asp:DropDownList>
			</div>
            <div class="w3ls-icon">
				<span class="fa fa-user" aria-hidden="true"></span>
                <asp:DropDownList ID="ddlAr" runat="server" class="example">
                </asp:DropDownList>
			</div>
             <div class="w3ls-icon">
				<span class="fa fa-user" aria-hidden="true"></span>
                 <asp:DropDownList ID="ddlGender" runat="server" class="example">
                     <asp:ListItem>--Select Gender--</asp:ListItem>
                     <asp:ListItem>Male</asp:ListItem>
                     <asp:ListItem>Female</asp:ListItem>
                 </asp:DropDownList>
			</div>
            <div class="w3ls-icon">
				<span class="fa fa-user" aria-hidden="true"></span>
				<input type="text" class="lock" name="name" placeholder="Studentname" required="" />
			</div>
            <div class="w3ls-icon">
				<span class="fa fa-mobile" aria-hidden="true"></span>
				<input type="text" class="lock" name="Mobile" placeholder="Mobile" required="" />
			</div>
			<div class="w3ls-icon">
				<span class="fa fa-envelope" aria-hidden="true"></span>
				<input type="email" class="user" name="email" placeholder="Email" required="" />
			</div>
			<div class="w3ls-icon">
				<span class="fa fa-lock" aria-hidden="true"></span>
				<input type="password" class="lock" id="password1" name="password" placeholder="Password" required="" />
			</div>
			<div class="w3ls-icon">
				<span class="fa fa-photo" aria-hidden="true"></span>
                <asp:FileUpload ID="FileUpload1" runat="server" class="user" />
			</div>
        <asp:Button ID="Button1" runat="server" Text="register now" onclick="Button1_Click" />
        <br />
        <div><a href="Index.aspx">Home Page</a></div>
		</form>
	</div>
	<p class="footer-agile">© 2019 Register Form
	</p>


	<script type="text/javascript">
	    window.onload = function () {
	        document.getElementById("password1").onchange = validatePassword;
	        document.getElementById("password2").onchange = validatePassword;
	    }

	    function validatePassword() {
	        var pass2 = document.getElementById("password2").value;
	        var pass1 = document.getElementById("password1").value;
	        if (pass1 != pass2)
	            document.getElementById("password2").setCustomValidity("Passwords do not Match");
	        else
	            document.getElementById("password2").setCustomValidity('');
	        //empty string means no validation error
	    }
	</script>

</body>

</html>