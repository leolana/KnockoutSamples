using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ProjetoKnockout.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CEP { get; set; }
        public List<Course> Courses { get; set; }
        // estava dando o erro : The underlying connection was closed: The connection was closed unexpectedly. 
        //Quando a propriedade estava definida desta maneira: public virtual List<Course> Courses { get; set; }

    }
}
