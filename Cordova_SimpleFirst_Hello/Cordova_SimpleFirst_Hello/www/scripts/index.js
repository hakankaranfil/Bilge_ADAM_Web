// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=397704
// To debug code on page load in Ripple or on Android devices/emulators: launch your app, set breakpoints, 
// and then run "window.location.reload()" in the JavaScript Console.
(function () {
    "use strict";

    document.addEventListener( 'deviceready', onDeviceReady.bind( this ), false );

    function onDeviceReady() {
       
        document.addEventListener( 'pause', onPause.bind( this ), false );
        document.addEventListener('resume', onResume.bind(this), false);
        document.getElementById("btn").addEventListener("click", BtnClick);
        document.getElementById("Onay").addEventListener("click", OnayClick);
        document.getElementById("Beep").addEventListener("click", BeepClick);
 

       
        
    };

    function onPause() {
        
    };
   

    function onResume() {
       alert("Gene geldi")
    };
    function BtnClick()
    {
        //alert("Merhaba")=
        var mesaj = "Merhaba Dünya";
        var baslık = "Uyarı mesajı";
        var btnname = "okeyyy";
        navigator.notification.alert(mesaj, alertCallBack, baslık, btnname);
        function alertCallBack() {

        }
    }
    function OnayClick() {
        
        var mesaj = "Merhaba Dünya";
        var baslik = "Uyarı mesajı";
        var buttonLabes = "Yes,No";
        navigator.notification.confirm(mesaj,confirmCallBack,baslik,buttonLabes)
        function confirmCallBack(btn) {
            alert("basılan buton"+btn)
        }
    }
    function BeepClick()
    {
        var time = 2;
        navigator.notification.beep(time);
    }
 
} )();