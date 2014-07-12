var app;
if (typeof app === "undefined") {
    app = {};
}

app.pessoa_form = (function (my) {
    "use strict";

    ko.bindingHandlers.masked = {
        init: function (element, valueAccessor, allBindings) {
            var mask = allBindings().mask || {};
            $(element).mask(mask);
        }
    };

    ko.bindingHandlers.datepicker = {
        init: function (element, valueAccessor) {
            $(element).datepicker();
        }
    };

    var elementosTela, camposTela,
    StudentViewModel = function () {
        var self = this;
        self.studentId = ko.observable();
        self.studentName = ko.observable("");
        self.dateOfBirth = ko.observable("");
        self.phone = ko.observable("");
        self.address = ko.observable("");
        self.cep = ko.observable("");
    },
    init = function (options) {
        elementosTela = options.elementos;
        camposTela = options.campos;

        ko.applyBindings(new StudentViewModel());
    };

    if (!my.init) {
        my.init = init;
    }

    return my;
} (app.pessoa_form || {}));