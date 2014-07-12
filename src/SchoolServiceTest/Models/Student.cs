using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using SchoolService.Models;

namespace SchoolService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentId { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string CEP { get; set; }
        [DataMember]
        public List<Course> Courses { get; set; }
        // estava dando o erro : The underlying connection was closed: The connection was closed unexpectedly. 
        //Quando a propriedade estava definida desta maneira: public virtual List<Course> Courses { get; set; }

    }
}
