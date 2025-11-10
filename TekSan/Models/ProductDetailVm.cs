using Entities.Models;

namespace TekSan.Models
{
    public sealed class ProductDetailVm
    {
        public Product Product { get; set; }          // Tek ürün
        public IQueryable<ProductImage> ImagesQ { get; set; }
        public List<ProductImage> Images { get; set; } // ✅ View tarafında foreach için
    }
}
