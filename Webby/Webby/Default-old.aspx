<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default-old.aspx.cs" Inherits="Webby.Default_old" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="Default-old.aspx">Home</a>
        <a href="Page2.aspx">Page2</a>
        <a href="Page3.aspx">Page3</a>
        <div>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
    <asp:Button ID="btnSayHello" runat="server" Text="Say Hello" OnClick="btnSayHello_Click" />
            <asp:Label ID="lblOutput" runat="server" Text=" "></asp:Label>
        </div>
    </form>
    </body>
</html>
