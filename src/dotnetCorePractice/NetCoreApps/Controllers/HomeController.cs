using Microsoft.AspNetCore.Mvc;

namespace NetCoreApps.Controllers
{
    public class HomeController : Controller
    {
        public string  Index()
        {
            return "Testing Controler";
        }
    }
}
