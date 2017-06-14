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

function obterGridTarefas(tarefas) {
    var html = "<table class='table table-striped'>";

    $(tarefas).each(
        function (i) {
            html += "<tr>";
            html += "<td>" + tarefas[i].Nome + "</td>";
            html += "<td>" + tarefas[i].Observacoes + "</td>";
            html += "</tr>";
        }
    );

    return html + "</table>";
}