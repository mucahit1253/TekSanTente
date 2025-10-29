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
                new Media() { Id = 2, FileName = "Pergole-Tente-2.jpg", Url = "/assets/img/properties/Pergole-Tente-2.jpg", AltText = "Tente Ürünü 2", ContentType = "image/jpeg" },
                new Media() { Id = 3, FileName = "service-2.jpg", Url = "/assets/img/service/service-2.jpg", AltText = "Service ilk resim", ContentType = "image/jpeg" },
                new Media() { Id = 4, FileName = "koruktente-1.jpg", Url = "/assets/img/properties/koruktente-1.jpg", AltText = "koruktentekapak", ContentType = "image/jpeg" },
                new Media() { Id = 5, FileName = "koruktente-2.jpg", Url = "/assets/img/properties/koruktente-2.jpg", AltText = "koruktente-2", ContentType = "image/jpeg" },
                new Media() { Id = 6, FileName = "koruktente-3.jpg", Url = "/assets/img/properties/koruktente-3.jpg", AltText = "koruktente-3", ContentType = "image/jpeg" },
                new Media() { Id = 7, FileName = "koruktente-4.jpg", Url = "/assets/img/properties/koruktente-4.jpg", AltText = "koruktente-4", ContentType = "image/jpeg" },
                new Media() { Id = 8, FileName = "koruktente-5.jpg", Url = "/assets/img/properties/koruktente-5.jpg", AltText = "koruktente-5", ContentType = "image/jpeg" },
                new Media() { Id = 9, FileName = "Pergole-1.jpg", Url = "/assets/img/properties/Pergole-Tente-1.jpg", AltText = "Pergole-Tente-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 10, FileName = "Pergole-3.jpg", Url = "/assets/img/properties/Pergole-Tente-3.jpg", AltText = "Pergole-Tente-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 11, FileName = "Pergole-4.jpg", Url = "/assets/img/properties/Pergole-Tente-4.jpg", AltText = "Pergole-Tente-4.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 12, FileName = "Pergole-5.jpg", Url = "/assets/img/properties/Pergole-Tente-5.jpg", AltText = "Pergole-Tente-5.jpg", ContentType = "image/jpeg" },
                //stortente
                new Media() { Id = 13, FileName = "stor-tente-1.jpg", Url = "/assets/img/properties/stor-tente-1.jpg", AltText = "stor-tente-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 14, FileName = "stor-tente-2.jpg", Url = "/assets/img/properties/stor-tente-2.jpg", AltText = "stor-tente-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 15, FileName = "stor-tente-3.jpg", Url = "/assets/img/properties/stor-tente-3.jpg", AltText = "stor-tente-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 16, FileName = "stor-tente-4.jpg", Url = "/assets/img/properties/stor-tente-4.jpg", AltText = "stor-tente-4.jpg", ContentType = "image/jpeg" }





                );
        }
    }
}
