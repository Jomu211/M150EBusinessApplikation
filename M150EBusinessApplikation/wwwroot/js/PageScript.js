function getImage(id) {
    img = document.getElementById(id);
    imgData = getBase64Image(img);
    sessionStorage.setItem("imgData", imgData);
}
function getBase64Image(img) {
    var canvas = document.createElement("canvas");
    canvas.width = 1400;
    canvas.height = 700;

    var ctx = canvas.getContext("2d");
    ctx.drawImage(img, 0, 0);

    var dataURL = canvas.toDataURL("image/png");

    return dataURL.replace(/^data:image\/(png|jpg);base64,/, "");
}
function setImage() {
    var dataImage = sessionStorage.getItem("imgData");
    img = document.getElementById('replaceImage');
    img.src = "data:image/png;base64," + dataImage;
}
function initializeCarousel() {
    $('#carousel').carousel({ interval: 2000 });
    $('#carousel-prev').click(
        () => $('#carousel').carousel('prev'));
    $('#carousel-next').click(
        () => $('#carousel').carousel('next'));

}
function handleInvalid() {
    input = document.getElementsByClassName("champinput");
    if (!$(this).val()) {
        $(this).css("border-color", "#Ff2f2f");
    } else {
        $(this).css("border-color", "transparent");
    }

}
function wrongLogin(invalid) {
    var el = document.getElementsByClassName("wrongLogin");

    if (invalid == true) {
        wrongLogin = document.getElementsByClassName("wrongLogin");
        $(wrongLogin).css("display", "none");
    }
    else {
        if ($(el).css("display", "none")) {
            wrongLogin = document.getElementsByClassName("wrongLogin");
            $(wrongLogin).css("display", "inline");
        } else {
            wrongLogin = document.getElementsByClassName("wrongLogin");
            $(wrongLogin).css("display", "none");
        }
    }
}

$(document).ready(function () {
    $("body").on("mouseover", ".adminBox", function () {
        $(".adminBox").find(".frontAdmin").show();
        $(".adminBox").find(".backAdmin").hide();

        $(this).find(".frontAdmin").hide();
        $(this).find(".backAdmin").show();
    });

    var click = true;
    $("body").on("click", ".championBox", function () {
        if ($(this).hasClass("clickableFront")) {
            var id = $(this).data("champid");
            flipAnim(id);
            click = true;
        }
        else if (!$(this).find(".back").hasClass("backIsActive")) {
            var gray = 'grayscale(100%)';
            var noGray = 'grayscale(0%)';
            $('.front')
                .css('filter', noGray)
                .css('webkitFilter', noGray)
                .css('mozFilter', noGray)
                .css('oFilter', noGray)
                .css('msFilter', noGray);

            $(this).find('.front')
                .css('filter', gray)
                .css('webkitFilter', gray)
                .css('mozFilter', gray)
                .css('oFilter', gray)
                .css('msFilter', gray);



            var pos = $(this).offset();
            $('.guessingButton').hide();
            $(this).find('.guessingButton').show();
            $('.guessingButton').offset(pos);
        }
    });
    $("body").on("mouseover", ".championBox", function () {
        if ($(this).hasClass("frontAnim")) {
            $(this).removeClass("frontAnim");
            var id = $(this).data("champid");
            var el = document.getElementById(id);
            $(el).css("animation-play-state", "paused");
            $(el).find(".front").css("transform", "scale(1.1)");
            click = false;
        }

    });

    $("body").on("mouseleave", ".championBox", function () {
        if (!click) {
            if ($(this).hasClass("clickableFront")) {
                if (!$(this).find(".back").hasClass("backIsActive")) {
                    $(this).addClass("frontAnim");
                    var id = $(this).data("champid");
                    var el = document.getElementById(id);
                    $(el).css("animation-play-state", "running");
                    $(el).find(".front").css("transform", "scale(1)");
                }
            }
        }
    });

});

function flipAnim(id) {
    var el = document.getElementById(id);

    $(el).css("-webkit-transform", "rotateY(180deg)")
        .css("-moz-transform", "rotateY(180deg)")
        .css("-o-transform", "rotateY(180deg)")
        .css("transform", "rotateY(180deg)");

    $(el).find(".front").css("opacity", "0");
    $(el).find(".back").addClass("backIsActive");

    $('.guessingButton').hide();
    $('.front')
        .css('filter', "grayscale(0%)")
        .css('webkitFilter', "grayscale(0%)")
        .css('mozFilter', "grayscale(0%)")
        .css('oFilter', "grayscale(0%)")
        .css('msFilter', "grayscale(0%)");
}

function flipClickable(id) {
    var el = document.getElementById(id);
    if (!$(el).find(".back").hasClass("backIsActive")) {

        $(el).addClass("frontAnim");
        $(el).addClass("clickableFront");
    }
}
function resultOutput(result) {
    if (result == null) {
        $('body').find(".resultOutput").css("color", "rgb(33, 37, 41)");

    }
    else if (result == true) {
        $('body').find(".resultOutput").css("color", "green");

    }
    else {
        $('body').find(".resultOutput").css("color", "red");

    }
}

function flipAll() {
    $(".championBox")
        .css("-webkit-transform", "rotateY(0deg)")
        .css("-moz-transform", "rotateY(0deg)")
        .css("-o-transform", "rotateY(0deg)")
        .css("transform", "rotateY(0deg)");

    $(".championBox").find(".front").css("opacity", "1");
    $(".championBox").find(".back").removeClass("backIsActive");
    $(".championBox").removeClass("clickableFront");
    $(".championBox").removeClass("frontAnim");
    $(".championBox").css("animation-play-state", "running");
    $('.guessingButton').hide();
    $('.front')
        .css('filter', "grayscale(0%)")
        .css('webkitFilter', "grayscale(0%)")
        .css('mozFilter', "grayscale(0%)")
        .css('oFilter', "grayscale(0%)")
        .css('msFilter', "grayscale(0%)");

}

function addCursorDefault(key) {
    var element = $('li').filter(function () {
        return $(this).text().trim() === key;
    });

    if (element.length > 0) {
        element.closest(".child").css('cursor', 'default');
    }
}

function startGame() {
    $("body").find(".startGameContainer").css("display", "none")
        .css("visibility", "hidden")
        .css("width", "0px")
        .css("height", "0px");
    $("body").find(".outterContainer").css("display", "block")
        .css("visibility", "visible");

}
