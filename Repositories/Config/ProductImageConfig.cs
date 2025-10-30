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
                 new ProductImage() { Id = 15, ProductId = 3, MediaId = 16, IsMain = false, DisplayOrder = 3 },
                 //ciftacılırtente
                 new ProductImage() { Id = 16, ProductId = 4, MediaId = 17, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 17, ProductId = 4, MediaId = 18, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 18, ProductId = 4, MediaId = 19, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 19, ProductId = 4, MediaId = 20, IsMain = false, DisplayOrder = 3 },

                 //Mafsaltente
                 new ProductImage() { Id = 20, ProductId = 5, MediaId = 21, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 21, ProductId = 5, MediaId = 22, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 22, ProductId = 5, MediaId = 23, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 23, ProductId = 5, MediaId = 24, IsMain = false, DisplayOrder = 3 },

                 //GiyotinCam
                 new ProductImage() { Id = 24, ProductId = 6, MediaId = 25, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 25, ProductId = 6, MediaId = 26, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 26, ProductId = 6, MediaId = 27, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 27, ProductId = 6, MediaId = 28, IsMain = false, DisplayOrder = 3 },

                 //Fotoselli Giyotin Cam Kapı
                 new ProductImage() { Id = 28, ProductId = 7, MediaId = 29, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 29, ProductId = 7, MediaId = 30, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 30, ProductId = 7, MediaId = 31, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 31, ProductId = 7, MediaId = 32, IsMain = false, DisplayOrder = 3 },
                 //Şeffaf Kış Bahçesi
                 new ProductImage() { Id = 32, ProductId = 8, MediaId = 33, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 33, ProductId = 8, MediaId = 34, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 34, ProductId = 8, MediaId = 35, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 35, ProductId = 8, MediaId = 36, IsMain = false, DisplayOrder = 3 },
                 //Şeffaf Alan Kapama
                 new ProductImage() { Id = 36, ProductId = 9, MediaId = 37, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 37, ProductId = 9, MediaId = 38, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 38, ProductId = 9, MediaId = 39, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 39, ProductId = 9, MediaId = 40, IsMain = false, DisplayOrder = 3 },
                 //Şeffaf Pvc Mika Branda
                 new ProductImage() { Id = 40, ProductId = 10, MediaId = 41, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 41, ProductId = 10, MediaId = 42, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 42, ProductId = 10, MediaId = 43, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 43, ProductId = 10, MediaId = 44, IsMain = false, DisplayOrder = 3 },
                 //Havuz Brandası
                 new ProductImage() { Id = 44, ProductId = 11, MediaId = 45, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 45, ProductId = 11, MediaId = 46, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 46, ProductId = 11, MediaId = 47, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 47, ProductId = 11, MediaId = 48, IsMain = false, DisplayOrder = 3 },
                 //İskele Brandası
                 new ProductImage() { Id = 48, ProductId = 12, MediaId = 49, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 49, ProductId = 12, MediaId = 50, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 50, ProductId = 12, MediaId = 51, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 51, ProductId = 12, MediaId = 52, IsMain = false, DisplayOrder = 3 },
                 //kamleya-brandasi
                 new ProductImage() { Id = 52, ProductId = 13, MediaId = 53, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 53, ProductId = 13, MediaId = 54, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 54, ProductId = 13, MediaId = 55, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 55, ProductId = 13, MediaId = 56, IsMain = false, DisplayOrder = 3 },
                 //Pazar Brandası
                 new ProductImage() { Id = 56, ProductId = 14, MediaId = 57, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 57, ProductId = 14, MediaId = 58, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 58, ProductId = 14, MediaId = 59, IsMain = false, DisplayOrder = 3 },
                 //Reklam Brandası
                 new ProductImage() { Id = 59, ProductId = 15, MediaId = 60, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 60, ProductId = 15, MediaId = 61, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 61, ProductId = 15, MediaId = 62, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 62, ProductId = 15, MediaId = 63, IsMain = false, DisplayOrder = 3 },
                 //Araç Koruma Brandası
                 new ProductImage() { Id = 63, ProductId = 16, MediaId = 64, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 64, ProductId = 16, MediaId = 65, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 65, ProductId = 16, MediaId = 66, IsMain = false, DisplayOrder = 3 },
                 //Yat ve Tekne Brandası
                 new ProductImage() { Id = 66, ProductId = 17, MediaId = 67, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 67, ProductId = 17, MediaId = 68, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 68, ProductId = 17, MediaId = 69, IsMain = false, DisplayOrder = 3 },
                 //Cam Balkon
                 new ProductImage() { Id = 69, ProductId = 18, MediaId = 70, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 70, ProductId = 18, MediaId = 71, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 71, ProductId = 18, MediaId = 72, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 72, ProductId = 18, MediaId = 73, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 73, ProductId = 18, MediaId = 74, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 74, ProductId = 18, MediaId = 75, IsMain = false, DisplayOrder = 3 },
                 //cam-veranda
                 new ProductImage() { Id = 75, ProductId = 19, MediaId = 76, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 76, ProductId = 19, MediaId = 77, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 77, ProductId = 19, MediaId = 78, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 78, ProductId = 19, MediaId = 79, IsMain = false, DisplayOrder = 3 },
                 //depo-cadiri
                 new ProductImage() { Id = 79, ProductId = 20, MediaId = 80, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 80, ProductId = 20, MediaId = 81, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 81, ProductId = 20, MediaId = 82, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 82, ProductId = 20, MediaId = 83, IsMain = false, DisplayOrder = 3 },

                 //dogal-afet-cadiri
                 new ProductImage() { Id = 83, ProductId = 21, MediaId = 84, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 84, ProductId = 21, MediaId = 85, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 85, ProductId = 21, MediaId = 86, IsMain = false, DisplayOrder = 3 },


                 //hali -saha-cadiri
                 new ProductImage() { Id = 86, ProductId = 22, MediaId = 87, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 87, ProductId = 22, MediaId = 88, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 88, ProductId = 22, MediaId = 89, IsMain = false, DisplayOrder = 3 },

                 //hayvan-besi-cadiri
                 new ProductImage() { Id = 89, ProductId = 23, MediaId = 90, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 90, ProductId = 23, MediaId = 91, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 91, ProductId = 23, MediaId = 92, IsMain = false, DisplayOrder = 3 },

                 //spor-kompleksi-cadiri
                 new ProductImage() { Id = 92, ProductId = 24, MediaId = 93, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 93, ProductId = 24, MediaId = 94, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 94, ProductId = 24, MediaId = 95, IsMain = false, DisplayOrder = 3 },


                 //santiye-cadiri
                 new ProductImage() { Id = 95, ProductId = 25, MediaId = 96, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 96, ProductId = 25, MediaId = 97, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 97, ProductId = 25, MediaId = 98, IsMain = false, DisplayOrder = 3 },

                 //kiralik-cadir
                 new ProductImage() { Id = 98, ProductId = 26, MediaId = 99, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 99, ProductId = 26, MediaId = 100, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 100, ProductId = 26, MediaId = 101, IsMain = false, DisplayOrder = 3 },

                 //konser-toren-cadiri
                 new ProductImage() { Id = 101, ProductId = 27, MediaId = 102, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 102, ProductId = 27, MediaId = 103, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 103, ProductId = 27, MediaId = 104, IsMain = false, DisplayOrder = 3 },

                 //surgulu-sineklik
                 new ProductImage() { Id = 104, ProductId = 28, MediaId = 105, IsMain = true, DisplayOrder = 3 },
                 new ProductImage() { Id = 105, ProductId = 28, MediaId = 106, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 106, ProductId = 28, MediaId = 107, IsMain = false, DisplayOrder = 3 },
                 new ProductImage() { Id = 107, ProductId = 28, MediaId = 108, IsMain = false, DisplayOrder = 3 }

                );
        }
    }
}
