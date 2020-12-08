<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Project5A8A9.Member.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div><h1 style="text-align:center">Welcome to Accound login Service page.</h1></div>
    <div>
    
        
        Elective Service: Account service.</p>
    <p>
        (A) Description: Account Service will aske user to input thier username and password, and store date on the server host for the login service to check.</p>
    <p>
        (B)The WCF service WSDL is at:<a href="http://webstrar59.fulton.asu.edu/Page0/Service1.svc?wsdl">http://webstrar59.fulton.asu.edu/Page0/Service1.svc?wsdl</a> 
    </p>
    <p>
        (C)Operation: Input String username and password; will thake this 2 infor and store in .Json file and the password store is encrypted.</p>
    <p>
        <br />
        <asp:Label ID="usernameLabel" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="UsernameBox" runat="server" Width="186px"></asp:TextBox>
    </p>
    <p>

        <asp:Label ID="PassowordLabel" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordBox" runat="server" Width="198px"></asp:TextBox>
    </p>
    <p>

         <asp:Button ID="CreatedButton" runat="server" Text="Create" OnClick="CreatedButton_Click" />
    </p>
    <p>

         <asp:Label ID="ResultLabel" runat="server" Text="Result"></asp:Label>
    </p>
        </div>
      <div>
    
            Elective Service: Login Service.</p>
        <p>
        (A)Description: Service will take user username and password and check if they input correct username and passowrd. <br />  The password got decrypt here.</p>
    <p>
        (B)The WCF service WSDL is at:<a href="http://webstrar59.fulton.asu.edu/Page0/Service1.svc?wsdl">http://webstrar59.fulton.asu.edu/Page0/Service1.svc?wsdl</a></p>
    <p>
        (C)Operation: Input string username and passowrd and output the true or false if the account login success or not.</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Result"></asp:Label>
    </p>
        </div>

</asp:Content>
