using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;


namespace TekSan.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }
        [HttpGet("Product/{slug}")]
        public IActionResult Get(string slug)
        {
            var model = _manager.Product.GetOneProduct(slug, false);
            return View(model);
        }
    }
}
