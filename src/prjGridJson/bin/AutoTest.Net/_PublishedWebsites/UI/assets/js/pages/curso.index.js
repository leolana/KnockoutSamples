var app;
if (typeof app === "undefined") {
    app = {};
}

app.curso_index = (function (my) {
    "use strict";

    var grid, elementosTela,
    editar = function (rowId) {
        window.location.href = grid.viewUrlBase + "/" + rowId;
    },
    excluir = function (rowId) {
        bootbox.confirm("Deseja realmente excluir este Curso?", function (result) {
            if (result) {
                $.ajax({
                    url: grid.urlDelete,
                    data: JSON.stringify({ id: rowId }),
                    contentType: 'application/json; charset=utf-8',
                    type: 'POST',
                    dataType: 'json',
                    success: function (data) {
                        if (data.success) {
                            jQuery(grid.id).delRowData(rowId);
                            jQuery(grid.id).trigger('reloadGrid');
                        }
                    },
                    error: function () {
                        bootbox.alert('Não deu certo!');
                    }
                });
            }
        });
    },
    criarGrid = function () {
        jQuery(grid.id).jqGrid({
            datatype: "json",
            url: grid.urlCarregaGrid,
            width: 980,
            height: 400,
            scrollerbar: true,
            colNames: ["", "ID", "Sigla", "Data de Conclusão"],
            colModel: [
                { name: "actions", index: "actions", width: 100, resizable: false, sortable: false, align: "center", search: false },
                { name: "CursoID", index: "CursoID", key: true, width: 50, sortable: true, search: true, stype: 'text' },
                { name: "CursoNome", index: "CursoNome", width: 150, sortable: true, search: true, stype: 'text' },
                { name: "DataConclusao", index: "DataConclusao", width: 150, sortable: true, search: true, stype: 'date', sorttype: 'date', datefmt: 'd-m-Y' }
	        ],
            rowNum: 10,
            rowList: [10, 20, 30],
            pager: grid.pager,
            sortname: 'CursoID',
            sortorder: "asc",
            mtype: "GET",
            caption: grid.caption,
            viewrecords: true,
            loadonce: true,
            gridComplete: function () {
                var ids = jQuery(grid.id).jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var idRecord = ids[i];
                    var editar = "<button type='button' class='JQGridActView btn btn-link btn-xs' data-toggle='tooltip' title='Editar' onclick=\"app.curso_index.editar('" + idRecord + "');\" >" + '<span class="glyphicon glyphicon-pencil"></span>' + '</button>';
                    var excluir = "<button type='button' class='JQGridActView btn btn-link btn-xs' data-toggle='tooltip' title='Remover' onclick=\"app.curso_index.excluir('" + idRecord + "');\" >" + '<span class="glyphicon glyphicon-trash"></span>' + '</button>';

                    jQuery(grid.id).jqGrid('setRowData', ids[i], { actions: editar + " " + excluir });
                }
            }
        });
        jQuery(grid.id).jqGrid('navGrid', grid.pager, { edit: false, add: false, del: false, search: false, refresh: false, sortable: true });

    },
    init = function (options) {
        grid = options.grid;
        elementosTela = options.elementos;
        criarGrid();
        $(elementosTela.btnPesquisar).click(function () {
            $.ajax({
                url: elementosTela.urlSearchPessoa,
                data: JSON.stringify({ id: $(elementosTela.pessoaID).val() }),
                contentType: 'application/json; charset=utf-8',
                type: 'POST',
                dataType: 'json',
                success: function (data) {
                    if (data.success) {
                        jQuery(grid.id).trigger('reloadGrid');
                    }
                },
                error: function () {
                    bootbox.alert('Não deu certo!');
                }
            });
        });
    };

    if (!my.init) {
        my.init = init;
        my.editar = editar;
        my.excluir = excluir;
    }

    return my;
} (app.curso_index || {}));