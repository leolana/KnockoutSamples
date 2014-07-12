var app;
if (typeof app === "undefined") {
    app = {};
}

app.curso_form = (function (my) {
    "use strict";

    var elementosTela, camposTela, viewModel = {
    },
    criarCampos = function () {
        $(camposTela.dataConclusao).datepicker();
        $(camposTela.dataConclusao).mask("99/99/9999");
        $("select.select2").select2({
            allowClear: true
        });
    },
    init = function (options) {
        elementosTela = options.elementos;
        camposTela = options.campos;
        criarCampos();
    };

    if (!my.init) {
        my.init = init;
    }

    return my;
} (app.curso_form || {}));