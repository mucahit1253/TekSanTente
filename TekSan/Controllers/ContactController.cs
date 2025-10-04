using Microsoft.AspNetCore.Mvc;

namespace TekSan.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
