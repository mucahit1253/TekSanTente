using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductImageRepository : RepositoryBase<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<ProductImage> GetByProductImgImages(int productId, bool trackChanges)
        {
            var query = _context.Set<ProductImage>()
               .Where(pi => pi.ProductId == productId)
                .Include(pi => pi.Media)
                   .AsNoTracking();
            return query;
        }
    }
}
