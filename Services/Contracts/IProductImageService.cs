using Entities.Models;

namespace Services.Contracts
{
    public interface IProductImageService
    {
        IQueryable<ProductImage> GetByProductImgImages(int productId, bool trackChanges);
    }
}
