using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SchoolService.Models
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int CourseID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public DateTime CompletionDate { get; set; }
        [DataMember]
        public virtual List<Student> Students { get; set; }
        [DataMember]
        public List<int> StudentsIDs { get; set; }
    }
}
