var mydiv = document.getElementById('mydiv');
var AddWidth = document.getElementById("AddWidth");
var MinWidth = document.getElementById("MinWidth");
var AddHeight = document.getElementById("AddHeight");
var MinHeight = document.getElementById("MinHeight");
var CircleDiv = document.getElementById("CircleDiv");
var ResetDiv = document.getElementById("ResetDiv");

// Default values
var defaultWidth = 200;
var defaultHeight = 200;
var step = 20;

// Increase width
// AddWidth.onclick = function () {
//     var currentWidth = mydiv.offsetWidth;
//     mydiv.style.width = (currentWidth + step) + "px";
// };

// Decrease width
// MinWidth.onclick = function () {
//     var currentWidth = mydiv.offsetWidth;
//     if (currentWidth > step)
//         mydiv.style.width = (currentWidth - step) + "px";
// };

// Increase height
// AddHeight.onclick = function () {
//     var currentHeight = mydiv.offsetHeight;
//     mydiv.style.height = (currentHeight + step) + "px";
// };

// Decrease height
// MinHeight.onclick = function () {
//     var currentHeight = mydiv.offsetHeight;
//     if (currentHeight > step)
//         mydiv.style.height = (currentHeight - step) + "px";
// };

// Make circle
// CircleDiv.onclick = function () {
//     mydiv.style.borderRadius = "50%";
// };

// Reset div
// ResetDiv.onclick = function () {
//     mydiv.style.width = defaultWidth + "px";
//     mydiv.style.height = defaultHeight + "px";
//     mydiv.style.borderRadius = "0px";
// };




$('#AddWidth').on('click', function () {
    $('#mydiv').width($('#mydiv').width() + step);
})

$('#MinWidth').on('click', function () {
    if ($('#mydiv').width() > step) {
        $('#mydiv').width($('#mydiv').width() - step);
    }
})

$("#AddHeight").on('click', function () {
    $("#mydiv").height($("#mydiv").height() + step);
});

$("#MinHeight").on('click', function () {
    if ($("#mydiv").height() > step)
        $("#mydiv").height($("#mydiv").height() - step);
});

$('#CircleDiv').on('click', function () {
    $('#mydiv').css('border-radius', '50%');
})

$('#ResetDiv').on('click', function () {
    $('#mydiv').css('border-radius', '0px');
    $('#mydiv').css('height', defaultHeight);
    $('#mydiv').css('width', defaultWidth);
})
