using Microsoft.AspNetCore.Mvc;

namespace TekSan.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
