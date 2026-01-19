using Microsoft.AspNetCore.Mvc;

namespace TekSan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {


        public IActionResult Index()
        {

            return View();
        }
    }
}
