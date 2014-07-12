using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolService.Models;

namespace SchoolService
{
    //http://www.codeproject.com/Articles/123067/A-Simple-Sample-WCF-Service
    class StudentService : IStudentService
    {
        public List<Student> GetAllStudents()
        {
            using (var context = new DatabaseContext())
            {
                return context.Students.ToList();
            }
        }

        public List<Student> GetStudentByID(string studentID)
        {
            throw new NotImplementedException();
        }

        public List<Student> Filter()
        {
            throw new NotImplementedException();
        }
    }
}
