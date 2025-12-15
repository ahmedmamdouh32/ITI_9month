document.body.addEventListener("keydown",
    function(e){
        console.log(e);
        // alert(e);
        var  alertMessage = "";
        alertMessage+=`Ascii : ${e.keyCode}`;
        if(e.altKey===true){
            alertMessage+= ", Alt Key";
        }
        else if(e.ctrlKey === true){
            alertMessage+=", Ctrl Key";
        }
        else if(e.shiftKey === true){
            alertMessage+=", Shift Key";
        }
        alert(alertMessage);
    }
)


document.addEventListener("contextmenu", function (e) {
    e.preventDefault();   // optional: block browser menu
    console.log("Right Clicked !");
});