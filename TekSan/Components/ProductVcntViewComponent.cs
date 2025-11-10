using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace TekSan.Components
{
    public class ProductVcntViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductVcntViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public IViewComponentResult Invoke()
        {
            var qurey = _manager.ProductService.GetTwentyProduct(false);
            return View(qurey);
        }
    }
}
