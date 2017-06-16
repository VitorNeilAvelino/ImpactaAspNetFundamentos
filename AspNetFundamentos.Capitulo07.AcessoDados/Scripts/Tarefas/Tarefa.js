$(document).ready(inicializar);

function inicializar() {
    $("#Prioridade").change(obterTarefasNaoConcluidas);
}

function obterTarefasNaoConcluidas() {
    $.ajax({
        url: "/Tarefas/ObterNaoConcluidas",
        type: "get",
        data: { prioridade: $("#Prioridade").val() }
    })
    .done(function (response) { exibirTarefasNaoConcluidas(response) }) // success
    .fail(function (response) { }) // error
    .always(function (response) { }); // complete
}

function exibirTarefasNaoConcluidas(response) {
    if (response === "") {
        $("#tarefasPopover").popover("destroy");
        return;
    }

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