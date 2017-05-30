//var dts = window.document.getElementsByTagName("dt");

//for (var i = 0; i < dts.length; i++) {
//    //dts[i].addEventListener("click", alternarVisibilidade);
//    dts[i].addEventListener("click", function (e) { alternarVisibilidade(e.source) });
//}

var servidorP = document.getElementById("servidorP")
servidorP.addEventListener("click", function (evento) { alternarVisibilidade(evento.srcElement.dataset.destino); });

function alternarVisibilidade(elementoId) {
    var elemento = document.getElementById(elementoId);

    if (elemento.style.display == "none") {
        elemento.style.display = "block";
    }
    else {
        elemento.style.display = "none";
    }
}