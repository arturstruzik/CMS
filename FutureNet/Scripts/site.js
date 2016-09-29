$(document).ready(function () {

    $(document).scroll(function () {

        if ($(window).scrollTop() > 90) {
            $(".fixed-top").css('top', '0px');
            $(".fixed-top").css('position', 'fixed');
        }
        if ($(window).scrollTop() <= 90) {
            $(".fixed-top").css('top', '90px');
            $(".fixed-top").css('position', 'absolute');
        }
    });
});