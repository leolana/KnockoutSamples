using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoKnockout.Entities;

namespace ProjetoKnockout.Models
{
    public class StudentFormViewModel : ModelBase
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CEP { get; set; }
        public List<Course> Courses { get; set; }

        public override void LoadDefaultValues()
        {
            base.LoadDefaultValues();
        }

        
    }
}