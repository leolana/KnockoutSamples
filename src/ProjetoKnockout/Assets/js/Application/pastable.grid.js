var app = {};

app.pastable_grid = (function (my) {
    "use strict";

    var Enums = function () {
        var ATTRIBUTE = {
            ReadOnly: { value: "read" },
            Write: { value: "write" }
        },
        TYPEDATA = {
            Button: { type: "button" },
            String: { type: "string" },
            Number: { type: "number" }
        };
    },
    ClipPastable = function (settings, text) {
        var clipRows = [],
            columnNames = [],
            columnAttributes = [],
            numberColumn = 0;
        this.error = "";
        this.arrayObjects = [];

        this.identifyAttributesWriteColumns = function () {
            for (var columnName in settings) {
                if (settings[columnName].readOrWrite === Enums.ATTRIBUTE.Write) {
                    var columnObj = settings[columnName].sName;
                    columnNames.push(columnObj);
                }
            }
        };
        this.separateClipArray = function () {
            clipRows = text.split('\n');
            for (var i = 0; i < clipRows.length - 1; i++) {
                clipRows[i] = clipRows[i].split('\t');
            }
        };
        this.countColumns = function () {
            /*for (var columnName in settings) {
            if (settings[columnName].readOrWrite === Enums.ATTRIBUTE.Write) {
            numberColumn++;
            }
            }*/
            return columnNames.length;
        };
        this.validationFormatClip = function () {
            if (text.indexOf('\n') === -1) {
                this.error = "Os dados não estão no formato correto."
                return true;
            }
            
            return false;
        };
        this.validationLengthClip = function () {
            for (var i = 0; i < clipRows.length - 1; i++) {
                if (clipRows[i].length != numberColumn) {
                    this.error = "Não possui a quantidade de colunas esperadas na linha " + (i + 1) + "."
                    return true;
                }
            }
            return false;
        };
        this.validationClipDatas = function () {
            for (var i = 0; i < clipRows.length - 1; i++) {
                for (var j = 0; j < clipRows[i].length; j++) {
                    if (settings[columnNames[j]].typeData === Enums.TYPEDATA.Number && !clipRows[i][j].isNumber()) {
                        this.error = "O valor da coluna " + settings[columnNames[j]].nameColumn + ": " + clipRows[i][j] + ", não está no formato correto."
                        return true;
                    }
                }
            }
            return false;
        };
        this.validationClip = function () {
            if (this.validationFormatClip())
                return true;
            if (this.validationLengthClip())
                return true;
            if (this.validationClipDatas())
                return true;
            return false;
        };
        this.createClip = function () {
            this.separateClipArray();
            this.identifyAttributesWriteColumns();
            this.countColumns();
            if (this.validationClip()) {
                return false;
            }

            for (var i = 0; i < clipRows.length - 1; i++) {
                var object = [];
                for (var j = 0; j < clipRows[i].length; j++) {
                    var columnObj = {
                        Name: columnNames[j],
                        Value: clipRows[i][j]
                    };
                    object.push(columnObj);
                }
                this.arrayObjects.push(object);
            }

            return true;
        };
    },
    init = function (options) {
        var ClipPastable = new ClipPastable(options.settings, options.text);

    };

    if (!my.init) {
        my.init = init;
    }

    return my;

}(app.pastable_grid || {}));

/*
    Considerações do AD para a fauncionalidade pastable
    Estudar os conceitos
    http://en.wikipedia.org/wiki/SOLID_(object-oriented_design)
    http://en.wikipedia.org/wiki/First-class_function
    http://www.antiifcampaign.com/
    E validar o código no jsLint
    http://www.jslint.com/

    Retornar este objeto
    {
	    operacao: {
		    situacao: "sucesso",
		    erro: {
			    mensagem: "teste"
		    }
	    },
	    clips: [
	    ]
    }
    ------------------------

    displayError: function(error) { boot... }

    -------------------------------

    clipable.init({

	    columns: [ ... ],
	    gridId: "",
	    elementToPaste: "",
	    displayError: function(error) {
		    ///bootbox.alert(error);
		    $("#div").text(error);
	    }
    });	
*/