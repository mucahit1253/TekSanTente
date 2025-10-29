using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductImageConfig : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasData(
                 new ProductImage() { Id = 1, ProductId = 1, MediaId = 1, IsMain = true, DisplayOrder = 1 },
                 new ProductImage() { Id = 2, ProductId = 1, MediaId = 2, IsMain = false, DisplayOrder = 2 },
                 new ProductImage() { Id = 3, ProductId = 2, MediaId = 4, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 4, ProductId = 2, MediaId = 5, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 5, ProductId = 2, MediaId = 6, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 6, ProductId = 2, MediaId = 7, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 7, ProductId = 2, MediaId = 8, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 8, ProductId = 1, MediaId = 9, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 9, ProductId = 1, MediaId = 10, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 10, ProductId = 1, MediaId = 11, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 11, ProductId = 1, MediaId = 12, IsMain = false, DisplayOrder = 3 },
                 //stortente
                 new ProductImage() { Id = 12, ProductId = 3, MediaId = 13, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 13, ProductId = 3, MediaId = 14, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 14, ProductId = 3, MediaId = 15, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 15, ProductId = 3, MediaId = 16, IsMain = false, DisplayOrder = 3 }







                );
        }
    }
}
