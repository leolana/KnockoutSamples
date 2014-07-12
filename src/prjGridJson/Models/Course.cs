using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjGridJson.Models
{
    class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public DateTime CompletionDate { get; set; }
        public virtual List<Student> Students { get; set; }
        public List<int> StudentsIDs { get; set; }
    }
}
