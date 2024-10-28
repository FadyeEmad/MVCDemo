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
    }
}
