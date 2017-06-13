$(document).ready(inicializar);

function inicializar() {
    $("#Prioridade").change(obterTarefasNaoConcluidas);
}

function obterTarefasNaoConcluidas() {
    $("#tarefasPopover").popover("destroy");

    $.ajax({
        url: "/Tarefas/ObterNaoConcluidas",
        data: { prioridade: $("#Prioridade").val() },
        success: function (response) {
            exibirTarefasNaoConcluidas(response);
        }
    });
}

function exibirTarefasNaoConcluidas(response) {
    $("#tarefasPopover").popover({ content: obterGridTarefas(response), html: true }).popover("show");
}

function obterGridTarefas(response) {
    var html = "<div class='row'>";

    $(response).each(
        function (i) {
            html += "<div class='col-md-6'>" + response[i].Nome + "</div>";
            html += "<div class='col-md-6'>" + response[i].Observacoes + "</div>";
        }
        );

    return html + "</div>";
}