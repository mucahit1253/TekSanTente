using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using System.Diagnostics;
using TekSan.Models;

namespace TekSan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepositoryManager _manager;

        public HomeController(ILogger<HomeController> logger, IRepositoryManager manager)
        {
            _logger = logger;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.Category.GetAllCategory(false);
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
