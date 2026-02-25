(function ($) {

    $.fn.gallery = function () {

        if ($("#preview").length === 0) {
            $("body").append('<img id="preview" style="position:absolute; width:350px; display:none; pointer-events:none; border:3px solid black; border-radius:10px;">');
        }
        this.mousemove(function (e) {

            $("#preview")
                .attr("src", $(this).attr("src"))
                .css({
                    top: e.pageY + 15 + "px",
                    left: e.pageX + 15 + "px"
                })
                .show();
        });

        this.mouseleave(function () {
            $("#preview").hide();
        });
        return this;
    };
})(jQuery);

$(document).ready(function () {
    $('.hover-img').gallery();
});