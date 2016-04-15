<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Web_Pages_Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
    <title></title>
     
    <style>
      #map {
        /*width: 2000px;*/
    height: 900px;
    background-color: #CCC;
      }
    </style>

    <script type="text/javascript" >
        // In the following example, markers appear when the user clicks on the map.
        // Each marker is labeled with a single alphabetical character.
        var labels = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
        var labelIndex = 0;

        function initialize() {
            var bangalore = { lat: 35.656300, lng: -97.470681 };
            var map = new google.maps.Map(document.getElementById('map'), {
                zoom: 12,
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

    
    <div id="map"></div>
    
  
</body>
</html>
