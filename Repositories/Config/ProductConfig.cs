using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Slug).IsRequired();



            builder.HasData(
                new Product() { Id = 1, CategoryId = 2, Name = "Pergole Tente", Slug = "pergole-tente", Price = 2000, Comment = "Pergole Tenteler Ticari alanlarda veya konutlarda kullanılan pergole tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergole tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar. Bu sistemler teknolojik gelişmelerle birlikte güncellenip motor ve sensör desteğiyle daha kullanışlı hale gelmiştir. İşyeriniz veya eviniz için ihtiyacınız olan tüm pergola tenteleri firmamızdan uygun fiyatlarla tedarik edebilirsiniz. " },
                new Product() { Id = 2, CategoryId = 2, Name = "Körük Tente", Slug = "koruk-tente", Price = 2500, Comment = "Körüklü tentelerin kurulumu ve kullanıma kolay tente modellerinden sadece biridir. Tente Sistemi Akordeon Şeklinde Açılıp Kapanmaktadır Diğer Tentelerde Farkı yan kısımlar Kapalı olduğundan Güneş ve Yağmur gelmesini Engeller  kullanıldığı alanlarda şık Dizaynı ve Tasarımıyla bulunduğu alana ayrı bir Görsellik katar.\r\n\r\nKörüklü Sisteminin Saçak Modeli Deniz dalgası modeli veya Düz saçak modeli tercih edilmektedir." },
                new Product() { Id = 3, CategoryId = 2, Name = "Stor Tente", Slug = "stor-tente", Price = 1500, Comment = "Stor tente normal mafsallı tentenin kolsuz modelidir.karşıdan gelen güneş için tercih edilen bir modeldir. Stor tente Yukardan aşağı açılıp kapanan bir modeldir istenildiği taktirde motorlu sistemde uyumludur.stor tente asıl amacı, gölgelendirme işlevini yapmak olsa da fonksiyonellik yönünden de hiçbir şekilde sınır tanımamaktadır." },
                new Product() { Id = 4, CategoryId = 2, Name = "Çift Açılır Tente", Slug = "cift-acılır-tente", Price = 5000, Comment = "Çift açılır tente kurulumu ve kullanımı kolay tente modellerinden sadece biridir.\r\n\r\nBu tente sayesinde hem daha sağlıklı bir hava ortamına sahip olursunuz hemde iş yerleriniz daha güzel bire görünüme kavuşmaktadır. taksitli fiyatları akrilik kumaşlı ısı geçirmeyen garanti belgeli kaliteli" },
                new Product() { Id = 5, CategoryId = 2, Name = "Mafsallı Tente", Slug = "mafsalli-tente", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },

                //giyotincam
                new Product() { Id = 6, CategoryId = 1, Name = "Giyotin Cam", Slug = "giyotin-cam", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 7, CategoryId = 1, Name = "Fotoselli Giyotin Cam Kapı", Slug = "fotoselli-giyotin-cam-kapi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },

                //branda sistemleri
                new Product() { Id = 8, CategoryId = 3, Name = "Şeffaf Kış Bahçesi", Slug = "seffaf-kıs-bahcesi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 9, CategoryId = 3, Name = "Şeffaf Alan Kapama", Slug = "seffaf-alan-kapama", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 10, CategoryId = 3, Name = "Şeffaf Pvc Mika Branda", Slug = "seffaf-pvc-mika-branda", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 11, CategoryId = 3, Name = "Havuz Brandası", Slug = "havuz-brandasi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 12, CategoryId = 3, Name = "İskele Brandası", Slug = "iskele-brandasi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 13, CategoryId = 3, Name = "Kamelya Branda", Slug = "kamelya-branda", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 14, CategoryId = 3, Name = "Pazar Brandası", Slug = "pazar-brandasi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 15, CategoryId = 3, Name = "Reklam Brandası", Slug = "reklam-brandasi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 16, CategoryId = 3, Name = "Araç Koruma Brandası", Slug = "arac-koruma-brandasi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 17, CategoryId = 3, Name = "Yat ve Tekne Brandası", Slug = "yat-tekne-brandasi", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                // cam sistemleri
                new Product() { Id = 18, CategoryId = 4, Name = "Cam Balkon", Slug = "cam-balkon", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 19, CategoryId = 4, Name = "Cam Veranda", Slug = "cam-veranda", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },

                // cadır sitemleri
                new Product() { Id = 20, CategoryId = 5, Name = "Depo Çadırı", Slug = "depo-cadiri", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 21, CategoryId = 5, Name = "Doğal Afet Çadırı", Slug = "dogal-afet-cadiri", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 22, CategoryId = 5, Name = "Halı Saha Çadırı", Slug = "hali -saha-cadiri", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 23, CategoryId = 5, Name = "Hayvan Besi Çadırı", Slug = "hayvan-besi-cadiri", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 24, CategoryId = 5, Name = "Spor Kompleksi Çadırı", Slug = "spor-kompleksi-cadiri", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 25, CategoryId = 5, Name = "Şantiye Çadırı", Slug = "santiye-cadiri", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 26, CategoryId = 5, Name = "Kiralık Çadır", Slug = "kiralik-cadir", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                new Product() { Id = 27, CategoryId = 5, Name = "Konser Tören Çadırı", Slug = "konser-toren-cadiri", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." },
                //Sineklik sitemleri
                new Product() { Id = 28, CategoryId = 6, Name = "Sürgülü Sineklik", Slug = "surgulu-sineklik", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." }



                );
        }
    }
}
