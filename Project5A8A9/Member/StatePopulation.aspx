<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StatePopulation.aspx.cs" Inherits="Project5A8A9.Member.StatePopulation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div><h1 style="text-align:center">Welcome to Population by state Service page.</h1></div>
     Elective Service: Population by state service.
    <br />
    <p>

        (A)Description:Service will take Upper or Lower string name of state, service will handle the upper and lower, User need to input the correct state name to get output of the population of state input.<br />
        You need to Inout full name of state<br /> EX: California not cali, the program can handel upper and lower case when you input.(caLiFornia) 
    </p>
    <p>

        (B)The WCF service WSDL is at:<a href="http://webstrar59.fulton.asu.edu/Page1/">http://webstrar59.fulton.asu.edu/Page1/</a>
    <p>

        (C)Operation: Input: String of location, can be city or country<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Output: Condition of the rainfall in that area</p>
    <p>

        <asp:Label ID="StateNameLabel" runat="server" Text="Enter State:"></asp:Label>
        <asp:TextBox ID="StateNameBox" runat="server"></asp:TextBox>
        <asp:Button ID="ResultButton" runat="server" OnClick="ResultButton_Click" Text="Invoke" />

    </p>
    <p>

        <asp:Label ID="ResultLabel" runat="server" Text="Result"></asp:Label>

    </p>
</asp:Content>
