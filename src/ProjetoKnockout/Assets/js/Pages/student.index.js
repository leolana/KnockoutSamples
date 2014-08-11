var app;
if (typeof app === "undefined") {
    app = {};
}

app.student_index = (function (my) {
    "use strict";

    var grid,
        StudentViewModel = function (studentsInitials) {
            var self = this;

            self.students = ko.observableArray(studentsInitials);
            self.editStudent = function (course) {
                window.location.href = grid.editUrl + "/" + course.CourseID;
            };
            self.removeStudent = function (student) {

                $.ajax({
                    url: grid.deleteUrl,
                    data: JSON.stringify({ id: student.StudentID }),
                    contentType: 'application/json; charset=utf-8',
                    type: 'POST',
                    dataType: 'json',
                    success: function (data) {
                        if (data.success) {
                            self.students.remove(course);
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
        LoadStudentsAjax = function () {
            $.getJSON(grid.searchUrl, function (data) {
                ko.applyBindings(new StudentViewModel(data));
            });
        },
        init = function (options) {
            grid = options.grid;
            LoadStudentsAjax();
        };

    if (!my.init) {
        my.init = init;
    }

    return my;

}(app.student_index || {}));