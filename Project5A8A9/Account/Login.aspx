<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project5A8A9.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
        <asp:Label ID="UsernameLabel" runat="server" Text="User name:" Width="100px"></asp:Label><asp:TextBox ID="UserBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="PassWordLabel" runat="server" Text="password:" Width="100px"></asp:Label>
        <asp:TextBox ID="PassBox" TextMode="Password" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        
         <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
        
        <br />
         <asp:CheckBox ID="CheckBox1" runat="server" /> &nbsp;<asp:Label ID="Label1" runat="server" Text="Remember me."></asp:Label>
         <br />
   &nbsp;<asp:Label ID="MessageLabel" runat="server" Text="Message"></asp:Label>
</div>
    <p>if you want to log off you need to login agan to verify then you can log off.</p>
</asp:Content>
