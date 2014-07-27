var app;
if (typeof app === "undefined") {
    app = {};
}

app.course_index = (function (my) {
    "use strict";

    var grid,
        CourseViewModel = function (coursesInitials) {
            var self = this;

            self.courses = ko.observableArray(coursesInitials);
            self.editCourse = function (course) {
                window.location.href = grid.editUrl + "/" + course.CourseID;
            };
            self.removeCourse = function (course) {
                
                $.ajax({
                    url: grid.deleteUrl,
                    data: JSON.stringify({ id: course.CourseID }),
                    contentType: 'application/json; charset=utf-8',
                    type: 'POST',
                    dataType: 'json',
                    success: function (data) {
                        if (data.success) {
                            self.courses.remove(course);
                        } else {
                            alert(data.message);
                        }
                    },
                    error: function () {
                        alert('error');
                    }
                });
            };
        },
        PasteGrid = function () {
            $(document).on('paste', function (e) {
                if (e && e.originalEvent && e.originalEvent.clipboardData) {
                    var clip = new app.pastable_grid.ClipPastable(grid.Columns, e.originalEvent.clipboardData.getData('Text'));
                    if (clip.createClip()) {
                        SavePasteGrid(clip.arrayObjects);
                    }
                    else {
                        bootbox.alert(clip.error);
                    }
                } else {
                    setTimeout(function () {
                        var clip = new app.pastable_grid.ClipPastable(grid.Columns, $('#PasteGrid').val());
                        $('#PasteGrid').val('');
                        if (clip.createClip()) {
                            SavePasteGrid(clip.arrayObjects);
                        }
                        else {
                            bootbox.alert(clip.error);
                        }
                    }, 100);
                }
            });

            $('#PasteGrid').on('paste', function (e) {
                if (e && e.originalEvent && e.originalEvent.clipboardData) {
                    var clip = new app.pastable_grid.ClipPastable(grid.Columns, e.originalEvent.clipboardData.getData('Text'));
                    if (clip.createClip()) {
                        SavePasteGrid(clip.arrayObjects);
                    }
                    else {
                        //bootbox.alert(clip.error);
                        displayError(clip.error);
                    }
                    return false;
                } else {
                    setTimeout(function () {
                        var clip = new app.pastable_grid.ClipPastable(grid.Columns, $('#PasteGrid').val());
                        $('#PasteGrid').val('');
                        if (clip.createClip()) {
                            SavePasteGrid(clip.arrayObjects);
                        }
                        else {
                            bootbox.alert(clip.error);
                        }
                    }, 100);
                }

            });
        },
        SavePasteGrid = function (columnObjects) {
            $.ajax({
                url: grid.savePasteGridUrl,
                data: JSON.stringify(columnObjects),
                contentType: 'application/json; charset=utf-8',
                type: 'POST',
                dataType: 'json',
                success: function (data) {
                    if (data.success) {
                        oTable.fnDraw();
                    } else {
                        bootbox.alert(data.message);
                    }
                },
                error: function () {
                    bootbox.alert('error');
                }
            });
        },
        LoadCoursesAjax = function () {
            $.getJSON(grid.searchUrl, function (data) {
                ko.applyBindings(new CourseViewModel(data));
            });
        },
        init = function (options) {
            grid = options.grid;
            PasteGrid();
            LoadCoursesAjax();
        };

    if (!my.init) {
        my.init = init;
    }

    return my;

}(app.course_index || {}));