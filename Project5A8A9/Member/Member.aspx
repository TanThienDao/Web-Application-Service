<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project5A8A9.Member.Member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div><h2 style="text-align:center">Welcome to Member page.</h2></div>
    <div>
        <asp:Label ID="WelcomeLabel" runat="server" Text="Welcome" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <div>
        <br/>
            <h3>List of service By Thien Tan Dao</h3>
            <ol>
            <li><a runat="server" href="~/Member/NaturalHazardPage">Natural Hazards Service</a><br /></li>
            <li><a runat="server" href="~/Member/NewsForcus">NewsFocus</a><br /></li>
            <li><a runat="server" href="~/Member/RainFall">RainFall</a><br /></li>
            <li><a runat="server" href="~/Member/StatePopulation">State Population (RESTfull service)</a><br /></li>
            <li><a runat="server" href="~/Member/Wind">Wind Service</a><br/></li>
            <li><a runat="server" href="~/Member/Account">Acound Service</a><br/></li>
            </ol>
            <br />
            <h3>List of service by Jacob Schmit</h3>
            <ol>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page8/">	Weather Service</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page8/">Solar Energy Service</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page8/">Average Temperature Service (RESTful Service)</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page8/">	Racial Demographics Service</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page8/">Elevation by Coordinates Service</a><br/></li>
            </ol>
            <h3>List of service by Aurelio Villalobos</h3>
            <ol>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page5/">ERS Service</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page5/">Nearest Store Service</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page5/">Tax information Service</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page5/">Air Quality Index Service</a><br /></li>
            <li><a runat="server" href="http://webstrar59.fulton.asu.edu/page5/">Directions Service (RESTful Service)</a><br/></li>
            </ol>
        

    </div>
    </div>
</asp:Content>
