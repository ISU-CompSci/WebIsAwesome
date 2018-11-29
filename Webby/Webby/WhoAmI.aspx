<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="WhoAmI.aspx.cs" Inherits="Webby.WhoAmI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Label ID="lblTitle" runat="server" Text="You are:"></asp:Label>
    <asp:Label ID="lblUsername" runat="server" Text="Unknown"></asp:Label>
    <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click"  />
</asp:Content>
