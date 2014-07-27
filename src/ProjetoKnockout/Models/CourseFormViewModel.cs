using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoKnockout.Models
{
    public class CourseFormViewModel : ModelBase
    {
        public int CourseID { get; set; }

        public string CourseName { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}