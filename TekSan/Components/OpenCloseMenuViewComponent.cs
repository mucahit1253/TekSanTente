using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace TekSan.Components
{
    public class OpenCloseMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public OpenCloseMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public IViewComponentResult Invoke(int id, bool trackChanges)
        {
            var propert = _manager.OpenCloseMenuService.GetOpenCloseMenuId(id, false);
            return View(propert);

        }
    }
}
