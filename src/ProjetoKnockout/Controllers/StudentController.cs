using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoKnockout.Entities;
using ProjetoKnockout.Models;

namespace ProjetoKnockout.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Search()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var query = context.Students.ToList();
                var result = (from student in query
                              select new
                              {
                                  StudentId = student.StudentId,
                                  StudentName = student.StudentName,
                                  DateOfBirth = student.DateOfBirth.ToShortDateString(),
                                  Phone = student.Phone,
                                  Address = student.Address,
                                  CEP = student.CEP
                              }).ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult New()
        {
            using (var context = new DatabaseContext())
            {
                var model = new StudentFormViewModel() { Context = context };
                model.LoadDefaultValues();

                return View("Form", model);
            }
        }
        [HttpPost]
        public ActionResult New(StudentFormViewModel model)
        {
            return Save(model);
        }

        private ActionResult Save(StudentFormViewModel model)
        {
            using (var context = new DatabaseContext())
            {
                model.Context = context;

                if (!ModelState.IsValid)
                {
                    model.LoadDefaultValues();
                    return View("Form", model);
                }

                var student = context.Students.SingleOrDefault(s => s.StudentId == model.StudentId);
                if (student == null)
                {
                    student = new Student();
                    context.Students.Add(student);
                }

                student.StudentName = model.StudentName;
                student.DateOfBirth = model.DateOfBirth;
                student.Phone = model.Phone;
                student.Address = model.Address;
                student.CEP = model.CEP;
                student.Courses = model.Courses;

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            using (var context = new DatabaseContext())
            {
                var model = new StudentFormViewModel();
                model.Context = context;
                model.StudentId = id;

                model.LoadDefaultValues();

                var student = context.Students.SingleOrDefault(x => x.StudentId == id);

                if (student != null)
                {
                    model.StudentName = student.StudentName;
                    model.DateOfBirth = student.DateOfBirth;
                    model.Phone = student.Phone;
                    model.Address = student.Address;
                    model.CEP = student.CEP;
                    model.Courses = student.Courses;
                }

                return View("Form", model);
            }
        }

        [HttpPost]
        public ActionResult Edit(StudentFormViewModel model)
        {
            return Save(model);
        }


        public JsonResult Delete(int id)
        {
            using (var context = new DatabaseContext())
            {
                var student = context.Students.SingleOrDefault(x => x.StudentId == id);

                if (student == null)
                {
                    return Json(new { success = false, message = "Student not found." }, JsonRequestBehavior.AllowGet);
                }

                context.Students.Remove(student);

                context.SaveChanges();

                return Json(new { success = true, message = "" }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}
