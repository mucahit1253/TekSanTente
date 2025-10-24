using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace TekSan.Components
{
    public class NavbarMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public NavbarMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke(string? currentSlug = null, bool trackChanges = false)
        {
            var tree = _manager.OpenCloseMenuService.GetAllService(trackChanges: false);
            ViewBag.CurrentSlug = currentSlug ?? string.Empty;

            // Hizmetlerimiz altındaki özel yolu manuel veriyoruz
            return View("~/Views/Hizmetlerimiz/Components/NavbarMenu/Default.cshtml", tree);
        }
    }
}
