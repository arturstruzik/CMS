$(document).ready(function () {

    $(document).scroll(function () {

        if ($(window).scrollTop() > 50) {
            $(".fixed-top").css('top', '0px');
            $(".fixed-top").css('position', 'fixed');
        }
        if ($(window).scrollTop() <= 50) {
            $(".fixed-top").css('top', '50px');
            $(".fixed-top").css('position', 'absolute');
        }
    });
});