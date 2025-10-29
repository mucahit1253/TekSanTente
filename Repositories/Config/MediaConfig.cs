using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class MediaConfig : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(P => P.Url).IsRequired();
            builder.Property(p => p.FileName).IsRequired();

            builder.HasData(
                new Media() { Id = 1, FileName = "Pergole-Tente.jpg", Url = "/assets/img/properties/Pergole-Tente.jpg", AltText = "Tente Ürünü 1", ContentType = "image/jpeg" },
                new Media() { Id = 2, FileName = "Pergole-Tente-2.jpg", Url = "/assets/img/properties/Pergole-Tente-2.jpg", AltText = "Tente Ürünü 2", ContentType = "image/jpeg" },
                new Media() { Id = 3, FileName = "service-2.jpg", Url = "/assets/img/service/service-2.jpg", AltText = "Service ilk resim", ContentType = "image/jpeg" },
                new Media() { Id = 4, FileName = "koruktente-1.jpg", Url = "/assets/img/properties/koruktente-1.jpg", AltText = "koruktentekapak", ContentType = "image/jpeg" },
                new Media() { Id = 5, FileName = "koruktente-2.jpg", Url = "/assets/img/properties/koruktente-2.jpg", AltText = "koruktente-2", ContentType = "image/jpeg" },
                new Media() { Id = 6, FileName = "koruktente-3.jpg", Url = "/assets/img/properties/koruktente-3.jpg", AltText = "koruktente-3", ContentType = "image/jpeg" },
                new Media() { Id = 7, FileName = "koruktente-4.jpg", Url = "/assets/img/properties/koruktente-4.jpg", AltText = "koruktente-4", ContentType = "image/jpeg" },
                new Media() { Id = 8, FileName = "koruktente-5.jpg", Url = "/assets/img/properties/koruktente-5.jpg", AltText = "koruktente-5", ContentType = "image/jpeg" },
                new Media() { Id = 9, FileName = "Pergole-1.jpg", Url = "/assets/img/properties/Pergole-Tente-1.jpg", AltText = "Pergole-Tente-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 10, FileName = "Pergole-3.jpg", Url = "/assets/img/properties/Pergole-Tente-3.jpg", AltText = "Pergole-Tente-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 11, FileName = "Pergole-4.jpg", Url = "/assets/img/properties/Pergole-Tente-4.jpg", AltText = "Pergole-Tente-4.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 12, FileName = "Pergole-5.jpg", Url = "/assets/img/properties/Pergole-Tente-5.jpg", AltText = "Pergole-Tente-5.jpg", ContentType = "image/jpeg" },
                //stortente
                new Media() { Id = 13, FileName = "stor-tente-1.jpg", Url = "/assets/img/properties/stor-tente-1.jpg", AltText = "stor-tente-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 14, FileName = "stor-tente-2.jpg", Url = "/assets/img/properties/stor-tente-2.jpg", AltText = "stor-tente-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 15, FileName = "stor-tente-3.jpg", Url = "/assets/img/properties/stor-tente-3.jpg", AltText = "stor-tente-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 16, FileName = "stor-tente-4.jpg", Url = "/assets/img/properties/stor-tente-4.jpg", AltText = "stor-tente-4.jpg", ContentType = "image/jpeg" },
                //ciftacılırtente
                new Media() { Id = 17, FileName = "cift-acilir-tente-1.jpg", Url = "/assets/img/properties/cift-acilir-tente-1.jpg", AltText = "cift-acilir-tente-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 18, FileName = "cift-acilir-tente-2.jpg", Url = "/assets/img/properties/cift-acilir-tente-2.jpg", AltText = "cift-acilir-tente-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 19, FileName = "cift-acilir-tente-3.jpg", Url = "/assets/img/properties/cift-acilir-tente-3.jpg", AltText = "cift-acilir-tente-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 20, FileName = "cift-acilir-tente-4.jpg", Url = "/assets/img/properties/cift-acilir-tente-4.jpg", AltText = "cift-acilir-tente-4.jpg", ContentType = "image/jpeg" },
                //Mafsaltente
                new Media() { Id = 21, FileName = "mafsal-tente-1.jpg", Url = "/assets/img/properties/mafsal-tente-1.jpg", AltText = "mafsal-tente-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 22, FileName = "mafsal-tente-2.jpg", Url = "/assets/img/properties/mafsal-tente-2.jpg", AltText = "mafsal-tente-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 23, FileName = "mafsal-tente-3.jpg", Url = "/assets/img/properties/mafsal-tente-3.jpg", AltText = "mafsal-tente-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 24, FileName = "mafsal-tente-4.jpg", Url = "/assets/img/properties/mafsal-tente-4.jpg", AltText = "mafsal-tente-4.jpg", ContentType = "image/jpeg" },
                //giyotin cam
                new Media() { Id = 25, FileName = "giyotin-cam-1.jpg", Url = "/assets/img/properties/giyotin-cam-1.jpg", AltText = "giyotin-cam-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 26, FileName = "giyotin-cam-2.jpg", Url = "/assets/img/properties/giyotin-cam-2.jpg", AltText = "giyotin-cam-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 27, FileName = "giyotin-cam-3.jpg", Url = "/assets/img/properties/giyotin-cam-3.jpg", AltText = "giyotin-cam-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 28, FileName = "giyotin-cam-4.jpg", Url = "/assets/img/properties/giyotin-cam-4.jpg", AltText = "giyotin-cam-4.jpg", ContentType = "image/jpeg" },

                //Fotoselli Giyotin Cam Kapı
                new Media() { Id = 29, FileName = "fotoselli-kapi-1.jpg", Url = "/assets/img/properties/fotoselli-kapi-1.jpg", AltText = "fotoselli-kapi-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 30, FileName = "fotoselli-kapi-2.jpg", Url = "/assets/img/properties/fotoselli-kapi-2.jpg", AltText = "fotoselli-kapi-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 31, FileName = "fotoselli-kapi-3.jpg", Url = "/assets/img/properties/fotoselli-kapi-3.jpg", AltText = "fotoselli-kapi-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 32, FileName = "fotoselli-kapi-4.jpg", Url = "/assets/img/properties/fotoselli-kapi-4.jpg", AltText = "fotoselli-kapi-1.jpg", ContentType = "image/jpeg" },
                //Şeffaf Kış Bahçesi
                new Media() { Id = 33, FileName = "kis-bahcecileri-1.jpg", Url = "/assets/img/properties/kis-bahcecileri-1.jpg", AltText = "kis-bahcecileri-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 34, FileName = "kis-bahcecileri-2.jpg", Url = "/assets/img/properties/kis-bahcecileri-2.jpg", AltText = "kis-bahcecileri-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 35, FileName = "kis-bahcecileri-3.jpg", Url = "/assets/img/properties/kis-bahcecileri-3.jpg", AltText = "kis-bahcecileri-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 36, FileName = "kis-bahcecileri-4.jpg", Url = "/assets/img/properties/kis-bahcecileri-4.jpg", AltText = "kis-bahcecileri-4.jpg", ContentType = "image/jpeg" },
                //Şeffaf Alan Kapama
                new Media() { Id = 37, FileName = "seffaf-alan-kapama-1.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-1.jpg", AltText = "seffaf-alan-kapama-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 38, FileName = "seffaf-alan-kapama-2.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-2.jpg", AltText = "seffaf-alan-kapama-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 39, FileName = "seffaf-alan-kapama-3.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-3.jpg", AltText = "seffaf-alan-kapama-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 40, FileName = "seffaf-alan-kapama-4.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-4.jpg", AltText = "seffaf-alan-kapama-4.jpg", ContentType = "image/jpeg" },
                //Şeffaf Pvc Mika Branda
                new Media() { Id = 41, FileName = "seffaf-branda-1.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-4.jpg", AltText = "seffaf-branda-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 42, FileName = "seffaf-branda-2.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-4.jpg", AltText = "seffaf-branda-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 43, FileName = "seffaf-branda-3.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-4.jpg", AltText = "seffaf-branda-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 44, FileName = "seffaf-branda-4.jpg", Url = "/assets/img/properties/seffaf-alan-kapama-4.jpg", AltText = "seffaf-branda-4.jpg", ContentType = "image/jpeg" },
                //Havuz Brandası
                new Media() { Id = 45, FileName = "havuz-brandasi-1.jpg", Url = "/assets/img/properties/havuz-brandasi-1.jpg", AltText = "havuz-brandasi-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 46, FileName = "havuz-brandasi-2.jpg", Url = "/assets/img/properties/havuz-brandasi-2.jpg", AltText = "havuz-brandasi-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 47, FileName = "havuz-brandasi-3.jpg", Url = "/assets/img/properties/havuz-brandasi-3.jpg", AltText = "havuz-brandasi-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 48, FileName = "havuz-brandasi-4.jpg", Url = "/assets/img/properties/havuz-brandasi-4.jpg", AltText = "havuz-brandasi-4.jpg", ContentType = "image/jpeg" },
                //İskele Brandası
                new Media() { Id = 49, FileName = "iskele-branda-1.jpg", Url = "/assets/img/properties/iskele-branda-1.jpg", AltText = "iskele-branda-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 50, FileName = "iskele-branda-2.jpg", Url = "/assets/img/properties/iskele-branda-2.jpg", AltText = "iskele-branda-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 51, FileName = "iskele-branda-3.jpg", Url = "/assets/img/properties/iskele-branda-3.jpg", AltText = "iskele-branda-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 52, FileName = "iskele-branda-4.jpg", Url = "/assets/img/properties/iskele-branda-4.jpg", AltText = "iskele-branda-4.jpg", ContentType = "image/jpeg" },
                //kamleya-brandasi
                new Media() { Id = 53, FileName = "kamleya-brandasi-1.jpg", Url = "/assets/img/properties/kamleya-brandasi-1.jpg", AltText = "kamleya-brandasi-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 54, FileName = "kamleya-brandasi-2.jpg", Url = "/assets/img/properties/kamleya-brandasi-2.jpg", AltText = "kamleya-brandasi-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 55, FileName = "kamleya-brandasi-3.jpg", Url = "/assets/img/properties/kamleya-brandasi-3.jpg", AltText = "kamleya-brandasi-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 56, FileName = "kamleya-brandasi-4.jpg", Url = "/assets/img/properties/kamleya-brandasi-4.jpg", AltText = "kamleya-brandasi-4.jpg", ContentType = "image/jpeg" },
                //Pazar Brandası
                new Media() { Id = 57, FileName = "pazar-cadir-1.jpg", Url = "/assets/img/properties/pazar-cadir-1.jpg", AltText = "pazar-cadir-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 58, FileName = "pazar-cadir-2.jpg", Url = "/assets/img/properties/pazar-cadir-2.jpg", AltText = "pazar-cadir-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 59, FileName = "pazar-cadir-3.jpg", Url = "/assets/img/properties/pazar-cadir-3.jpg", AltText = "pazar-cadir-3.jpg", ContentType = "image/jpeg" },
                //Reklam Brandası
                new Media() { Id = 60, FileName = "reklam-afisi-1.jpg", Url = "/assets/img/properties/reklam-afisi-1.jpg", AltText = "reklam-afisi-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 61, FileName = "reklam-afisi-2.jpg", Url = "/assets/img/properties/reklam-afisi-2.jpg", AltText = "reklam-afisi-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 62, FileName = "reklam-afisi-3.jpg", Url = "/assets/img/properties/reklam-afisi-3.jpg", AltText = "reklam-afisi-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 63, FileName = "reklam-afisi-4.jpg", Url = "/assets/img/properties/reklam-afisi-4.jpg", AltText = "reklam-afisi-4.jpg", ContentType = "image/jpeg" },
                //Araç Koruma Brandası
                new Media() { Id = 64, FileName = "arac-korumalari-1.jpg", Url = "/assets/img/properties/arac-korumalari-1.jpg", AltText = "arac-korumalari-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 65, FileName = "arac-korumalari-2.jpg", Url = "/assets/img/properties/arac-korumalari-2.jpg", AltText = "arac-korumalari-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 66, FileName = "arac-korumalari-3.jpg", Url = "/assets/img/properties/arac-korumalari-3.jpg", AltText = "arac-korumalari-3.jpg", ContentType = "image/jpeg" },
                //Yat ve Tekne Brandası
                new Media() { Id = 67, FileName = "yat-brandasi-1.jpg", Url = "/assets/img/properties/yat-brandasi-1.jpg", AltText = "yat-brandasi-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 68, FileName = "yat-brandasi-2.jpg", Url = "/assets/img/properties/yat-brandasi-2.jpg", AltText = "yat-brandasi-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 69, FileName = "yat-brandasi-3.jpg", Url = "/assets/img/properties/yat-brandasi-3.jpg", AltText = "yat-brandasi-3.jpg", ContentType = "image/jpeg" }


                );
        }
    }
}
