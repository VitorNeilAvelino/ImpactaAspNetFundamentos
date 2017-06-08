$(document).ready(inicializar);

function inicializar() {
    $("#Nome").focus();
    $(".alert-success").delay(2000).fadeTo(500, 0).slideUp(500);
}