using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductImageRepository : IRepositoryBase<ProductImage>
    {
        //Produc resimleri için
        IQueryable<ProductImage> GetByProductImgImages(int productId, bool trackChanges);
    }
}
