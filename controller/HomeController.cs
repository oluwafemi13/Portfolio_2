using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
