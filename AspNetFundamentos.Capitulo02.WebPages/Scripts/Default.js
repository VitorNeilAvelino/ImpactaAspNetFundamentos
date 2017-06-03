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

function inicializar() {
    var servidorP = document.getElementById("servidorP")
    servidorP.addEventListener("click", function (evento) { alternarVisibilidade(evento.srcElement.dataset.destino); });
}

function alternarVisibilidade(elementoId) {
    var elemento = document.getElementById(elementoId);

    if (elemento.style.display == "none") {
        elemento.style.display = "inline-block";
    }
    else {
        elemento.style.display = "none";
    }
}