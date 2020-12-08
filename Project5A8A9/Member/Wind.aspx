<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Wind.aspx.cs" Inherits="Project5A8A9.Member.Wind" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Wind Intensity Service TryIt Page</h2>
        <br>
        <p><u> Description </u></p>
        <p>This operation demonstrates the implementation of Annual Wind Intensity Service for a specific location identified by a pair of Longitute and Lattitude</p>
        <br>
        <p><u> URL </u></p>
        <p><b>Note: </b> The data source size is very large. Hence from the above API URL, the data source file was downloaded and kept in APP_Data folder for fetching purpose</p>
        <br>
        <p> Please enter the lattitude(max: 89, min: -90) and longitude(max: 179, min: -180) below (Only integer value) </p> 
        <br>
        <asp:Label ID="LabelLat" runat="server"> Lattitude  :  </asp:Label>&nbsp; &nbsp;<asp:TextBox ID="TextLat" runat="server" Width="100px"></asp:TextBox> 
        <br><br>
        <asp:Label ID="LabelLong" runat="server"> Longitude : </asp:Label>&nbsp; &nbsp;<asp:TextBox ID="TextLong" runat="server" Width="100px"></asp:TextBox> 
        <br><br>
        <asp:Button ID="BtnGetIndex" runat="server" Text="Get Annual Index" OnClick="BtnGetIndex_Click"></asp:Button>  
        <br><br>
        <asp:Label ID="LabelIndexHdr" runat="server"> The Annual Wind Intensity Index : </asp:Label>&nbsp; &nbsp;<asp:Label ID="LabelIndexVal" runat="server"></asp:Label>
</asp:Content>
