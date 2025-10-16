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
                 new ProductImage() { Id = 2, ProductId = 1, MediaId = 2, IsMain = false, DisplayOrder = 2 }

                );
        }
    }
}
