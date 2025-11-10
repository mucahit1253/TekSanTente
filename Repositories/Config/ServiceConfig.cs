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
                new Service() { Id = 2, Name = "Teknik Özellikler", ParentId = null, Slug = "teknik-ozellikler", Description = "Yüksek mukametli alimunyum alışımlı yapılmış elektros statik toz boya ile boyalı iskelet\r\nHer türlü hava koşuluna dayanıklı su geçirmeme özelliğine sahip Pvc bloklardan oluşan yüzey Malzemesi 850 gram alev yürütmeme özelliğine sahip blockout branda\r\n120 x 80 mm ölçülerinde taşıyıcılar 150 x 70 mm ray Sistemleri Uzaktan kumandalı Alman Becker motor desteği Gergi için özel olarak üretilmiş Alman Triger kayış sistemi İtalyan rulman makara sistemi özel estetik görünümlü alimunyum yağmur ve dere inişleri ile su taşıyıcı giderleri Ürünlerimiz 5 yıl garantili" },
                new Service() { Id = 3, Name = "Blackout Pergola Tente Kumaşı", ParentId = 2, Slug = "blackout-pergola-tente-kumasi", Description = "Pergola Tente Kumaşı Özellikleri ,-25 soğuğa,+70 sıcağa ve yağmura dayanıklı çadır, kaliteli tente kumaşları, uzman işçiliği ile müşterilerine uygun fiyatlarla.\r\ndilmesinin nedeni; tentenin güneşi ışıklarını maksimum derecede kesmesi ve tente altında kalan yaşam mahalini oldukça serin tutması olarak gösterilebilir. Kumaş kendiliğinden üç boyutlu bir desene sahip olması ve sıkı dokunuşlu oluşundan diğer kumaşlardan ayrılmaktadır. Özellikle raylı tente imalarında kullanılan bir kumaştır. Çok fazla renk seçimi sunmaz, fakat uzun ömürlüdür. Güneş ve yağmur geçirmez, Koku yapmaz, yosunlanmaz. Elbette fiyat olarak diğer türlere göre oldukça pahalıdır." },
                new Service() { Id = 4, Name = "Pergola Tente Teknik Özellikleri", ParentId = 2, Slug = "pergola-tente-teknik-ozellikleri", Description = "Sistemde kullanılacak tüm aluminyum ekstrüzyon profillerin 6063 T6 alaşımı ile ,ISO 9001:2008, Alüminyum ve alaşımları , eloksal ,toz boya kaplaması üretimi ve satışı kalite yönetim sistemi altında EN 15088 Alüminyum ve Alüminyum Alaşımları-Yapım işleri için yapısal mamüller muayene ve teslim için teknik şartlar ,EN755-1 Alüminyum ve Alüminyum alaşımları Ekstrüzyonla imal edilmiş Tellik Çubuk/Çubuk, boru ve profiller, TS EN 12020-1 , EN AW-6063 alaşımlarından ekstrüzyon ile imal edilmiş hassas profiller için teknik muayene ve teslim şartları , TS EN 12020-2 , EN AW-6063 alaşımlarından ekstrüzyon ile imal edilmiş hassas profiller için boyut ve şekil toleransları , normlarına uygunluğu üretici veya aluminyum ekstrüzyon tedarikçi firma tarafından geçerli uygunluk belgesi ile belgelendirilmelidir.\r\nSistemin Alüminyum Ekstrüzyon Profillerinde Uygulanacak Elektrostatik toz boya işleminin minimum 120 mikron kalınlıkta ve ‘’Qualicoat’’ kalite sistem markalı , uygulama proseslerine uygunluğu yine üretici veya aluminyum ektrüzyon tedarikçi firma tarafından uygunluğu geçerli uygunluk belgesi ile belgelendirilmelidir." },
                new Service() { Id = 5, Name = "Pergola Tente İmalatı Çeşitleri", ParentId = 2, Slug = "pergola-tente-imalati-cesitleri", Description = "TekSan Tente, dış mekânlarda konforu, estetiği ve dayanıklılığı bir araya getiren Pergola Tente Sistemleri ile yaşam alanlarınıza değer katar. Modern mimariyle uyumlu, yüksek kaliteli malzemelerden üretilen pergola sistemlerimiz; otel, restoran, kafe, teras, bahçe ve veranda gibi alanlarda dört mevsim kesintisiz kullanım imkânı sunar." },
                new Service()
                {
                    Id = 6,
                    Name = "Kullanım Özellikleri",
                    ParentId = null,
                    Slug = "kullanim-ozellikleri",
                    Description = "TekSan Tente sistemleri, her mevsimde konforlu ve estetik yaşam alanları sunmak için tasarlanmıştır. Yüksek kalite standartlarında üretilen tente sistemlerimiz, dış mekanlarınızı hem koruyucu hem de dekoratif bir alana dönüştürür." +
                "Dayanıklı Malzeme Yapısı: Alüminyum, galvanizli çelik ve paslanmaz bağlantı elemanlarıyla uzun ömürlü kullanım sağlar.\r\n\r\nSu ve Güneş Direnci: UV korumalı, su geçirmez ithal kumaşlar sayesinde güneş ışınlarına ve yağmura karşı tam koruma sunar.\r\n\r\nMotorlu ve Manuel Seçenekler: Uzaktan kumandalı veya manuel açma-kapama sistemleriyle kolay kullanım imkânı.\r\n\r\nEstetik Tasarım: Modern çizgilere sahip, her mekâna uyum sağlayan farklı renk ve model seçenekleriyle üretim yapılır.\r\n\r\nRüzgâr Dayanımı: Yüksek rüzgâr dayanımı için güçlendirilmiş taşıyıcı profiller ve kaliteli bağlantı sistemleri kullanılır.\r\n\r\nBakım Kolaylığı: Kolay temizlenebilir kumaş ve modüler sistem yapısı sayesinde uzun süre sorunsuz kullanım.\r\n\r\nOpsiyonel Donanımlar: LED aydınlatma, ısıtıcı, sensör sistemleri ve otomatik kontrol panelleriyle akıllı kullanım deneyimi."
                },
                new Service() { Id = 7, Name = "Projeler", ParentId = null, Slug = "projeler", Description = "Yapı ruhsatı gerektirmeden uygulanabilen tamamı otomatik açılır &\r\nkapanır şekilde tasarlanan, ergonomik ve fonksiyonel bir tente sistemidir. Pergola Tente\r\n\r\nGeçmişten günümüze yapmış olduğumuz projelerimizi sosyal medya hesaplarımızdan ve sitemizden paylaşmaktayız.. Her daim müşteri desteği sağlıyoruz ve ayrıca müşterilerimiz için çok yüksek düzeyde bir memnuniyet garantisi veriyoruz. Bir sorunuz varsa daha fazla ayrıntı için  numarasından bizimle iletişim kurmaktan çekinmeyin.\r\n\r\nArtık mekânlarınız, olması gerektiği gibi, kullanışlı ve keyifli. Sosyal alan veya evsel lüks ve konforunu arttırabilirsiniz. Pergola tentelerimiz küçük ve büyük alanlar, bağlantısız veya duvara monte edilmiş şekilde tasarlanmışlardır ve çeşitli yenilikçi alüminyum tasarımlarında mevcutturlar. Pergola Tente Yetkili Servis " },
                new Service() { Id = 8, Name = "Faydalı Bilgiler", ParentId = null, Slug = "faydali-bilgiler", Description = "Pergola Tente Faydalı Bilgiler, deri, Pvc, dokuma bezi vb. Malzemeden yapılarak tutturulan, taşınabilir barınak. Modern tipteki çadırlar bir hayli lüks olabilmekle birlikte çoğu durumda en ucuz konaklama biçimi. Genellikle güneşten korunmak için bir yerin üzerine gerilen bez, naylon vb.nden yapılmış örtü.\r\n\r\n" }



             );
        }
    }
}
