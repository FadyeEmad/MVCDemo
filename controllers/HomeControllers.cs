using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.controllers
{
    public class HomeControllers : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
