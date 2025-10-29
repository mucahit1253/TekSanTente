using Entities.Models;

namespace Repositories.Contracts
{
    public interface IOpenCloseMenuRepository : IRepositoryBase<Service>
    {

        IQueryable<Service> GetOpenCloseMenuId(int id, bool trackChanges);
        Service? FindBySlug(string slug, bool trackChanges);
        IQueryable<Service> GetAllService(bool trackChanges);
        public string? GetServiceFirstImageUrl(int serviceId);
        Service? FindById(int serviceId, bool trackChanges);

    }
}
