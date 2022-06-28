function success(title, text, type, url) {
    swal(
        title,
        text,
        type,
    ).then(function () {
        window.location.href = url;
    })
}

function info(title, text, type) {
    swal(
        title,
        text,
        type,
    ).then(function () {

    })
}

function warning(title, text, type) {
    swal(
        title,
        text,
        type,
    ).then(function () {

    })
}