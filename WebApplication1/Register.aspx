<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register here !!</div>
        <p>
            Enter Your Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Address<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Contact<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            City<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            UserName<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            Password<asp:TextBox ID="TextBox6" runat="server" type="password"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click1" />
    </form>
</body>
</html>
