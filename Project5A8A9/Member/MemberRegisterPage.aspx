<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberRegisterPage.aspx.cs" Inherits="Project5A8A9.Member.MemberRegisterPage" %>
<%@ Register TagPrefix="myControl" TagName="ImgVerifier" src="ImgVerifier.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;&nbsp;
    <div>   
        <h2 style="text-align:center">Welcome to Register page for Member.</h2>
    </div>
    &nbsp;&nbsp;
   <div>
       <asp:Label ID="UserNameLabel" runat="server" Text="User Name: " Width="125px"></asp:Label><asp:TextBox ID="UserNameBox" runat="server" Width="200px"></asp:TextBox>
       <br />
       <asp:Label ID="PasswordLabel" runat="server" Text="Password" Width="125px"></asp:Label>
       <asp:TextBox TextMode="Password" ID="PasswordBox" runat="server" Width="200px"></asp:TextBox>
       <br />
       <asp:Label ID="ConfirmPassLabel" runat="server" Text="Confirm Password" Width="125px"></asp:Label>
       <asp:TextBox TextMode="Password" ID="ConfirmPassBox"  runat="server" Width="200px"></asp:TextBox>
       <br />
       <!--<asp:Panel ID="CaptchaPannel" runat="server">-->
       <myControl:ImgVerifier ID="ImgVerifier" runat="server" /> &nbsp;<br />
           <!--</asp:Panel>-->
       PLease enter here:<br />
&nbsp;<asp:TextBox ID="VerifyStringBox" runat="server"></asp:TextBox>
       <br />
       &nbsp;
       <asp:Button ID="CreateButton" runat="server" Text="Create" OnClick="CreateButton_Click" />
       <br />
       <asp:Label ID="ResultLabel" runat="server" Text="Result"></asp:Label>
   </div>
        
</asp:Content>
