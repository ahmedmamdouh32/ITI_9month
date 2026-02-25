$(document).ready(function () {

    $(".side-menu").hover(
        function () {
            $(this).stop().animate({ left: "0px" }, 100);
        },
        function () {
            $(this).stop().animate({ left: "-260px" }, 100);
        }
    );

    $(".title").click(function () {

        var content = $(this).next(".content");

        $(".content").not(content).slideUp();

        content.slideToggle();
    });

});