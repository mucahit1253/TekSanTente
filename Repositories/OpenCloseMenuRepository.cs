using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{
    public class OpenCloseMenuRepository : RepositoryBase<Service>, IOpenCloseMenuRepository
    {
        public OpenCloseMenuRepository(RepositoryContext context) : base(context)
        {
        }

        public Service? FindBySlug(string slug, bool trackChanges) => _context.Services.FirstOrDefault(s => s.Slug.Equals(slug));

        public IQueryable<Service> GetAllService(bool trackChanges)
        {
            var menu = _context.Services
                .Where(s => s.ParentId == null)   // sadece ROOT (ana menüler)
                .Include(s => s.Children)                               //.Include(s => s.Children)         // alt menüler de yüklensin
                .AsNoTracking();
            return menu;


        }


        public IQueryable<Service> GetOpenCloseMenuId(int id, bool trackChanges)
        {
            var menu = _context.Services
                .Where(s => s.ParentId == null)   // sadece ROOT (ana menüler)
                .Include(s => s.Children)         // alt menüler de yüklensin
                .AsNoTracking();
            return menu;

        }

        public string? GetServiceFirstImageUrl(int serviceId)
        {
            var query = _context.Set<ServiceImage>()
                .Where(p => p.ServiceId.Equals(serviceId))
                .OrderBy(p => p.Id)
                .Select(p => p.Media.Url)
                .AsNoTracking()
                .FirstOrDefault();
            return query;

        }
    }
}
