using Microsoft.AspNetCore.Mvc;

namespace Form_Parameter_MVC_App.Controllers
{
    public class ProductController : Controller
    {

        //Passing Data using Form Collection to view
        public IActionResult Index(IFormCollection data)
        {
            ViewBag.pid = data["productId"];
            ViewBag.pname = data["productName"];
            ViewBag.pprice = data["productPrice"];
            return View();
        }
        public IActionResult ProductForm()
        {
            return View();
        }
    }
}
