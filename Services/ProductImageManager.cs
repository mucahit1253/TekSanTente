using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductImageManager : IProductImageService
    {
        private readonly IRepositoryManager _manager;

        public ProductImageManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IQueryable<ProductImage> GetByProductImgImages(int productId, bool trackChanges)
        {
            var query = _manager.ProductImage.GetByProductImgImages(productId, trackChanges);
            return query;
        }
    }
}
