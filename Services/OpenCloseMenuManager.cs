using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class OpenCloseMenuManager : IOpenCloseMenuService
    {
        private readonly IRepositoryManager _manager;

        public OpenCloseMenuManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Service? FindById(int serviceId, bool trackChanges) => _manager.OpenCloseMenu.FindById(serviceId, trackChanges);

        public Service? FindBySlug(string slug, bool trackChanges) => _manager.OpenCloseMenu.FindBySlug(slug, trackChanges);

        public IEnumerable<Service> GetAllService(bool trackChanges)
        {
            return _manager.OpenCloseMenu.GetAllService(trackChanges);
        }

        public string? GetServiceFirstImageUrl(int serviceId)
        {
            var query = _manager.OpenCloseMenu.GetServiceFirstImageUrl(serviceId);
            return query;
        }

        IEnumerable<Service> IOpenCloseMenuService.GetOpenCloseMenuId(int id, bool trackChanges)
        {
            var propert = _manager.OpenCloseMenu.GetOpenCloseMenuId(id, trackChanges);
            if (propert is null)
                throw new Exception("Null Menu");
            return propert;
        }
    }
}
