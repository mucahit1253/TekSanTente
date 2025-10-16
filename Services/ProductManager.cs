using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.Product.GetAllProducts(trackChanges);
        }

        public IEnumerable<Product> GetByCategoryWithImages(int categoryId, bool trackChanges)
        {
            var product = _manager.Product.GetByCategoryWithImages(categoryId, trackChanges);
            return product;
        }

        public Product? GetOneProduct(string slug, bool trackChanges)
        {
            var product = _manager.Product.GetOneProduct(slug, trackChanges);
            if (product is null)
            {
                throw new Exception("Böyle bir ürün yok yok");
            }
            return product;
        }

        public IEnumerable<Product> GetProductId(int id, bool trackChanges)
        {
            var product = _manager.Product.GetProductId(id, trackChanges);
            if (product is null)
            {
                throw new Exception("Böyle bir ürün yok yok");
            }
            return product;
        }
    }
}
