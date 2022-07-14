if (document.cookie.indexOf('signedup=true') == -1) {
    var threeDay = 1000 * 60 * 60 * 24 * 3;
    var expires = new Date((new Date()).valueOf() + (threeDay));
    document.cookie = "signedup=true;expires=" + expires.toUTCString();
    setTimeout(openColorBox, 5000);
}

function openColorBox() {
    $.colorbox({
        iframe: true, overlayClose: false, href: "../newsletter"
    });
}
