using Microsoft.AspNetCore.Mvc;

namespace FirstWebTask.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
