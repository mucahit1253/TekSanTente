using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        public IQueryable<Product> GetByCategoryWithImages(int categoryId, bool trackChanges)
        {
            var product = _context.Set<Product>()
                            .Where(p => p.CategoryId == categoryId)
                            .Include(p => p.Images)
                                .ThenInclude(pi => pi.Media)
                                .AsNoTracking();

            return product;


        }

        public Product? GetOneProduct(string slug, bool trackChanges)
        {
            return FindByCondition(p => p.Slug.Equals(slug), trackChanges);
        }

        public IQueryable<Product> GetProductId(int id, bool trackChanges)
        {
            return FindCondition(p => p.CategoryId.Equals(id), trackChanges);
        }

    }
}
