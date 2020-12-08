<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project5A8A9.Member.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 style="text-align:center">Welcome to Member login Page.</h3>

    <div>
        <asp:Label ID="UsernameLabel" runat="server" Text="User name:" Width="100px"></asp:Label><asp:TextBox ID="UserBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="PassWordLabel" runat="server" Text="password:" Width="100px"></asp:Label>
        <asp:TextBox ID="PassBox" TextMode="Password" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="MessageLabel" runat="server" Text="Message"></asp:Label>
</div>
</asp:Content>
