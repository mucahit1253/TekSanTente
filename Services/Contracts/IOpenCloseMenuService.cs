using Entities.Models;

namespace Services.Contracts
{
    public interface IOpenCloseMenuService
    {
        public IEnumerable<Service> GetOpenCloseMenuId(int id, bool trackChanges);
        Service? FindBySlug(string slug, bool trackChanges);
        public IEnumerable<Service> GetAllService(bool trackChanges);
        public string? GetServiceFirstImageUrl(int serviceId);
        Service? FindById(int serviceId, bool trackChanges);

    }
}
