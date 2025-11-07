using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ServiceImageConfig : IEntityTypeConfiguration<ServiceImage>
    {
        public void Configure(EntityTypeBuilder<ServiceImage> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasData(
                new ServiceImage() { Id = 1, ServiceId = 1, MediaId = 3 },
                new ServiceImage() { Id = 2, ServiceId = 2, MediaId = 165 },
                //Blackout Pergola Tente Kumaşı
                new ServiceImage() { Id = 3, ServiceId = 3, MediaId = 166 },
                new ServiceImage() { Id = 4, ServiceId = 3, MediaId = 167 },
                new ServiceImage() { Id = 5, ServiceId = 3, MediaId = 168 },
                //pergolateknik
                new ServiceImage() { Id = 6, ServiceId = 4, MediaId = 169 },
                new ServiceImage() { Id = 7, ServiceId = 4, MediaId = 170 },
                new ServiceImage() { Id = 8, ServiceId = 4, MediaId = 171 },
                //tenteimalatı
                new ServiceImage() { Id = 9, ServiceId = 5, MediaId = 172 },
                new ServiceImage() { Id = 10, ServiceId = 5, MediaId = 173 },
                new ServiceImage() { Id = 11, ServiceId = 5, MediaId = 174 },
                //kullanim-ozellikleri
                new ServiceImage() { Id = 12, ServiceId = 6, MediaId = 175 },
                new ServiceImage() { Id = 13, ServiceId = 6, MediaId = 176 },
                new ServiceImage() { Id = 14, ServiceId = 6, MediaId = 177 },
                //projeler
                new ServiceImage() { Id = 15, ServiceId = 7, MediaId = 178 },
                new ServiceImage() { Id = 16, ServiceId = 7, MediaId = 179 },
                new ServiceImage() { Id = 17, ServiceId = 7, MediaId = 180 },
                //faydali-bilgiler
                new ServiceImage() { Id = 18, ServiceId = 8, MediaId = 181 },
                new ServiceImage() { Id = 19, ServiceId = 8, MediaId = 182 },
                new ServiceImage() { Id = 20, ServiceId = 8, MediaId = 183 }






                );
        }
    }
}
