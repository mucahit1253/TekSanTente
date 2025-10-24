using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using TekSan.Models;


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
            var product = _manager.ProductService.GetOneProduct(slug, false);
            if (product is null) return NotFound();
            var imagesQ = _manager.ProductImageService.GetByProductImgImages(product.Id, trackChanges: false);
            var vm = new ProductDetailVm
            {
                Product = product,
                ImagesQ = imagesQ,          // gerekiyorsa tut
                Images = imagesQ.ToList()   // Razor’da foreach için güvenli
            };
            return View(vm);
        }
    }
}
