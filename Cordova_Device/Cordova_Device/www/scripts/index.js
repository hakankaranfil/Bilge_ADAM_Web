
(function () {
    "use strict";

    document.addEventListener( 'deviceready', onDeviceReady.bind( this ), false );

    function onDeviceReady() {
        // Handle the Cordova pause and resume events
        document.addEventListener( 'pause', onPause.bind( this ), false );
        document.addEventListener('resume', onResume.bind(this), false);
    document.getElementById("btnDevice").addEventListener("click", DeviceAbout());
    };

    function onPause() {
        
    };

    function onResume() {
      
    };
    function DeviceAbout()
    {
        
        alert("Model:" + device.model + "\n" + "Platform:" + device.platform + "\n" + "Versiyon:" + device.version + "UUID:" + device.uuid + "CordovaVersiyon:" + device.cordova);
    }
} )();