using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ServiceConfig : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(p => p.Slug).IsRequired();
            builder.HasData(
                new Service() { Id = 1, Name = "Teknik Servis", Slug = "teknik-servis", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." }




                );
        }
    }
}
