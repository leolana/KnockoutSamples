var app;
if (typeof app === "undefined") {
    app = {};
}

app.pessoa_index = (function (my) {
    "use strict";

    var grid,
    editar = function (rowId) {
        window.location.href = grid.viewUrlBase + "/" + rowId;
    },
    excluir = function (rowId) {
        bootbox.confirm("Deseja realmente excluir esta Pessoa?", function (result) {
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
            colNames: ["", "ID", "Nome", "Data de Nascimento", "Telefone", "Endereço", "CEP"],
            colModel: [
                { name: "actions", index: "actions", width: 100, resizable: false, sortable: false, align: "center", search: false },
                { name: "PessoaId", index: "PessoaId", key: true, width: 50, sortable: true, search: true, stype: 'text' },
                { name: "Nome", index: "Nome", width: 150, sortable: true, search: true, stype: 'text' },
                { name: "DataNasc", index: "DataNasc", width: 150, sortable: true, search: true, stype: 'date', sorttype: 'date', datefmt: 'd-m-Y' },
                { name: "Telefone", index: "Telefone", align: "center", width: 100, sortable: true, search: true, stype: 'text' },
                { name: "Endereco", index: "Endereco", align: "center", width: 200, sortable: true, search: true, stype: 'text' },
                { name: "Cep", index: "Cep", align: "center", width: 120, sortable: true, search: true, stype: 'text' }
	        ],
            rowNum: 10,
            rowList: [10, 20, 30],
            pager: grid.pager,
            sortname: 'tipo',
            sortorder: "asc",
            mtype: "GET",
            caption: grid.caption,
            viewrecords: true,
            loadonce: true,
            gridComplete: function () {
                var ids = jQuery(grid.id).jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var idRecord = ids[i];
                    var editar = "<button type='button' class='JQGridActView btn btn-link btn-xs' data-toggle='tooltip' title='Editar' onclick=\"app.pessoa_index.editar('" + idRecord + "');\" >" + '<span class="glyphicon glyphicon-pencil"></span>' + '</button>';
                    var excluir = "<button type='button' class='JQGridActView btn btn-link btn-xs' data-toggle='tooltip' title='Remover' onclick=\"app.pessoa_index.excluir('" + idRecord + "');\" >" + '<span class="glyphicon glyphicon-trash"></span>' + '</button>';

                    jQuery(grid.id).jqGrid('setRowData', ids[i], { actions: editar + " " + excluir });
                }


            }
        });
        jQuery(grid.id).jqGrid('navGrid', grid.pager, { edit: false, add: false, del: false, search: false, refresh: false, sortable: true });

    },
    init = function (options) {
        grid = options.grid;

        criarGrid();


    };

    if (!my.init) {
        my.init = init;
        my.editar = editar;
        my.excluir = excluir;
    }

    return my;
} (app.pessoa_index || {}));