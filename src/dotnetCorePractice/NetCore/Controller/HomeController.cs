using Microsoft.AspNetCore.Mvc;

namespace NetCore.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
