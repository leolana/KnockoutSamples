using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoKnockout.Entities;
using ProjetoKnockout.Models;

namespace ProjetoKnockout.Controllers
{
    public class CourseController : Controller
    {
        //
        // GET: /Course/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Search()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var query = context.Courses.ToList();
                var result = (from course in query
                                  select new
                            {
                                CourseID = course.CourseID,
                                CourseName = course.CourseName,
                                CompletionDate = course.CompletionDate.ToShortDateString()
                            }).ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Pastable(IEnumerable<IEnumerable<PasteParameter>> Grid)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                foreach (var item in Grid)
                {
                    var course = new Course()
                    {
                        CourseName = item.FirstOrDefault(x => x.Name == "CourseName").Value,
                        CompletionDate = Convert.ToDateTime(item.FirstOrDefault(x => x.Name == "CompletionDate")),
                    };

                    context.Courses.Add(course);
                }
                context.SaveChanges();

                return Json(new { success = true, message = "" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult New()
        {
            //using (var context = new DatabaseContext())
            //{
                //var model = new CourseFormViewModel() { Context = context };
                //model.LoadDefaultValues();

                return View("Form");
            //}
        }


        [HttpPost]
        public ActionResult New(CourseFormViewModel model)
        {
            return Save(model);
        }

        private ActionResult Save(CourseFormViewModel model)
        {
            using (var context = new DatabaseContext())
            {
                model.Context = context;

                if (!ModelState.IsValid)
                {
                    model.LoadDefaultValues();
                    return View("Form", model);
                }

                var course = context.Courses.SingleOrDefault(c => c.CourseID == model.CourseID);
                if (course == null)
                {
                    course = new Course();
                    context.Courses.Add(course);
                }

                course.CourseName = model.CourseName;
                course.CompletionDate = model.CompletionDate;

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            using (var context = new DatabaseContext())
            {
                var model = new CourseFormViewModel();
                model.Context = context;
                model.CourseID = id;

                //model.LoadDefaultValues();

                var course = context.Courses.SingleOrDefault(x => x.CourseID == id);

                if (course != null)
                {
                    model.CourseName = course.CourseName;
                    model.CompletionDate = course.CompletionDate;
                }

                return View("Form", model);
            }
        }

        [HttpPost]
        public ActionResult Edit(CourseFormViewModel model)
        {
            return Save(model);
        }


        public JsonResult Delete(int id)
        {
            using (var context = new DatabaseContext())
            {
                var course = context.Courses.SingleOrDefault(x => x.CourseID == id);

                if (course == null)
                {
                    return Json(new { success = false, message = "Course not found." }, JsonRequestBehavior.AllowGet);
                }

                context.Courses.Remove(course);

                context.SaveChanges();

                return Json(new { success = true, message = "" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
