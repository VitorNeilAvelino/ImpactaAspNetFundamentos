$(document).ready(inicializar);

function inicializar() {
    $("#Prioridade").change(obterTarefasNaoConcluidas);
}

function obterTarefasNaoConcluidas() {
    $.ajax({
        url: "/Tarefas/ObterNaoConcluidas",
        method: "get", // method ou type - get é o default
        data: { prioridade: $("#Prioridade").val() }
    })
    .done(function (response) { exibirTarefasNaoConcluidas(response) }) // success
    .fail(function (response) { }) // error
    .always(function (response) { }); // complete
}

function exibirTarefasNaoConcluidas(response) {
    //$("#tarefasPopover").popover("destroy");

    $("#tarefasPopover")
        .popover("destroy")
        .popover({ content: obterGridTarefas(response), html: true })
        .popover("show");
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