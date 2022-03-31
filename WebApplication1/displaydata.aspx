<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displaydata.aspx.cs" Inherits="WebApplication1.WebForm4" %>

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
													<li><a href="displaydata.aspx">All FLight</a></li>
													<li><a href="logout.aspx">Logout</a></li>
												</ul>
									
								</nav>
							</div>
						</nav>
				</div>
			</div>
		</div>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <Columns>
                <asp:BoundField DataField="Flight_id" HeaderText="Flight_id" SortExpression="Flight_id" />
                <asp:BoundField DataField="airline" HeaderText="airline" SortExpression="airline" />
                <asp:BoundField DataField="plane_no" HeaderText="plane_no" SortExpression="plane_no" />
                <asp:BoundField DataField="departure_location" HeaderText="departure_location" SortExpression="departure_location" />
                <asp:BoundField DataField="arrival_location" HeaderText="arrival_location" SortExpression="arrival_location" />
                <asp:BoundField DataField="departure_date" HeaderText="departure_date" SortExpression="departure_date" />
                <asp:BoundField DataField="arrival_date" HeaderText="arrival_date" SortExpression="arrival_date" />
                <asp:BoundField DataField="seats" HeaderText="seats" SortExpression="seats" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Action" ShowHeader="True" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Action" ShowHeader="True" Text="Delete" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Airline_dbConnectionString %>" SelectCommand="SELECT [Flight_id], [airline], [plane_no], [departure_location], [arrival_location], [departure_date], [arrival_date], [seats], [price] FROM [flight]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" Text="Add Flight" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
    </form>
	<div class="agileinfo_copyright">
		<p>© 2022 Planezo. All rights reserved | Design by Bhakti Sanghani</a></p>
	</div>
</body>
</html>
