using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p => p.CategoryId);
            builder.Property(p => p.CategoryName).IsRequired();
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.HasData(
                new Category() { CategoryId = 1, CategoryName = "Giyotin Cam Sistemleri", Slug = "giyotin-cam-sistemleri", ImageUrl = "assets/img/categories/Giyotin-Cam-Sistemi.jpg", Description = "Giyotin Cam Sistemi Giyotin Cam Sistemi, Teksan All Clean, modern mimariye uyarlanmış en estetik tasarımdır. Bu uzaktan kumandalı sistem, tam panoramik manzaraya" },
                new Category() { CategoryId = 2, CategoryName = "Tente Sistemleri", Slug = "teksan-tente", ImageUrl = "assets/img/categories/pergola.jpg", Description = "Tente Sistemleri Fonksiyonel özellikleri ve estetik görüntüsüyle ön plana çıkan Tente modeli, mafsallı tente sınıfının en gelişmiş ve en sağlam Pergola Tente modelidir. Ticari alanlarda veya konutlarda kullanılan pergola tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergola tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar." },
                new Category() { CategoryId = 3, CategoryName = "Branda Sistemleri", Slug = "branda-sistemleri", ImageUrl = "assets/img/categories/kamelya-branda-570x350.jpg", Description = "Branda Branda çeşitleri, brandaların örnekleri, branda modelleri, istanbul branda, branda fiyatları, balkon brandası, branda kumaşları, Firmamız Yaygın Servis ağı ile oluşacak arıza veya hasar durumunda çadır veya tente sistemine anında müdale fırsatı sunmaktadır. Fiyat bakımından ve kalite bakımından neden uygunuz ? Biz Tente kumaşları toptan şatışı ve bu ürünlerin imalatını." },
                new Category() { CategoryId = 4, CategoryName = "Cam Sistemleri", Slug = "cam-sistemleri", ImageUrl = "assets/img/categories/Acilir-Cam-Tavan-Sistemleri.jpg", Description = "Açılır Cam Tavan Sistemleri Açılır Cam Tavan Sistemleri, Kışın yağmur,kar ve rüzgarı dışarıda bırakabileceğiniz, yaz aylarında ise güneşin tadını doyasıya çıkartabileceğiniz bir yaşam alanına sahip olmaya ne dersiniz ? Sabit Cam Tavan (Veranda) uygun malzeme seçeneği Sabit Cam Tavan (Veranda) Sabit cam tavan kış bahçelerine, teras ve balkon üstlerine yapılabilen." },
                new Category() { CategoryId = 5, CategoryName = "Çadır Sistemleri", Slug = "cadır-sistemleri", ImageUrl = "assets/img/categories/toren-cadiri.jpg", Description = "Konser tören çadırı gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın daha serin bir hava ortamına sahip olmak için sizlerde bu çadırı yaptırmalısınız. Geniş renk seçeneğimiz ve dayanıklı kumaş modellerimiz ile dilediğiniz her tür marka model brandayı firmamızda bulabilirsiniz. Yapacağımız tüm çalışmalar firmamız tarafından garanti sertifikalı iş teslimatı." },
                new Category() { CategoryId = 6, CategoryName = "Sineklik Sistemleri", Slug = "sineklik-sistemleri", ImageUrl = "assets/img/categories/istanbul-sineklik-fiyatlari.jpg", Description = "Evlerimizde, ofislerimizde ve yaşam alanlarımızda en çok ihtiyaç duyulan konforlardan biri temiz hava alırken böcek ve haşerelerden korunmaktır. Sineklik sistemleri, estetik görünümleri ve pratik kullanımlarıyla bu ihtiyaca en ideal çözümü sunar." }

                );
        }
    }
}
