using Microsoft.AspNetCore.Mvc;

namespace FirstWebTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
