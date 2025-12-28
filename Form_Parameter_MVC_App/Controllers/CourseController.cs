using Form_Parameter_MVC_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form_Parameter_MVC_App.Controllers
{
    public class CourseController : Controller
    {
        //Passing Data using Model Binding to view
        [HttpPost]
        public IActionResult Index(Course course)
        {
            ViewBag.cid = course.CourseId;
            ViewBag.cname = course.CourseName;
            ViewBag.ccredit = course.CourseCredit;
            ViewBag.grade = course.Grade;
            return View();
        }
        public IActionResult CourseForm()
        {
            return View();
        }
    }
}
