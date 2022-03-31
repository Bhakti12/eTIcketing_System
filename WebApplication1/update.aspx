<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update Flight</div>
        <p>
            Flight id<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            airline<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            planeno<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            departure location<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            arrival location<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            departure date<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p>
            arrival date<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
            seats<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        <p>
            price<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="update" />
    </form>
</body>
</html>
