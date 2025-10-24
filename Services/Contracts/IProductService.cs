using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product? GetOneProduct(string slug, bool trackChanges);
        IEnumerable<Product> GetProductId(int id, bool trackChanges);
        IEnumerable<Product> GetByCategoryWithImages(int categoryId, bool trackChanges);
        public IQueryable<Product> GetByProductImgImages(int productId, bool trackChanges);
        IQueryable<Product> GetTwentyProduct(bool trackChanges);
    }
}
