using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, CategoryName = "Giyotin Cam Sistemleri", Slug = "giyotin-cam-sistemleri", ImageUrl = "assets/img/categories/Giyotin-Cam-Sistemi.jpg", Description = "Giyotin Cam Sistemi Giyotin Cam Sistemi, Teksan All Clean, modern mimariye uyarlanmış en estetik tasarımdır. Bu uzaktan kumandalı sistem, tam panoramik manzaraya" },
                new Category() { CategoryId = 2, CategoryName = "Tente Sistemleri", Slug = "teksan-tente", ImageUrl = "assets/img/categories/pergola.jpg", Description = "Tente Sistemleri Fonksiyonel özellikleri ve estetik görüntüsüyle ön plana çıkan Tente modeli, mafsallı tente sınıfının en gelişmiş ve en sağlam Pergola Tente modelidir. Ticari alanlarda veya konutlarda kullanılan pergola tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergola tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar." },
                new Category() { CategoryId = 3, CategoryName = "Branda Sistemleri", Slug = "branda-sistemleri", ImageUrl = "assets/img/categories/kamelya-branda-570x350.jpg", Description = "Branda Branda çeşitleri, brandaların örnekleri, branda modelleri, istanbul branda, branda fiyatları, balkon brandası, branda kumaşları, Firmamız Yaygın Servis ağı ile oluşacak arıza veya hasar durumunda çadır veya tente sistemine anında müdale fırsatı sunmaktadır. Fiyat bakımından ve kalite bakımından neden uygunuz ? Biz Tente kumaşları toptan şatışı ve bu ürünlerin imalatını." },
                new Category() { CategoryId = 4, CategoryName = "Cam Sistemleri", Slug = "cam-sistemleri", ImageUrl = "assets/img/categories/Acilir-Cam-Tavan-Sistemleri.jpg", Description = "Açılır Cam Tavan Sistemleri Açılır Cam Tavan Sistemleri, Kışın yağmur,kar ve rüzgarı dışarıda bırakabileceğiniz, yaz aylarında ise güneşin tadını doyasıya çıkartabileceğiniz bir yaşam alanına sahip olmaya ne dersiniz ? Sabit Cam Tavan (Veranda) uygun malzeme seçeneği Sabit Cam Tavan (Veranda) Sabit cam tavan kış bahçelerine, teras ve balkon üstlerine yapılabilen." },
                new Category() { CategoryId = 5, CategoryName = "Çadır Sistemleri", Slug = "cadır-sistemleri", ImageUrl = "assets/img/categories/toren-cadiri.jpg", Description = "Konser tören çadırı gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın daha serin bir hava ortamına sahip olmak için sizlerde bu çadırı yaptırmalısınız. Geniş renk seçeneğimiz ve dayanıklı kumaş modellerimiz ile dilediğiniz her tür marka model brandayı firmamızda bulabilirsiniz. Yapacağımız tüm çalışmalar firmamız tarafından garanti sertifikalı iş teslimatı." },
                new Category() { CategoryId = 6, CategoryName = "Sineklik Sistemleri", Slug = "sineklik-sistemleri", ImageUrl = "assets/img/categories/istanbul-sineklik-fiyatlari.jpg", Description = "Evlerimizde, ofislerimizde ve yaşam alanlarımızda en çok ihtiyaç duyulan konforlardan biri temiz hava alırken böcek ve haşerelerden korunmaktır. Sineklik sistemleri, estetik görünümleri ve pratik kullanımlarıyla bu ihtiyaca en ideal çözümü sunar." }


                );
            //product config
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, CategoryId = 2, Name = "Pergole Tente", Slug = "pergole-tente", Price = 2000, Comment = "Pergole Tenteler Ticari alanlarda veya konutlarda kullanılan pergole tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergole tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar. Bu sistemler teknolojik gelişmelerle birlikte güncellenip motor ve sensör desteğiyle daha kullanışlı hale gelmiştir. İşyeriniz veya eviniz için ihtiyacınız olan tüm pergola tenteleri firmamızdan uygun fiyatlarla tedarik edebilirsiniz. " },
                new Product() { Id = 2, CategoryId = 2, Name = "Körük Tente", Slug = "koruk-tente", Price = 2500, Comment = "Körüklü tentelerin kurulumu ve kullanıma kolay tente modellerinden sadece biridir. Tente Sistemi Akordeon Şeklinde Açılıp Kapanmaktadır Diğer Tentelerde Farkı yan kısımlar Kapalı olduğundan Güneş ve Yağmur gelmesini Engeller  kullanıldığı alanlarda şık Dizaynı ve Tasarımıyla bulunduğu alana ayrı bir Görsellik katar.\r\n\r\nKörüklü Sisteminin Saçak Modeli Deniz dalgası modeli veya Düz saçak modeli tercih edilmektedir." },
                new Product() { Id = 3, CategoryId = 2, Name = "Stor Tente", Slug = "stor-tente", Price = 1500, Comment = "Stor tente normal mafsallı tentenin kolsuz modelidir.karşıdan gelen güneş için tercih edilen bir modeldir. Stor tente Yukardan aşağı açılıp kapanan bir modeldir istenildiği taktirde motorlu sistemde uyumludur.stor tente asıl amacı, gölgelendirme işlevini yapmak olsa da fonksiyonellik yönünden de hiçbir şekilde sınır tanımamaktadır." },
                new Product() { Id = 4, CategoryId = 2, Name = "Çift Açılır Tente", Slug = "cift-acılır-tente", Price = 5000, Comment = "Çift açılır tente kurulumu ve kullanımı kolay tente modellerinden sadece biridir.\r\n\r\nBu tente sayesinde hem daha sağlıklı bir hava ortamına sahip olursunuz hemde iş yerleriniz daha güzel bire görünüme kavuşmaktadır. taksitli fiyatları akrilik kumaşlı ısı geçirmeyen garanti belgeli kaliteli" },
                new Product() { Id = 5, CategoryId = 2, Name = "Mafsallı Tente", Slug = "mafsalli-tente", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." }

                );
            modelBuilder.Entity<Media>().HasData(
                new Media() { Id = 1, FileName = "Pergole-Tente.jpg", Url = "/assets/img/properties/Pergole-Tente.jpg", AltText = "Tente Ürünü 1", ContentType = "image/jpeg" },
                new Media() { Id = 2, FileName = "Pergole-Tente-2.jpg", Url = "/assets/img/properties/Pergole-Tente-2.jpg", AltText = "Tente Ürünü 2", ContentType = "image/jpeg" }

                );
            modelBuilder.Entity<ProductImage>().HasData(
                 new ProductImage() { Id = 1, ProductId = 1, MediaId = 1, IsMain = true, DisplayOrder = 1 },
                 new ProductImage() { Id = 2, ProductId = 1, MediaId = 2, IsMain = false, DisplayOrder = 2 }

                );

            modelBuilder.Entity<Service>().HasData(
                new Service() { Id = 1, Name = "Teknik Servis", Slug = "teknik-servis", Description = "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız." }

                );
            modelBuilder.Entity<ServiceImage>().HasData(
                new ServiceImage() { Id = 1, ServiceId = 1, MediaId = 1 }
                );
        }

    }
}
