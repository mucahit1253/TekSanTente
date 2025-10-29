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

        public IQueryable<Product> GetByProductImgImages(int productId, bool trackChanges)
        {
            var query = _context.Set<Product>()
                    .Where(p => p.Id == productId)
                    .Include(p => p.Images)
                       .ThenInclude(pi => pi.Media)
                    .AsSplitQuery();
            return query;
        }

        public Product? GetOneProduct(string slug, bool trackChanges)
        {
            return FindByCondition(p => p.Slug.Equals(slug), trackChanges);
        }

        public IQueryable<Product> GetProductId(int id, bool trackChanges)
        {
            return FindCondition(p => p.CategoryId.Equals(id), trackChanges);
        }

        public IQueryable<Product> GetTwentyProduct(bool trackChanges)
        {
            var q = _context.Products
                       //.OrderByDescending(p => p.Id)                 // istediğin sıralama
                       .Include(p => p.Images
                         .Where(i => i.IsMain)                     // sadece kapak
                      .OrderBy(i => i.DisplayOrder)
                          .Take(1))
                       .ThenInclude(i => i.Media)                    // kapak dosyası
                      .AsSplitQuery();
            return q.Take(20);

        }
    }
}
