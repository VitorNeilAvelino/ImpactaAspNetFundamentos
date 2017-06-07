//var dts = window.document.getElementsByTagName("dt");

//for (var i = 0; i < dts.length; i++) {
//    //dts[i].addEventListener("click", alternarVisibilidade);
//    dts[i].addEventListener("click", function (e) { alternarVisibilidade(e.source) });
//}

// 1o. assim:
//var servidorP = document.getElementById("servidorP")
//servidorP.addEventListener("click", function (evento) { alternarVisibilidade(evento.srcElement.dataset.destino); });

// 2o. depois refatorar:
window.onload = inicializar;
//document.onload = function () { inicializar(); } // não funciona...
//document.onload = inicializar; // também não...
//document.addEventListener("DOMContentLoaded", function () { alertar(); }); // não...
//document.addEventListener("DOMContentLoaded", inicializar); // funciona se o script for adicionado no fundo do body.

function inicializar() {
    var servidorP = document.getElementById("servidorP");
    servidorP.addEventListener("click", function (evento) { alternarVisibilidade(evento.srcElement.dataset.destino); });
    //servidorP.addEventListener("click", alertar); // delegate do evento click para o método alertar
    //servidorP.addEventListener("click", function () { alertar(); }); // sem o function o alertar é executado imediatamente.
    //servidorP.addEventListener("click", alternarVisibilidade("servidorUl")); // addEventListener não aceita que o método associado ao evento possua parâmetros.
}

function alternarVisibilidade(elementoId) {
    var elemento = document.getElementById(elementoId);

    if (elemento.style.display === "none") {
        elemento.style.display = "inline-block";
    }
    else {
        elemento.style.display = "none";
    }
}

//function alertar() {
//    alert("Take the red pill.");
//}