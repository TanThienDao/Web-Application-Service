<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5A8A9._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        tabel, th, td 
        {
            border 1px solid back;
            border-collapse: collapse;
        }
        th

        {
            height: 30px; 
            font-size: 18px;
        }
        th 
        {
            background-color: #a29bfe;
            color: white;

        }
        td:nth-child(even) 
        {
            color:#2f3542 ;
            background-color: #81ecec;

        }

    </style>

    <div class="jumbotron">
        <h1 style="text-align:center" >Team 59 WEB Applicaion.</h1>
        
        
    </div>

    <div class="row">
       <table style="width:100%; border-style:solid double;  outline: solid">
            
                <tr id="Description">
                  <td style="width:120px"><b>Description: </b></td><td> Program will try to report the Natural Weather of Area you search for.
                      <br /><a href="http://webstrar59.fulton.asu.edu/index.html">Link to Tryitpage.</a>
                  </td>
                </tr>
                <tr id="Grop">
                    <td style="width:120px"><b>Group: </b></td><td>59</td>
                </tr>
                <tr="Memeber">
                    <td style="width:120px"><b>Member: </b></td><td>Thien Tan Dao, Jacob Schmit, Aurelio Villalobos</td>
                </tr>
                
            
        </table>
    </div>
    <div style="background-color:#7bed9f "class="my_text">
        <br />
        <h3>The following is the functionality of this application: </h3>
        <ol>
            <li><h4>Natural Hazards Service</h4></li>
            Create a service that returns the natural hazards (Tsunamis, earthquake, volcanoes) index of a given position (latitude, longitude).
            This service can be used for building decision and insurance premium.
            <li><h4>NewsFocus</h4></li>
            Find news about specific topics, for example, 
            find all (as many as possible) news articles about ASU (Arizona State University).
            <li><h4>Weather Service</h4></li>
            Create a 5-day weather forecast service of zipcode location based on the national weather service.
            <li><h4>Solar Energy Service</h4></li>
            Create a service that returns the annual average sunshine index of a given position (latitude, longitude). 
            This service can be used for deciding if installing a solar energy device is effective at the location.
            <li><h4>ERS Service</h4></li>
            A service to return a list of all states ERS has data on.
            <li><h4>Nearest Store Service</h4></li>
            A service to return nearest store with respect to zip code entered.
            <li><h4>RainFall</h4></li>
            Service will take a string of location then convert to latitude and longitude and search for the condition of rainfall.
            <li><h4>State Population (RESTfull service)</h4></li>
            Service will take Upper or Lower string name of state, service will handle the upper and lower,
            User need to input the correct state name to get output of the population of state input.
            <li><h4>AcountCreate and login service</h4></li>
            Account service has 2 services that create an account and login,
            both take input username and password, 
            and output if the account is created or login successful.

            <li><h4>Tax information Service</h4></li>
            Service will take a zip code as a paramter and return tax information using that zip code as the location.
            <li><h4>Air Quality Index Service</h4></li>
            Service will take in the city entered as a parameter and return the air quality index (AQI) associated with that city.
            <li><h4>Directions Service (RESTful Service)</h4></li>
            Service will take the three parameters mentioned above and return a list of directions as specified above
        </ol>
        <br />
        <h4>Here is how Member and staff can signup for the services.</h4>
        The end user has to sign up through the Member Registation link which Let him/her access to Member page.
        <br />
        Memeber page is page which contrains link to all the above services.
        <br />
        <br />
        <asp:Button ID="MemberPageButton" runat="server" Text="Member Page" Width="138px" OnClick="MemberPageButton_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="MemberRegistrationButton" runat="server" Text="Member Registration" Width="250px" OnClick="MemberRegistrationButton_Click" />
        <br />
        <br />
        <asp:Button ID="StaffPageButton" runat="server" Text="Staff Page" Width="138px" OnClick="StaffPageButton_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="StaffRRegistrationButton" runat="server" Text="Staff Registration" Width="250px" OnClick="StaffRRegistrationButton_Click" />
        <br />
        <h4>How the Member can test the services ?</h4>
        The member can test the services by navigating to the respective pages from Member page and all the services are listed
        with the link in the service derectory.
        The directory also includes test pages for the Local Component layer like Global.asax and DLL.
        <ol>
            <li><h4>Natural Hazards Service</h4></li>
            Test case : Latitude(-90 to +89, no fractions or decimals) ; Longitude(-180 to +179, no fractions or decimals)
            <li><h4>NewsFocus</h4></li>
            Test case : check for the google scholar new.
            <li><h4>Weather Service</h4></li>
            Tesr case: Any Zipcode (ex. 89129)
            <li><h4>Solar Energy Service</h4></li>
            Test case: Coordinates (ex. 40, -105)
            <li><h4>ERS Service</h4></li>
            Test cae: For ERS service there is no input
            <li><h4>Nearest Store Service</h4></li>
            Test case: put any zipcode and any store name
            <li><h4>RainFall</h4></li>
            Test case : Latitude(-90 to +89, no fractions or decimals) ; Longitude(-180 to +179, no fractions or decimals)
            <li><h4>State Population (RESTfull service)</h4></li>
            Test case: check for the input<br />
            example: check for the input if you want to check population in California you need to input California not Cali.
            <li><h4>Acount Create and login service</h4></li>
            Test case: Try to create an account and login on the login web with the wrong password, or create another account with same user named from previous register.
            <li><h4>Tax information Service</h4></li>
            Test case: any zipcode
            <li><h4>Air Quality Index Service</h4></li>
            Test case: any city name
            <li><h4>Directions Service (RESTful Service)</h4></li>
            Test Case :  any city for the origin, any city for the destination and either walking, driving, transit or bicycling
            <li><h4>Global.asax for Event handler</h4></li>
            Test Case : A valid event has to be triggered to show the last accessed time and number of access requests made so far.
            <li><h4>User Control</h4></li>
            Test Case :  Enter string length n, an image will be displayed with random string (along with noise) of length n. Enter the String in the image for verification
            <li><h4>XML Manipulation</h4></li>
            Test Case : Enter username and password to add to Users.xml and search the users in Users.xml by providing the Username  <br />
            This page also displays list of usernames, check this list before entering the username as existing username cannot be added
            <li><h3>Cookies and Sessions</h3></li>
            Test case : it remember the username and password when login and prevent to go back login page agian.
            </ol>
        <p>Note: </p>
        <asp:Label ID="AccessRequestLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="StartTimeLabel" runat="server"></asp:Label>
    </div>
  

</asp:Content>
