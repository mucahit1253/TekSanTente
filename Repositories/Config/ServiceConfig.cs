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
            builder.HasMany(s => s.Children)
              .WithOne(s => s.Parent)
              .HasForeignKey(s => s.ParentId);

            builder.HasData(
                new Service() { Id = 1, Name = "Teknik Servis", ParentId = null, Slug = "teknik-servis", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." },
                new Service() { Id = 2, Name = "Teknik Özellikler", ParentId = null, Slug = "teknik-ozellikler", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." },
                new Service() { Id = 3, Name = "Blackout Pergola Tente Kumaşı", ParentId = 2, Slug = "blackout-pergola-tente-kumasi", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." },
                new Service() { Id = 4, Name = "Pergola Tente Teknik Özellikleri", ParentId = 2, Slug = "pergola-tente-teknik-ozellikleri", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." },
                new Service() { Id = 5, Name = "Pergola Tente İmalatı Çeşitleri", ParentId = 2, Slug = "pergola-tente-imalati-cesitleri", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." },
                new Service() { Id = 6, Name = "Kullanım Özellikleri", ParentId = null, Slug = "kullanim-ozellikleri", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." },
                new Service() { Id = 7, Name = "Projeler", ParentId = null, Slug = "projeler", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." },
                new Service() { Id = 8, Name = "Faydalı Bilgiler", ParentId = null, Slug = "faydali-bilgiler", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." }



             );
        }
    }
}
