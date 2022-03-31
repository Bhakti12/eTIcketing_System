<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displaydata.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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
</body>
</html>
