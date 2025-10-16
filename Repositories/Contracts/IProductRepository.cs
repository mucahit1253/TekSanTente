using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        Product? GetOneProduct(string slug, bool trackChanges);
        IQueryable<Product> GetProductId(int id, bool trackChanges);
        IQueryable<Product> GetByCategoryWithImages(int categoryId, bool trackChanges);
    }
}
