using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        //Tüm productslar getirmek için
        IQueryable<Product> GetAllProducts(bool trackChanges);
        //Slug sorgu için
        Product? GetOneProduct(string slug, bool trackChanges);
        //product id göre getirmek için
        IQueryable<Product> GetProductId(int id, bool trackChanges);
        //categoriy ve kapak resimleri için
        IQueryable<Product> GetByCategoryWithImages(int categoryId, bool trackChanges);
        //Producaların imgler için
        IQueryable<Product> GetByProductImgImages(int productId, bool trackChanges);
        //ilk yirmi kayıt
        IQueryable<Product> GetTwentyProduct(bool trackChanges);
    }
}
