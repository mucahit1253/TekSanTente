using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, CategoryId = 1, Name = "Pergole Tente", Slug = "pergole-tente", Price = 2000, Comment = "Pergole Tenteler Ticari alanlarda veya konutlarda kullanılan pergole tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergole tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar. Bu sistemler teknolojik gelişmelerle birlikte güncellenip motor ve sensör desteğiyle daha kullanışlı hale gelmiştir. İşyeriniz veya eviniz için ihtiyacınız olan tüm pergola tenteleri firmamızdan uygun fiyatlarla tedarik edebilirsiniz. " },
                new Product() { Id = 2, CategoryId = 1, Name = "Körük Tente", Slug = "koruk-tente", Price = 2500, Comment = "Körüklü tentelerin kurulumu ve kullanıma kolay tente modellerinden sadece biridir. Tente Sistemi Akordeon Şeklinde Açılıp Kapanmaktadır Diğer Tentelerde Farkı yan kısımlar Kapalı olduğundan Güneş ve Yağmur gelmesini Engeller  kullanıldığı alanlarda şık Dizaynı ve Tasarımıyla bulunduğu alana ayrı bir Görsellik katar.\r\n\r\nKörüklü Sisteminin Saçak Modeli Deniz dalgası modeli veya Düz saçak modeli tercih edilmektedir." },
                new Product() { Id = 3, CategoryId = 1, Name = "Stor Tente", Slug = "stor-tente", Price = 1500, Comment = "Stor tente normal mafsallı tentenin kolsuz modelidir.karşıdan gelen güneş için tercih edilen bir modeldir. Stor tente Yukardan aşağı açılıp kapanan bir modeldir istenildiği taktirde motorlu sistemde uyumludur.stor tente asıl amacı, gölgelendirme işlevini yapmak olsa da fonksiyonellik yönünden de hiçbir şekilde sınır tanımamaktadır." },
                new Product() { Id = 4, CategoryId = 1, Name = "Çift Açılır Tente", Slug = "cift-acılır-tente", Price = 5000, Comment = "Çift açılır tente kurulumu ve kullanımı kolay tente modellerinden sadece biridir.\r\n\r\nBu tente sayesinde hem daha sağlıklı bir hava ortamına sahip olursunuz hemde iş yerleriniz daha güzel bire görünüme kavuşmaktadır. taksitli fiyatları akrilik kumaşlı ısı geçirmeyen garanti belgeli kaliteli" },
                new Product() { Id = 5, CategoryId = 1, Name = "Mafsallı Tente", Slug = "mafsalli-tente", Price = 30000, Comment = "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir." }

                );
        }
    }
}
