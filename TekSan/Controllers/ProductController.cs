using Microsoft.AspNetCore.Mvc;
using Services.Contracts;


namespace TekSan.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(int categoryId)
        {
            //var model = _manager.ProductService.GetProductId(categoryId, false);
            var model = _manager.ProductService.GetByCategoryWithImages(categoryId, false);
            return View(model);
        }
        [HttpGet("Product/{slug}")]
        public IActionResult Get(string slug)
        {
            var model = _manager.ProductService.GetOneProduct(slug, false);
            return View(model);
        }
    }
}
