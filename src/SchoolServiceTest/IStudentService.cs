using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SchoolService;

namespace SchoolServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        List<Student> GetAllStudents();//Get all students; returns list of students

        [OperationContract]
        Student GetStudentByID(int StudentID);//Gets a(single) student by ID

        [OperationContract]
        bool Save(Student student); //Returns list of 
        //students by specified filter

        [OperationContract]
        bool Delete(int studentID);
    }
}
