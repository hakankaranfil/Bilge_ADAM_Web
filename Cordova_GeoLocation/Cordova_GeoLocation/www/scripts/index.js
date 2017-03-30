
(function () {
    "use strict";

    document.addEventListener( 'deviceready', onDeviceReady.bind( this ), false );

    function onDeviceReady() {
        // Handle the Cordova pause and resume events
        document.addEventListener( 'pause', onPause.bind( this ), false );
        document.addEventListener('resume', onResume.bind(this), false);
        document.getElementById("Geo").addEventListener("click", getposition);
        
      
    };

    function onPause() {
       
    };

    function onResume() {
       
    };
    function getposition()
    {
        var options = {
            enableHighAccuracy:true, 
            //Konumu iyi bi şekilde göstermek için
            maximumAge:3000
        }
        var action = navigator.geolocation.getCurrentPosition(onSuccess, onerror, options);
        function onSuccess() {
            document.getElementById("sonuc").innerHTML="Latidute"+position.coo
        }
    }

    }
 )();