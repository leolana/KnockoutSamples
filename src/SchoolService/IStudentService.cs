using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Collections;

namespace SchoolService
{
    interface IStudentService
    {
        [OperationContract]
        List<Student> GetAllStudents();//Get all students; returns list of students

        [OperationContract]
        List<Student> GetStudentByID(string StudentID);//Gets a(single) student by ID

        [OperationContract]
        List<Student> Filter(); //Returns list of 
        //students by specified filter
    }
}
