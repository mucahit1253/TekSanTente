using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace TekSan.Components
{
    public class ProductFooterGetViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductFooterGetViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke(bool trackChanges)
        {
            var qurey = _manager.ProductService.GetTwentyProduct(false).ToList();   // ← kritik;
            return View(qurey);
        }
    }
}