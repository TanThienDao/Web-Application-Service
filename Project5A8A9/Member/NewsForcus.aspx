<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewsForcus.aspx.cs" Inherits="Project5A8A9.Member.NewsForcus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div><h1 style="text-align:center">Welcome to NewForcus Service page.</h1></div>
    <p>
        Require Service: NewForcus Service.
    </p>
    <p>
        (A)Description: Find news about specific topics, for example, find all (as many as possible) news articles about ASU (Arizona State University).</p>
    <p>
        (B)The WCF service WSDL is at:<a href="http://webstrar59.fulton.asu.edu/Page0/Service1.svc?wsdl">http://webstrar59.fulton.asu.edu/Page0/Service1.svc?wsdl</a></p>
    <p>
        (C)Operation: string[] NewsFocus(string[] topics); Which 
             
            take a string of topic and return list of URL topic article

    </p>
    <p>
        <asp:Label ID="ListLabel" runat="server" Text="A list of serch topic.(please separate by commas)."></asp:Label>
        <asp:TextBox ID="InputNewForcusBox" runat="server" Width="270px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Invoke" />

    </p>
    <p>
        <asp:Label ID="ArticleLabel" runat="server" Text="Article: "></asp:Label>
        <asp:TextBox ID="OutOutNewForcusBox" runat="server" Height="174px" TextMode="MultiLine" Width="976px"></asp:TextBox>

    </p>

</asp:Content>
