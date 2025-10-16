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
                new ServiceImage() { Id = 1, ServiceId = 1, MediaId = 1 }
                );
        }
    }
}
