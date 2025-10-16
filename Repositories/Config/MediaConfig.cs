using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class MediaConfig : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(P => P.Url).IsRequired();
            builder.Property(p => p.FileName).IsRequired();

            builder.HasData(
                new Media() { Id = 1, FileName = "Pergole-Tente.jpg", Url = "/assets/img/properties/Pergole-Tente.jpg", AltText = "Tente Ürünü 1", ContentType = "image/jpeg" },
                new Media() { Id = 2, FileName = "Pergole-Tente-2.jpg", Url = "/assets/img/properties/Pergole-Tente-2.jpg", AltText = "Tente Ürünü 2", ContentType = "image/jpeg" }


                );
        }
    }
}
