<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Webby.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Label runat="server">What is your name?</asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    <div>
    <asp:DropDownList ID="ddlPeople" runat="server">
    </asp:DropDownList>
        <asp:Button ID="btnShow" runat="server" Text="Show person at:" OnClick="btnShow_Click"   />
        <asp:TextBox ID="txtIndex" runat="server"></asp:TextBox>
        <asp:Label ID="lblWho" runat="server" Text="------"></asp:Label>
        </div>
</asp:Content>
