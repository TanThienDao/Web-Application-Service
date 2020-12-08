<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="Project5A8A9.Staff.StaffPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h2><%:Title %></h2>
    <h3>Execute staff member privileges here:</h3>
    <p>Use the interface below to add new members, delete current members, or see a list of all current members.</p>
    <p>Member Username:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="165px"></asp:TextBox>
    </p>
    <p>Member Password: &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="168px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add New Member" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Delete Current Member" OnClick="Button2_Click" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Search For a Single Member" OnClick="Button3_Click" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Display All Members" OnClick="Button4_Click" />

    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Height="453px" Width="889px" TextMode="MultiLine"></asp:TextBox>
    </p>
</asp:Content>
