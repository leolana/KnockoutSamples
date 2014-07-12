using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjGridJson.Models;
using prjGridJson.StudentService;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity;

namespace prjGridJson.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(prjGridJson.StudentService.Student student)
        {
            student.DateOfBirth = new DateTime(student.DateOfBirth.Year,
                                            student.DateOfBirth.Month,
                                            student.DateOfBirth.Day,
                                            student.DateOfBirth.Hour,
                                            student.DateOfBirth.Minute,
                                            student.DateOfBirth.Second
                                           );
            StudentServiceClient studentService = new StudentServiceClient();
            if (!studentService.Save(student))
                return View("Form");
            return View("Index");
        }

        public ActionResult Edit(int id)
        {
            StudentServiceClient studentService = new StudentServiceClient();
            var model = studentService.GetStudentByID(id);

            Models.Student student = new Models.Student();
            student.StudentId = model.StudentId;
            student.StudentName = model.StudentName;
            student.Address = model.Address;
            student.CEP = model.CEP;
            student.DateOfBirth = model.DateOfBirth;
            student.Phone = model.Phone;

            return View("Form", student);
        }


        public JsonResult Delete(int id)
        {
            StudentServiceClient studentService = new StudentServiceClient();
            if(studentService.Delete(id))
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Search(int page, int rows, string sidx, string sord)
        {
            using (StudentServiceClient studentService = new StudentServiceClient())
            {
                try
                {
                    studentService.Open();
                    var students = studentService.GetAllStudents();

                    int pageIndex = Convert.ToInt32(page);
                    int pageSize = rows;
                    int totalRecords = students.Count();
                    int totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);

                    var listStudents = students
                        .Skip(pageIndex * pageSize)
                        .Take(pageSize);

                    var result = new
                    {
                        page = page,
                        records = totalRecords,
                        total = totalPages,
                        rows = (from pessoa in students
                                select new
                                {
                                    id = pessoa.StudentId.ToString(),
                                    cell = new string[] {
                                    "",
                                    pessoa.StudentId.ToString(),
                                    pessoa.StudentName,
                                    pessoa.DateOfBirth.ToString(),
                                    pessoa.Phone,
                                    pessoa.Address,
                                    pessoa.CEP
                                }
                                }
                            ).ToArray()
                    };

                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(ex, JsonRequestBehavior.AllowGet);
                }
                finally
                {
                    studentService.Close();
                }
                
            }
        }

    }
}
