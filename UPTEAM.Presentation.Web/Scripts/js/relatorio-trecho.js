dataTableLangPT = {
    "sEmptyTable": "Nenhum trecho encontrado",
    "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ trechos",
    "sInfoEmpty": "Mostrando 0 até 0 de 0 trechos",
    "sInfoFiltered": "(Filtrados de _MAX_ trechos)",
    "sInfoPostFix": "",
    "sInfoThousands": ".",
    "sLengthMenu": "_MENU_ trecho por página",
    "sLoadingRecords": "Carregando...",
    "sProcessing": "Processando...",
    "sZeroRecords": "Nenhum trecho encontrado",
    "sSearch": "Pesquisar ",
    "oPaginate": {
        "sNext": "Próximo",
        "sPrevious": "Anterior",
        "sFirst": "Primeiro",
        "sLast": "Último"
    },
    "oAria": {
        "sSortAscending": ": Ordenar colunas de forma ascendente",
        "sSortDescending": ": Ordenar colunas de forma descendente"
    },
    "decimal": ".",
    "thousands": ","
}
$(document).ready(function () {
    carregarCiclos();
    carregarGrupos();
    preencherDadosDDL($("#uf"), null, "uf", "uf", "UF", false, false);
});
function carregarCiclos() {
    requisicaoAjaxAsync('GET', 'json', urlbase + 'Ciclo/ObterTodosCiclos', null,
    function (dados) {
        preencherDadosDDL($("#ciclo"), dados.src, "idCiclo", "nomeCiclo", "Ciclo", false, false);
    });
}
$('#ciclo').on('change', function () {
    carregarUfs(this.value);
});
function carregarUfs(idCiclo) {

    var json = { idCiclo: idCiclo };

    requisicaoAjaxAsync('GET', 'json', urlbase + 'Trecho/ObterTodasUfTrechosPorCiclo', JSON.stringify(json),
    function (dados) {
        preencherDadosDDL($("#uf"), dados.src, "uf", "uf", "UF", false,false);
    });
}
function carregarGrupos() {

    requisicaoAjaxAsync('GET', 'json', urlbase + 'Trecho/ObterTodosGrupos', null,
    function (dados) {
        preencherDadosDDL($("#grupo"), dados.src, "idGrupo", "nomeGrupo", "Grupos", false, false);
    });
}
function validarCampos() {
    var erro = "";
    $.each($('input.formulario-relatorio-trecho'), function (i, campo) {
        if (campo.value == "" || campo.value == null)
            erro += "<li>" + campo.placeholder + "</li>";
    });
    if (erro.length > 0) {
        toastr.error("<ul>" + erro + "</ul>");
        return false;
    }
    return true;

}
function pesquisarTrechos() {
    if (validarCampos()) {
        var json = { idCiclo: $('#ciclo').val(), uf: $('#uf').val() }
        requisicaoAjaxAsync('GET', 'json', urlbase + 'Trecho/ObterTrechosPorCicloUF', JSON.stringify(json),
         function (dados) {
             console.log(dados);
             var where = "";
             if ($('#situacao').val() != "NI") {
                 where = "and idGrupo = ?";
             }
             var result = alasql('SELECT * FROM ? where situacao = ? ' + where, [dados.src, $('#situacao').val(), parseInt($('#grupo').val())]);
             var extensaoTotal = alasql('SELECT sum(extensao) FROM ? ', [result]);
             console.log(extensaoTotal);
             montarTabelaRelatorioTrecho(result)
         });
    }
}
function montarTabelaRelatorioTrecho(dados) {
    table = $('#tabela-relatorio-trecho').DataTable({
        responsive: false,
        destroy: true,
        data: dados,
        bInfo: true,
        bFilter: true,
        paging: true,
        deferRender: false,
        language: dataTableLangPT,
        ordering: true,
        columns: [
            { data: "idTrecho", title: "ID", width: "5%" },
            { data: "idTrecho", title: "ID", width: "5%" },
            { data: "br", title: "BR", width: "5%" },
            { data: "nomeTrecho", title: "Trecho", width: "30%" },
            { data: "pista", title: "Pista", width: "10%" },
            { data: "sentido", title: "Sentido", width: "10%" },
            { data: "kmInicial", title: "Km Inicial", width: "10%" },
            { data: "kmFinal", title: "Km Final", width: "10%" },
            { data: "extensao", title: "Extensão", width: "20%" }
        ]
        , columnDefs: [
                    {
                        targets: [0],
                        "render": function (data, type, row) {
                            return "<a href='javascript:void(0)' class='detalhes-control' onclick='abrirTrechos(this);'></a>";
                        },
                        searchable: false
                    },
                    {
                        targets: [4],
                        "render": function (data, type, row) {
                            if (data =='S')
                                return "Simples";

                            return "Dupla";
                        }
                    },
                    {
                        targets: [5],
                        "render": function (data, type, row) {
                            if(data == 'C')
                                return "Crescente";

                            return "Decrescente";
                        }
                    },
                    {
                        targets: [8],
                        "render": function (data, type, row) {                  
                            return "<div class='coluna-destaque'>" + data + " km</div>";
                        }
                    }
        ]
    });
}
function abrirTrechos(button) {
    var tr = $(button).closest("tr");
    var row = table.row(tr);

    if (row.child.isShown()) {
        row.child.hide();
        tr.removeClass("shown");
    }
    else {
        if (table.row('.shown').length) {
            $('.detalhes-control', table.row('.shown').node()).click();
        }
        var html = carregarTrechoStatus();//obterFaixasEquipamento(row.data().id);
        row.child(html).show();
        tr.addClass("shown");
    }
}
function carregarTrechoStatus() {
    //var json = { idTrecho: idTrecho };
    return requisicaoAjax("GET", "html", urlbase + "Trecho/TrechoStatus", null);
}