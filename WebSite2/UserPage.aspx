<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserPage.aspx.cs" Inherits="Default3" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="Label1" runat="server" Text="Вход выполнен успешно!" ForeColor="Lime"></asp:Label></h1>
            <br />
            Имя -
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            Фамилия -
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            Email -
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Выйти" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
