using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace TekSan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(int page = 1)
        {
            const int pageSize = 10;

            var query = _manager.ProductService.GetAllProducts(trackChanges: false); // IQueryable

            var totalCount = query.Count();

            var products = query
                .OrderBy(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                _manager.ProductService.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
