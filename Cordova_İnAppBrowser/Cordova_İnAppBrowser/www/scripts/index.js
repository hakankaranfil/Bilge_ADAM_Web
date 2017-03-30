
(function () {
    "use strict";

    document.addEventListener( 'deviceready', onDeviceReady.bind( this ), false );

    function onDeviceReady() {
        // Handle the Cordova pause and resume events
        document.addEventListener( 'pause', onPause.bind( this ), false );
        document.addEventListener('resume', onResume.bind(this), false);
        var a = window.open('http://www.google.com', '_blank', 'location=yes');
        
    };

    function onPause() {
       
    };

    function onResume() {
        
    };
} )();