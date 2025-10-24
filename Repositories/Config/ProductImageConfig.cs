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
                 new ProductImage() { Id = 7, ProductId = 2, MediaId = 8, IsMain = false, DisplayOrder = 3 }



                );
        }
    }
}
