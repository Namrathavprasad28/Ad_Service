<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Retailer_Reg.aspx.cs" Inherits="Ad_Service_Management.Visitor.Retailer_Reg" %>

<!DOCTYPE html>
<html lang="en">
<head>
<link rel="icon" href="images/salesman.ico" />
<title>Retailer Register Form</title>
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
			<h1><span class="image"></span><label>R</label>etailer <label>R</label>egister form</h1>
		</div>
		<div class="agile-form">
			<form action="#" method="get" runat="server">
				<div class="agile-email">
					<p>email-address</p>
                    <%--<input type="email" name="email" placeholder="email-address" required="">--%>
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="email-address"></asp:TextBox>
				</div>
				
				<div class="agile-profile">
					<p>mobile number</p>
                    <%--<input type="text" name="mobile" placeholder="mobile" required="">--%>
                    <asp:TextBox ID="txtMob" runat="server" placeholder="mobile"></asp:TextBox>
				</div>
				<div class="agile-fname">
					<p>first name</p>
					<%--<input type="text" name="username" placeholder="first name" required="">--%>
                    <asp:TextBox ID="txtName" runat="server" placeholder="first name"></asp:TextBox>
				</div>
				<div class="agile-lname">
					<p>last name</p>
					<%--<input type="text" name="lstname" placeholder="last name" required="">--%>
                    <asp:TextBox ID="txtLstNm" runat="server" placeholder="last name"></asp:TextBox>
				</div>
				<div class="clear"></div>
				<div class="agile-gender">
					<p>gender</p>
					<div class="agile-mgender">
						<%--<input type="radio" name="gender" value="male" checked>--%>
						
                        <asp:RadioButton ID="rdbMale" runat="server" Text="Male" Checked="True" 
                            GroupNamRadioButtone="x"></asp:RadioButton>
                        <%--<span>male</span>--%>
					</div>
					<div class="agile-fgender">
						<%--<input type="radio" name="gender" value="female">--%>
						
                        <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" GroupName="x"></asp:RadioButton>
                       <%-- <span>female</span>--%>
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
                <div class="agile-password">
					<p>password</p>
					<%--<input type="password" name="password" placeholder="password" required="">--%>
                    <%--<asp:TextBox ID="txtPas" runat="server" placeholder="password" 
                        TextMode="Password"></asp:TextBox>--%>
                    <asp:TextBox ID="txtPas" runat="server" TextMode="Password" placeholder="password"></asp:TextBox>
				</div>
				<div class="agile-submit">
                    <%--<input type="submit" value="register">--%>
                    <asp:Button ID="Button1" runat="server" Text="Register" onclick="Button1_Click"></asp:Button>
				</div>
                <br />
                <div><a href="Index.aspx">Home Page</a></div>
			</form>
		</div>
		<div class="clear"></div>
		 <footer>
			&copy;2019 Register Form</a>
		  </footer>
		
	</section>

</body>
</html>
