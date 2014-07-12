var app;
if (typeof app === "undefined") {
    app = {};
}

app.home_index = (function (my) {
    "use strict";

    var grid,
    criarGrid = function () {
        jQuery(grid.id).jqGrid({
            datatype: "json",
            url: grid.urlCarregaGrid,
            width: grid.width,
            height: 400,
            scrollerbar: true,
            colNames: ["Nome", "Sobrenome", "Idade"],
            colModel: [
                { name: "Nome", index: "Nome", width: 200, sortable: true, search: true, stype: 'text' },
                { name: "Sobrenome", index: "Sobrenome", align: "center", width: 150, sortable: true, search: true, stype: 'text' },
                { name: "Idade", index: "Idade", align: "center", width: 120, sortable: true, search: true, stype: 'text' }

	        ],
            rowNum: 10,
            rowList: [10, 20, 30],
            pager: grid.pager,
            sortname: 'tipo',
            sortorder: "asc",
            mtype: "GET",
            caption: grid.caption,
            viewrecords: true,
            loadonce: true
        });
        jQuery(grid.id).jqGrid('navGrid', grid.pager, { edit: false, add: false, del: false, search: false, refresh: false, sortable: true });

    },
    init = function (options) {
        grid = options.grid;

        criarGrid();

       
    };

    if (!my.init) {
        my.init = init;
    }

    return my;
} (app.home_index || {}));