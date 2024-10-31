using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.controller
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/Home/AboutUs");
        }
        public string AboutUs()
        {
            return "This is Inedx Action" ;
        }
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult AboutUs2()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

    }
}