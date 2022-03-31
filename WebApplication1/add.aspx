<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            New Flight</div>
        <p>
            Airline<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Plane no<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            departure location<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            arrival location<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            departure date<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            arrival date<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p>
            seats<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
            price<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
    </form>

</body>
</html>
