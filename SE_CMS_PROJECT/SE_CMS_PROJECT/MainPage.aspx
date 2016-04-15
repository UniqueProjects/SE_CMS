<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="SE_CMS_PROJECT.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
    <script src="Scripts/jquery-1.10.2.intellisense.js"></script>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <a href="Scripts/jquery-1.10.2.min.map">Scripts/jquery-1.10.2.min.map</a>
    <title></title>
     
    <style>
      #map {
        /*width: 2000px;*/
    height: 900px;
    background-color: #CCC;
      }
    </style>

    <script type="text/javascript" >

        //Getting Json Object
       // In the following example, markers appear when the user clicks on the map.
        // Each marker is labeled with a single alphabetical character.
        var labels = 'UCO';
        var labelIndex = 0;

        function initialize() {
         //   var LocJsonSS = '';

       //   LocJsonSS = document.getElementById('<%= hndLocJson.ClientID%>');
            //  var fixedResponse = LocJsonSS.responseText.replace(/\\'/g, "'");
             //var  LocJsonSS1 = LocJsonSS.replace(@"\", " ");
            //parsing the json object
            // var json = JSON.parse(LocJsonSS).Location_Id;
         // var embeddedJsonObj = JSON.Parse(LocJsonSS);
         //   var embeddedJsonObj = $.parseJSON(fixedResponse);
            //alert(json["Location_Id"]); //mkyong
          // alert(json.Locaion_Id); //mkyong

           // alert(json.address.streetAddress); //88 8nd Street
           // alert(json["address"].city); //New York


            var bangalore = { lat: 35.656300, lng: -97.470681 };
            var map = new google.maps.Map(document.getElementById('map'), {
                zoom: 17,
                center: bangalore
            });

            // This event listener calls addMarker() when the map is clicked.
            google.maps.event.addListener(map, 'click', function (event) {
                addMarker(event.latLng, map);
            });

            // Add a marker at the center of the map.
            addMarker(bangalore, map);
        }

        // Adds a marker to the map.
        function addMarker(location, map) {
            // Add the marker at the clicked location, and add the next-available label
            // from the array of alphabetical characters.
            var marker = new google.maps.Marker({
                position: location,
                label: labels[labelIndex++ % labels.length],
                map: map
            });
        }

        google.maps.event.addDomListener(window, 'load', initialize);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="map"></div>
    <asp:HiddenField ID="hndLocJson" runat="server" />
    </form>
</body>
</html>
