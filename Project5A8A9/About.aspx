<%@ Page Title="Service References" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Project5A8A9.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <style type="text/css">
table, th, td {border: 1px solid black; border-collapse: collapse;}
th {height: 30px; font-size: 18px;}
th {background-color: #4cd137; color: white;}
td:nth-child(even) {color:#2f3542 ;background-color: #7bed9f;}

</style>
        <table style="width:100%">
  <thead>
  <tr id="ADDRESS">
  <th colspan="5"><b>Address: </b><a href="http://webstrar59.fulton.asu.edu/index.html">http://webstrar	59.fulton.asu.edu/index.html</a></th>
  </tr>
  <tr id="TEAM">
  <th colspan="5"><b>Team 59: </b> Thien Tan Dao, Jacob Schmit, Aurelio Villalobos</th>
  </tr>
  <tr id="REQUIRED">
  <th style="text-align:left" colspan="5"><b>Required Services</b></th>
  </tr>
  </thead>
  <thead>
  <tr>
    <th style="width:120px">Provider Name</th>
    <th style="width:300px"> Service name,with input and output types</th>
    <th style="width:80px">Try It Link</th>
    <th style="width:300px">Service Description and Location</th>
    <th style="width:300px">Planned resources need to implement the service</th>
  </tr>
  </thead>
  <tbody>
  <tr>
    <td>Thien Tan Dao</td>
    <td><b>Natural Hazards Service</b>
    <br><b>Input: </b>latitude and longitude
    <br><b>Output: </b>a number reflecting the natural hazards at the location.
	</td>
    <td style="text-align:center"><a href="/Member/NaturalHazardPage.aspx">Try It</a></td>
    <td style="text-align:center">Create a service that returns the natural hazards (Tsunamis, earthquake, volcanoes) index of a given position (latitude, longitude). This service can be used for building decision and insurance premium.
    <br><a href="http://webstrar59.fulton.asu.edu/Page0/Service1.svc">Natural Hazards Service</a></td>
    <td style="text-align:center">API Documentation<br><a href="https://earthquake.usgs.gov/fdsnws/event/1/">Earthquake Catalog </td>
  </tr>
  <tr>
    <td>Thien Tan Dao</td>
    <td><b>NewsFocus</b>
    <br><b>Input: </b> a list of topics or key words
    <br><b>Output: </b> A list of URLs in which the given topics are reported</td>
    <td style="text-align:center"><a href="/Member/NewsForcus.aspx">Try It</a></td>
    <td style="text-align:center"> Find news about specific topics, for example, find all (as many as possible) news articles about ASU (Arizona State University). 
    <br><a href="http://webstrar59.fulton.asu.edu/Page0/Service1.svc">NewsFocus</a></td>
    <td style="text-align:center">API Documentation<br><a href="https://scaleserp.com/">NewsFocus</td>
  </tr>
  <tr>
    <td>Jacob Schmit</td>
    <td><b>Weather Service</b>
    <br><b>Input: </b>string: zipcode
    <br><b>Output: </b>string</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page8">Try It</a></td>
    <td style="text-align:center">A service to return a 5-day weather forecast
    <br><a href="http://webstrar59.fulton.asu.edu/page6/Service1.svc">Weather Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://openweathermap.org/api">OpenWeather</a></td>
  </tr>
  <tr>
    <td>Jacob Schmit</td>
    <td><b>Solar Energy Service</b>
    <br><b>Input: </b>string: latitude, string: longitude
    <br><b>Output: </b>string</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page8">Try It</a></td>
    <td style="text-align:center">A service to return solar information about a location
    <br><a href="http://webstrar59.fulton.asu.edu/page6/Service1.svc">Solar Energy Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://developer.nrel.gov/docs/solar/solar-resource-v1/">NREL</a></td>
  </tr>
  <tr>
    <td>Aurelio Villalobos</td>
    <td><b>ERS Service</b>
    <br><b>Input: </b> Nothing
    <br><b>Output:</b>List of states Economic Research Service (ERS) has data on </td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page5">Try It</a></td>
    <td style="text-align:center">A service to return a list of all states ERS has data on.
    <br><a href="http://webstrar59.fulton.asu.edu/page3/Service1.svc">ERS Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://www.usda.gov/media/digital/developer-resources">ERS</a></td>
  </tr>
  <tr>
    <td>Aurelio Villalobos</td>
    <td><b>Nearest Store Service</b>
    <br><b>Input: </b> a zip code and a store name
    <br><b>Output: </b>The location of the nearest store with respect to the zip code</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page5">Try It</a></td>
    <td style="text-align:center">A service to return nearest store with respect to zip code entered.
    <br><a href="http://webstrar59.fulton.asu.edu/page3/Service1.svc">Nearest Store Service</a></td>
    <td style="text-align:center">API Documentation<br><a href="https://developers.google.com/places/web-service/overview">Google Places</a><br><a href="https://developers.google.com/maps/documentation/geocoding/start">Google Geocoding</a></td>
  </tr>
  </tbody>
  <tr id="ELECTIVE">
  <th style="text-align:left" colspan="5"><b>Elective Services</b></th>
  </tr>
  <tr>
    <th style="width:120px">Provider Name</th>
    <th style="width:300px">Service Name and Info</th>
    <th style="width:80px">Try It Link</th>
    <th style="width:300px">Service Description and Location</th>
    <th style="width:300px">Planned resources need to implement the service</th>
  </tr>
  <tr>
    <td>Thien Tan Dao</td>
    <td><b> RainFall</b>
    <br><b>Input: </b>String of location, can be city or country
    <br><b>Output: </b>Condition of the rainfall in that area</td>
    <td style="text-align:center"><a href="/Member/RainFall.aspx">Try It</a></td>
    <td style="text-align:center">Service will take a string of location then convert to latitude and longitude and search for the condition of rainfall.
    <br><a href="http://webstrar59.fulton.asu.edu/Page0/Service1.svc"> RainFall</a></td>
    <td style="text-align:center">Description Here<br> <a href="https://openweathermap.org/ ">Rainfall</a><br><a href="https://us1.locationiq.com">Location</a></td>
  </tr>
  <tr>
    <td>Thien Tan Dao</td>
    <td><b> State Population (RESTfull service)</b>
    <br><b>Input: </b> a string of state name, (need to be correct state name). 
    <br><b>Output: </b>Number of population of state input.</td>
    <td style="text-align:center"><a href="/Member/Account.aspx">Try It</a></td>
    <td style="text-align:center"> Service will take Upper or Lower string name of state, service will handle the upper and lower, User need to input the correct state name to get output of the population of state input.
    <br><a href=""><a href="http://webstrar59.fulton.asu.edu/Page1/"> State Population</a></td>
    <td style="text-align:center">Description Here<br> <a href="https://www.census.gov/data/developers.html">Goverment Population</a></td>
  </tr>
  <tr>
    <td>Thien Tan Dao</td>
    <td><b> AcountCreate and login service</b>
    <br><b>Input: </b>Usernames and password. 
    <br><b>Output: </b>message.</td>
    <td style="text-align:center"><a href="/Member/NaturalHazardPage.aspx">Try It</a></td>
    <td style="text-align:center">Account service has 2 services that create an account and login, both take input username and password, and output if the account is created or login successful.
    <br><a href="http://webstrar59.fulton.asu.edu/Page0/Service1.svc"> AcountCreate and login service</a></td>
    <td style="text-align:center">Description Here<br> <a href="">Self develope</a></td>
  </tr>
  <tr>
    <td>Aurelio Villalobos</td>
    <td><b>Tax information Service</b>
    <br><b>Input: </b>A zip code
    <br><b>Output: </b>message printing information about sales tax based on zip code</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page5">Try It</a></td>
    <td style="text-align:center">Service will take a zip code as a paramter and return tax information using that zip code as the location.
    <br><a href="http://webstrar59.fulton.asu.edu/page3/Service1.svc"> Tax Information Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="http://docs.zip-tax.com/#introduction">Zip-Tax</a></td>
  </tr>
  <tr>
    <td>Aurelio Villalobos</td>
    <td><b>Air Quality Index Service</b>
    <br><b>Input: </b>The name of a city
    <br><b>Output: </b>the air quality index (AQI) for that city</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page5">Try It</a></td>
    <td style="text-align:center">Service will take in the city entered as a parameter and return the air quality index (AQI) associated with that city
    <br><a href="http://webstrar59.fulton.asu.edu/page3/Service1.svc"> Air quality Index Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://aqicn.org/api/">API - Air Quality Programmatic APIs</a></td>
  </tr>
  <tr>
    <td>Aurelio Villalobos</td>
    <td><b> Directions Service (RESTful Service)</b>
    <br><b>Input: </b>The name of a city or state to act as the origin, the name of a city or state to act as the destination and the mode you want directions for. Choose from either driving, walking, bicycling or transit modes.
    <br><b>Output: </b> A list of directions telling the user how to get from origin to destination with respect to the mode specified. The directions include how much time is between each step and the distance between each step</b></td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page5">Try It</a></td>
    <td style="text-align:center">Service will take the three parameters mentioned above and return a list of directions as specified above
    <br><a href=""><a href="http://webstrar59.fulton.asu.edu/Page4/"> Directions Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://developers.google.com/maps/documentation/directions/overview#TravelModes">Google Directions</a></td>
  </tr>
    <tr>
    <td>Jacob Schmit</td>
    <td><b>Average Temperature Service (RESTful Service)</b>
    <br><b>Input: </b>string: zipcode
    <br><b>Output: </b>string</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page8">Try It</a></td>
    <td style="text-align:center">A service to return average predicted temperature in various units for the upcoming week
    <br><a href="http://webstrar59.fulton.asu.edu/page7/Service.svc">Solar Energy Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://openweathermap.org/api">Weather Service</a></td>
  </tr>
    <tr>
    <td>Jacob Schmit</td>
    <td><b>Racial Demographics Service</b>
    <br><b>Input: </b>string: stateCode
    <br><b>Output: </b>string</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page8">Try It</a></td>
    <td style="text-align:center">A service to return racial population demographics about a chosen state
    <br><a href="http://webstrar59.fulton.asu.edu/page6/Service1.svc">Racial Demographics Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://www.census.gov/data/developers/data-sets.html">U.S. CENSUS</a></td>
  </tr>
    <tr>
    <td>Jacob Schmit</td>
    <td><b>Elevation by Coordinates Service</b>
    <br><b>Input: </b>string: lat1, string: lon1, string: lat2, string: lon2
    <br><b>Output: </b>string</td>
    <td style="text-align:center"><a href="http://webstrar59.fulton.asu.edu/page8">Try It</a></td>
    <td style="text-align:center">A service to return elevation compared to sea level for two sets of coordinates
    <br><a href="http://webstrar59.fulton.asu.edu/page6/Service1.svc">Elevation by Coordinates Service</a></td>
    <td style="text-align:center">API Documentation<br> <a href="https://www.jawg.io/docs/apidocs/">JAWG</a></td>
  </tr>
</table>
    </div>
</asp:Content>
