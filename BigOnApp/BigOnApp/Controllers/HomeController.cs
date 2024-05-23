using Microsoft.AspNetCore.Mvc;

namespace BigOnApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
