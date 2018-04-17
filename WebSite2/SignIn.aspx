<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h2>Регистрация:<br /></h2>
            <asp:Table ID="Table1" runat="server" Height="16px" Width="32px">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Имя:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Фамилия:</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"> Email:</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Username:</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Password:</asp:TableCell>
                    <asp:TableCell runat="server"> <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" Width="68px" /></asp:TableCell>
                    <asp:TableCell runat="server"> <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Выход" Width="69px" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
             </div>
    </form>
</body>
</html>
