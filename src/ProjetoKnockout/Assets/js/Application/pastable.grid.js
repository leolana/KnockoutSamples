var app;
if (typeof app === "undefined") {
    app = {};
}

app.pastable_grid = (function (my) {
    "use strict";

    var ClipPastable = function (settingsColumn, text) {
        var text = text;
        var settings = settingsColumn;
        var clipRows = [];
        var columnNames = [];
        var columnAttributes = []
        this.error = "";
        this.arrayObjects = [];
        var numberColumn = 0;

        this.identifyAttributesWriteColumns = function () {
            for (var columnName in settings) {
                if (settings[columnName].readOrWrite === app.enums.ATTRIBUTE.Write) {
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
            if (settings[columnName].readOrWrite === app.enums.ATTRIBUTE.Write) {
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
                    if (settings[columnNames[j]].typeData === app.enums.TYPEDATA.Number && !clipRows[i][j].isNumber()) {
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
    };

    if (!my.ClipPastable) {
        my.ClipPastable = ClipPastable;
    }

    return my;

} (app.pastable_grid || {}));