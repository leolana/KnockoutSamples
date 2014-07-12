using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SchoolService;
using SchoolService.Models;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace SchoolServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    public class StudentService : IStudentService
    {
        public List<Student> GetAllStudents()
        {
            using (var context = new DatabaseContext())
            {
                var lstStudent = context.Students.ToList();
                return lstStudent;
            }
        }

        public Student GetStudentByID(int studentID)
        {
            using (var context = new DatabaseContext())
            {
                return context.Students.Where(x => x.StudentId == studentID).SingleOrDefault();
            }
        }

        public bool Save(Student student)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    context.GetValidationErrors();
                    return false;
                }
                catch (DbUpdateException ex)
                {
                    context.GetValidationErrors();
                    return false;
                }
                return true;
            }
        }

        public bool Delete(int studentID)
        {
            using (var context = new DatabaseContext())
            {
                var student = context.Students.Where(x => x.StudentId == studentID).FirstOrDefault();
                context.Students.Remove(student);
                context.SaveChanges();
                return true;
            }
            
        }

    }
}
