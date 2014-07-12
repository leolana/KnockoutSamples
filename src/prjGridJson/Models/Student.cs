using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjGridJson.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CEP { get; set; }
    }
}