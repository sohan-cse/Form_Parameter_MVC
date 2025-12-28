using Microsoft.AspNetCore.Mvc;

namespace Form_Parameter_MVC_App.Controllers
{
    public class StudentController : Controller
    {
        //Passing Data through Request object in a view
        [HttpPost]
        public IActionResult Index()
        {

            ViewBag.sid = Request.Form["studentId"];
            ViewBag.sname = Request.Form["studentName"];
            ViewBag.sdob = Request.Form["studentDOB"];
            ViewBag.sgender = Request.Form["studentGender"];
            return View();
        }
        public IActionResult StudentForm ()
        {
            return View();
        }
    }
}
