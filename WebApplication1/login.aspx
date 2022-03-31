<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="all" />
<!-- //For Testimonials slider -->
<!-- //custom-theme files-->
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<!-- //custom-theme files-->

<!-- font-awesome-icons -->
<link href="css/font-awesome.css" rel="stylesheet"> 
<!-- //font-awesome-icons -->
<!-- googlefonts -->
<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese" rel="stylesheet">
<link href="//fonts.googleapis.com/css?family=Montserrat:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=latin-ext,vietnamese" rel="stylesheet">
    </head>
<body>
<div class="top">
					<div class="container">
						
							
							<div class="col-md-6 top-middle">
								<ul>
									<li><a href="#"><i class="fa fa-facebook"></i></a></li>
									<li><a href="#"><i class="fa fa-twitter"></i></a></li>
									<li><a href="#"><i class="fa fa-google-plus"></i></a></li>
									<li><a href="#"><i class="fa fa-linkedin"></i></a></li>
								</ul>
							</div>
							<div class="col-md-6 top-left">
								<ul>
									<li><i class="fa fa-mobile" aria-hidden="true"></i> +021 365 777</li>
									<li><i class="fa fa-map-marker" aria-hidden="true"></i> 132 New Lenox, 868 1st Avenue </li>
								</ul>
							</div>
							<div class="clearfix"></div>
						
					</div>
				</div>
				<div class="top-bar">
				<div class="container">
					<div class="header">
						<nav class="navbar navbar-default">
							<div class="navbar-header navbar-left">
								<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
									<span class="sr-only">Toggle navigation</span>
									<span class="icon-bar"></span>
									<span class="icon-bar"></span>
									<span class="icon-bar"></span>
								</button>
								<h1><a class="navbar-brand" href="index.html">Travel Agency</span></a></h1>
							</div>
							<!-- Collect the nav links, forms, and other content for toggling -->
							<div class="collapse navbar-collapse navbar-right" id="bs-example-navbar-collapse-1">
								<nav class="cl-effect-15" id="cl-effect-15">
									<ul class="nav navbar-nav">
										<li class="active"><a href="home.aspx">Home</a></li>
													<li><a href="Register.aspx">Register</a></li>
													<li><a href="login.aspx">Login</a></li>
												</ul>
									
								</nav>
							</div>
						</nav>
				</div>
			</div>
		</div>
    <form id="form1" runat="server">
        
        Login<p>
            UserName<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        
    <p>
        Password<asp:TextBox ID="TextBox2" runat="server" type="password"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        
    </form>
	<div class="agileinfo_copyright">
		<p>© 2022 Planezo. All rights reserved | Design by Bhakti Sanghani</a></p>
	</div>
    </body>
</html>
