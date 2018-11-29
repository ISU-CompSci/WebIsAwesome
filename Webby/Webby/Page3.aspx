<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="Webby.Page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table tr{
            background-color: #FAA;
            border: 1px solid #F00;
        }
    </style>
</head>
<body>
        <a href="Default-old.aspx">Home</a>
        <a href="Page2.aspx">Page2</a>
        <a href="Page3.aspx">Page3</a>
    <form id="form1" runat="server">
        <div>
            <h1>Page 3</h1>
            <asp:Button ID="btnFillTable" runat="server" Text="Fill The Table" OnClick="btnFillTable_Click" />
            <asp:Table ID="tblSuperHeros" runat="server">
                <asp:TableRow>
                    <asp:TableCell>bob</asp:TableCell>
                    <asp:TableCell>Smith</asp:TableCell>
</asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Jones</asp:TableCell>
                    <asp:TableCell>Sally</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
