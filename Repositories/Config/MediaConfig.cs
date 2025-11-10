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
                new Media() { Id = 69, FileName = "yat-brandasi-3.jpg", Url = "/assets/img/properties/yat-brandasi-3.jpg", AltText = "yat-brandasi-3.jpg", ContentType = "image/jpeg" },
                //Cam Balkon
                new Media() { Id = 70, FileName = "cam-balkon-1.jpg", Url = "/assets/img/properties/cam-balkon-1.jpg", AltText = "cam-balkon-1.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 71, FileName = "cam-balkon-2.jpg", Url = "/assets/img/properties/cam-balkon-2.jpg", AltText = "cam-balkon-2.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 72, FileName = "cam-balkon-3.jpg", Url = "/assets/img/properties/cam-balkon-3.jpg", AltText = "cam-balkon-3.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 73, FileName = "cam-balkon-4.jpg", Url = "/assets/img/properties/cam-balkon-4.jpg", AltText = "cam-balkon-4.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 74, FileName = "cam-balkon-5.jpg", Url = "/assets/img/properties/cam-balkon-5.jpg", AltText = "cam-balkon-5.jpg", ContentType = "image/jpeg" },
                new Media() { Id = 75, FileName = "cam-balkon-6.jpg", Url = "/assets/img/properties/cam-balkon-6.jpg", AltText = "cam-balkon-6.jpg", ContentType = "image/jpeg" },
                //cam-veranda
                new Media() { Id = 76, FileName = "cam-veranda-1.jpg", Url = "/assets/img/properties/cam-veranda-1.jpg", AltText = "cam-veranda-1", ContentType = "image/jpeg" },
                new Media() { Id = 77, FileName = "cam-veranda-2.jpg", Url = "/assets/img/properties/cam-veranda-2.jpg", AltText = "cam-veranda-2", ContentType = "image/jpeg" },
                new Media() { Id = 78, FileName = "cam-veranda-3.jpg", Url = "/assets/img/properties/cam-veranda-3.jpg", AltText = "cam-veranda-3", ContentType = "image/jpeg" },
                new Media() { Id = 79, FileName = "cam-veranda-4.jpg", Url = "/assets/img/properties/cam-veranda-4.jpg", AltText = "cam-veranda-4", ContentType = "image/jpeg" },
                //depo-cadiri
                new Media() { Id = 80, FileName = "depo-cadiri-1.jpg", Url = "/assets/img/properties/depo-cadiri-1.jpg", AltText = "depo-cadiri-1", ContentType = "image/jpeg" },
                new Media() { Id = 81, FileName = "depo-cadiri-2.jpg", Url = "/assets/img/properties/depo-cadiri-2.jpg", AltText = "depo-cadiri-2", ContentType = "image/jpeg" },
                new Media() { Id = 82, FileName = "depo-cadiri-3.jpg", Url = "/assets/img/properties/depo-cadiri-3.jpg", AltText = "depo-cadiri-3", ContentType = "image/jpeg" },
                new Media() { Id = 83, FileName = "depo-cadiri-4.jpg", Url = "/assets/img/properties/depo-cadiri-4.jpg", AltText = "depo-cadiri-4", ContentType = "image/jpeg" },
                //dogal-afet-cadiri
                new Media() { Id = 84, FileName = "dogal-afet-cadiri-1.jpg", Url = "/assets/img/properties/dogal-afet-cadiri-1.jpg", AltText = "dogal-afet-cadiri-1", ContentType = "image/jpeg" },
                new Media() { Id = 85, FileName = "dogal-afet-cadiri-2.jpg", Url = "/assets/img/properties/dogal-afet-cadiri-2.jpg", AltText = "dogal-afet-cadiri-2", ContentType = "image/jpeg" },
                new Media() { Id = 86, FileName = "dogal-afet-cadiri-3.jpg", Url = "/assets/img/properties/dogal-afet-cadiri-3.jpg", AltText = "dogal-afet-cadiri-3", ContentType = "image/jpeg" },
                //hali -saha-cadiri
                new Media() { Id = 87, FileName = "hali -saha-cadiri-1.jpg", Url = "/assets/img/properties/hali -saha-cadiri-1.jpg", AltText = "hali -saha-cadiri-1", ContentType = "image/jpeg" },
                new Media() { Id = 88, FileName = "hali -saha-cadiri-2.jpg", Url = "/assets/img/properties/hali -saha-cadiri-2.jpg", AltText = "hali -saha-cadiri-2", ContentType = "image/jpeg" },
                new Media() { Id = 89, FileName = "hali -saha-cadiri-3.jpg", Url = "/assets/img/properties/hali -saha-cadiri-3.jpg", AltText = "hali -saha-cadiri-3", ContentType = "image/jpeg" },
                //hayvan-besi-cadiri
                new Media() { Id = 90, FileName = "hayvan-besi-cadiri-1.jpg", Url = "/assets/img/properties/hayvan-besi-cadiri-1.jpg", AltText = "hayvan-besi-cadiri-1", ContentType = "image/jpeg" },
                new Media() { Id = 91, FileName = "hayvan-besi-cadiri-2.jpg", Url = "/assets/img/properties/hayvan-besi-cadiri-2.jpg", AltText = "hayvan-besi-cadiri-2", ContentType = "image/jpeg" },
                new Media() { Id = 92, FileName = "hayvan-besi-cadiri-3.jpg", Url = "/assets/img/properties/hayvan-besi-cadiri-3.jpg", AltText = "hayvan-besi-cadiri-3", ContentType = "image/jpeg" },
                //spor-kompleksi-cadiri
                new Media() { Id = 93, FileName = "spor-kompleksi-cadiri-1.jpg", Url = "/assets/img/properties/spor-kompleksi-cadiri-1.jpg", AltText = "spor-kompleksi-cadiri-1", ContentType = "image/jpeg" },
                new Media() { Id = 94, FileName = "spor-kompleksi-cadiri-2.jpg", Url = "/assets/img/properties/spor-kompleksi-cadiri-2.jpg", AltText = "spor-kompleksi-cadiri-2", ContentType = "image/jpeg" },
                new Media() { Id = 95, FileName = "spor-kompleksi-cadiri-3.jpg", Url = "/assets/img/properties/spor-kompleksi-cadiri-3.jpg", AltText = "spor-kompleksi-cadiri-3", ContentType = "image/jpeg" },
                //santiye-cadiri
                new Media() { Id = 96, FileName = "santiye-cadiri-1.jpg", Url = "/assets/img/properties/santiye-cadiri-1.jpg", AltText = "santiye-cadiri-1", ContentType = "image/jpeg" },
                new Media() { Id = 97, FileName = "santiye-cadiri-2.jpg", Url = "/assets/img/properties/santiye-cadiri-2.jpg", AltText = "santiye-cadiri-2", ContentType = "image/jpeg" },
                new Media() { Id = 98, FileName = "santiye-cadiri-3.jpg", Url = "/assets/img/properties/santiye-cadiri-3.jpg", AltText = "santiye-cadiri-3", ContentType = "image/jpeg" },
                //kiralik-cadir
                new Media() { Id = 99, FileName = "kiralik-cadir-1.jpg", Url = "/assets/img/properties/kiralik-cadir-1.jpg", AltText = "kiralik-cadir-1", ContentType = "image/jpeg" },
                new Media() { Id = 100, FileName = "kiralik-cadir-2.jpg", Url = "/assets/img/properties/kiralik-cadir-2.jpg", AltText = "kiralik-cadir-2", ContentType = "image/jpeg" },
                new Media() { Id = 101, FileName = "kiralik-cadir-3.jpg", Url = "/assets/img/properties/kiralik-cadir-3.jpg", AltText = "kiralik-cadir-3", ContentType = "image/jpeg" },
                //konser-toren-cadiri
                new Media() { Id = 102, FileName = "konser-toren-cadiri-1.jpg", Url = "/assets/img/properties/konser-toren-cadiri-1.jpg", AltText = "konser-toren-cadiri-1", ContentType = "image/jpeg" },
                new Media() { Id = 103, FileName = "konser-toren-cadiri-2.jpg", Url = "/assets/img/properties/konser-toren-cadiri-2.jpg", AltText = "konser-toren-cadiri-2", ContentType = "image/jpeg" },
                new Media() { Id = 104, FileName = "konser-toren-cadiri-3.jpg", Url = "/assets/img/properties/konser-toren-cadiri-3.jpg", AltText = "konser-toren-cadiri-3", ContentType = "image/jpeg" },
                //surgulu-sineklik
                new Media() { Id = 105, FileName = "surgulu-sineklik-1.jpg", Url = "/assets/img/properties/surgulu-sineklik-1.jpg", AltText = "surgulu-sineklik-1", ContentType = "image/jpeg" },
                new Media() { Id = 106, FileName = "surgulu-sineklik-2.jpg", Url = "/assets/img/properties/surgulu-sineklik-2.jpg", AltText = "surgulu-sineklik-2", ContentType = "image/jpeg" },
                new Media() { Id = 107, FileName = "surgulu-sineklik-3.jpg", Url = "/assets/img/properties/surgulu-sineklik-3.jpg", AltText = "surgulu-sineklik-3", ContentType = "image/jpeg" },
                new Media() { Id = 108, FileName = "surgulu-sineklik-4.jpg", Url = "/assets/img/properties/surgulu-sineklik-4.jpg", AltText = "surgulu-sineklik-4", ContentType = "image/jpeg" },


                //Motorlu Giyotin Cam
                new Media() { Id = 109, FileName = "motorlu-giyotin-cam-1.jpg", Url = "/assets/img/properties/motorlu-giyotin-cam-1.jpg", AltText = "motorlu-giyotin-cam-1", ContentType = "image/jpeg" },
                new Media() { Id = 110, FileName = "motorlu-giyotin-cam-2.jpg", Url = "/assets/img/properties/motorlu-giyotin-cam-2.jpg", AltText = "motorlu-giyotin-cam-2", ContentType = "image/jpeg" },
                new Media() { Id = 111, FileName = "motorlu-giyotin-cam-3.jpg", Url = "/assets/img/properties/motorlu-giyotin-cam-3.jpg", AltText = "motorlu-giyotin-cam-3", ContentType = "image/jpeg" },
                new Media() { Id = 112, FileName = "motorlu-giyotin-cam-4.jpg", Url = "/assets/img/properties/motorlu-giyotin-cam-4.jpg", AltText = "motorlu-giyotin-cam-4", ContentType = "image/jpeg" },
                //ustte-toplanır-giyotin-cam
                new Media() { Id = 113, FileName = "ustte-toplanır-giyotin-cam-1.jpg", Url = "/assets/img/properties/ustte-toplanır-giyotin-cam-1.jpg", AltText = "ustte-toplanır-giyotin-cam-1", ContentType = "image/jpeg" },
                new Media() { Id = 114, FileName = "ustte-toplanır-giyotin-cam-2.jpg", Url = "/assets/img/properties/ustte-toplanır-giyotin-cam-2.jpg", AltText = "ustte-toplanır-giyotin-cam-2", ContentType = "image/jpeg" },
                new Media() { Id = 115, FileName = "ustte-toplanır-giyotin-cam-3.jpg", Url = "/assets/img/properties/ustte-toplanır-giyotin-cam-3.jpg", AltText = "ustte-toplanır-giyotin-cam-3", ContentType = "image/jpeg" },
                new Media() { Id = 116, FileName = "ustte-toplanır-giyotin-cam-4.jpg", Url = "/assets/img/properties/ustte-toplanır-giyotin-cam-4.jpg", AltText = "ustte-toplanır-giyotin-cam-4", ContentType = "image/jpeg" },
                //silinebilir-giyotin-cam
                new Media() { Id = 117, FileName = "silinebilir-giyotin-cam-1.jpg", Url = "/assets/img/properties/silinebilir-giyotin-cam-1.jpg", AltText = "silinebilir-giyotin-cam-1", ContentType = "image/jpeg" },
                new Media() { Id = 118, FileName = "silinebilir-giyotin-cam-2.jpg", Url = "/assets/img/properties/silinebilir-giyotin-cam-2.jpg", AltText = "silinebilir-giyotin-cam-2", ContentType = "image/jpeg" },
                new Media() { Id = 119, FileName = "silinebilir-giyotin-cam-3.jpg", Url = "/assets/img/properties/silinebilir-giyotin-cam-3.jpg", AltText = "silinebilir-giyotin-cam-3", ContentType = "image/jpeg" },
                new Media() { Id = 120, FileName = "silinebilir-giyotin-cam-4.jpg", Url = "/assets/img/properties/silinebilir-giyotin-cam-4.jpg", AltText = "silinebilir-giyotin-cam-4", ContentType = "image/jpeg" },
                //isi-camli-giyotin
                new Media() { Id = 121, FileName = "isi-camli-giyotin-1.jpg", Url = "/assets/img/properties/isi-camli-giyotin-1.jpg", AltText = "isi-camli-giyotin-1", ContentType = "image/jpeg" },
                new Media() { Id = 122, FileName = "isi-camli-giyotin-2.jpg", Url = "/assets/img/properties/isi-camli-giyotin-2.jpg", AltText = "isi-camli-giyotin-2", ContentType = "image/jpeg" },
                new Media() { Id = 123, FileName = "isi-camli-giyotin-3.jpg", Url = "/assets/img/properties/isi-camli-giyotin-3.jpg", AltText = "isi-camli-giyotin-3", ContentType = "image/jpeg" },
                new Media() { Id = 124, FileName = "isi-camli-giyotin-4.jpg", Url = "/assets/img/properties/isi-camli-giyotin-4.jpg", AltText = "isi-camli-giyotin-4", ContentType = "image/jpeg" },
                //tek-camli-giyotin
                new Media() { Id = 125, FileName = "tek-camli-giyotin-1.jpg", Url = "/assets/img/properties/tek-camli-giyotin-1.jpg", AltText = "tek-camli-giyotin-1", ContentType = "image/jpeg" },
                new Media() { Id = 126, FileName = "tek-camli-giyotin-2.jpg", Url = "/assets/img/properties/tek-camli-giyotin-2.jpg", AltText = "tek-camli-giyotin-2", ContentType = "image/jpeg" },
                new Media() { Id = 127, FileName = "tek-camli-giyotin-3.jpg", Url = "/assets/img/properties/tek-camli-giyotin-3.jpg", AltText = "tek-camli-giyotin-3", ContentType = "image/jpeg" },
                new Media() { Id = 128, FileName = "tek-camli-giyotin-4.jpg", Url = "/assets/img/properties/tek-camli-giyotin-4.jpg", AltText = "tek-camli-giyotin-4", ContentType = "image/jpeg" },
                //kumandali-giyotin-cam
                new Media() { Id = 129, FileName = "tek-camli-giyotin-4.jpg", Url = "/assets/img/properties/tek-camli-giyotin-4.jpg", AltText = "tek-camli-giyotin-4", ContentType = "image/jpeg" },
                new Media() { Id = 130, FileName = "tek-camli-giyotin-4.jpg", Url = "/assets/img/properties/tek-camli-giyotin-4.jpg", AltText = "tek-camli-giyotin-4", ContentType = "image/jpeg" },
                new Media() { Id = 131, FileName = "tek-camli-giyotin-4.jpg", Url = "/assets/img/properties/tek-camli-giyotin-4.jpg", AltText = "tek-camli-giyotin-4", ContentType = "image/jpeg" },
                new Media() { Id = 132, FileName = "tek-camli-giyotin-4.jpg", Url = "/assets/img/properties/tek-camli-giyotin-4.jpg", AltText = "tek-camli-giyotin-4", ContentType = "image/jpeg" },
                //katlanir-cam-balkon
                new Media() { Id = 133, FileName = "katlanir-cam-balkon-1.jpg", Url = "/assets/img/properties/katlanir-cam-balkon-1.jpg", AltText = "katlanir-cam-balkon-1", ContentType = "image/jpeg" },
                new Media() { Id = 134, FileName = "katlanir-cam-balkon-2.jpg", Url = "/assets/img/properties/katlanir-cam-balkon-2.jpg", AltText = "katlanir-cam-balkon-2", ContentType = "image/jpeg" },
                new Media() { Id = 135, FileName = "katlanir-cam-balkon-3.jpg", Url = "/assets/img/properties/katlanir-cam-balkon-3.jpg", AltText = "katlanir-cam-balkon-3", ContentType = "image/jpeg" },
                new Media() { Id = 136, FileName = "katlanir-cam-balkon-4.jpg", Url = "/assets/img/properties/katlanir-cam-balkon-4.jpg", AltText = "katlanir-cam-balkon-4", ContentType = "image/jpeg" },
                //acilir-cam-tavan-sistemleri
                new Media() { Id = 137, FileName = "acilir-cam-tavan-sistemleri-1.jpg", Url = "/assets/img/properties/acilir-cam-tavan-sistemleri-1.jpg", AltText = "acilir-cam-tavan-sistemleri-1", ContentType = "image/jpeg" },
                new Media() { Id = 138, FileName = "acilir-cam-tavan-sistemleri-2.jpg", Url = "/assets/img/properties/acilir-cam-tavan-sistemleri-2.jpg", AltText = "acilir-cam-tavan-sistemleri-2", ContentType = "image/jpeg" },
                new Media() { Id = 139, FileName = "acilir-cam-tavan-sistemleri-3.jpg", Url = "/assets/img/properties/acilir-cam-tavan-sistemleri-3.jpg", AltText = "acilir-cam-tavan-sistemleri-3", ContentType = "image/jpeg" },
                new Media() { Id = 140, FileName = "acilir-cam-tavan-sistemleri-4.jpg", Url = "/assets/img/properties/acilir-cam-tavan-sistemleri-4.jpg", AltText = "acilir-cam-tavan-sistemleri-4", ContentType = "image/jpeg" },
                //cam-cati-sistemleri
                new Media() { Id = 141, FileName = "cam-cati-sistemleri-1.jpg", Url = "/assets/img/properties/cam-cati-sistemleri-1.jpg", AltText = "cam-cati-sistemleri-1", ContentType = "image/jpeg" },
                new Media() { Id = 142, FileName = "cam-cati-sistemleri-2.jpg", Url = "/assets/img/properties/cam-cati-sistemleri-2.jpg", AltText = "cam-cati-sistemleri-2", ContentType = "image/jpeg" },
                new Media() { Id = 143, FileName = "cam-cati-sistemleri-3.jpg", Url = "/assets/img/properties/cam-cati-sistemleri-3.jpg", AltText = "cam-cati-sistemleri-3", ContentType = "image/jpeg" },
                new Media() { Id = 144, FileName = "cam-cati-sistemleri-4.jpg", Url = "/assets/img/properties/cam-cati-sistemleri-4.jpg", AltText = "cam-cati-sistemleri-4", ContentType = "image/jpeg" },
                //motorlu-tente
                new Media() { Id = 145, FileName = "motorlu-tente-1.jpg", Url = "/assets/img/properties/motorlu-tente-1.jpg", AltText = "motorlu-tente-1", ContentType = "image/jpeg" },
                new Media() { Id = 146, FileName = "motorlu-tente-2.jpg", Url = "/assets/img/properties/motorlu-tente-2.jpg", AltText = "motorlu-tente-2", ContentType = "image/jpeg" },
                new Media() { Id = 147, FileName = "motorlu-tente-3.jpg", Url = "/assets/img/properties/motorlu-tente-3.jpg", AltText = "motorlu-tente-3", ContentType = "image/jpeg" },
                new Media() { Id = 148, FileName = "motorlu-tente-4.jpg", Url = "/assets/img/properties/motorlu-tente-4.jpg", AltText = "motorlu-tente-4", ContentType = "image/jpeg" },
                //sabit-tente
                new Media() { Id = 149, FileName = "sabit-tente-1.jpg", Url = "/assets/img/properties/sabit-tente-1.jpg", AltText = "sabit-tente-1", ContentType = "image/jpeg" },
                new Media() { Id = 150, FileName = "sabit-tente-2.jpg", Url = "/assets/img/properties/sabit-tente-2.jpg", AltText = "sabit-tente-2", ContentType = "image/jpeg" },
                new Media() { Id = 151, FileName = "sabit-tente-3.jpg", Url = "/assets/img/properties/sabit-tente-3.jpg", AltText = "sabit-tente-3", ContentType = "image/jpeg" },
                new Media() { Id = 152, FileName = "sabit-tente-4.jpg", Url = "/assets/img/properties/sabit-tente-4.jpg", AltText = "sabit-tente-4", ContentType = "image/jpeg" },
                //kumandali-tente
                new Media() { Id = 153, FileName = "kumandali-tente-1.jpg", Url = "/assets/img/properties/kumandali-tente-1.jpg", AltText = "kumandali-tente-1", ContentType = "image/jpeg" },
                new Media() { Id = 154, FileName = "kumandali-tente-2.jpg", Url = "/assets/img/properties/kumandali-tente-2.jpg", AltText = "kumandali-tente-2", ContentType = "image/jpeg" },
                new Media() { Id = 155, FileName = "kumandali-tente-3.jpg", Url = "/assets/img/properties/kumandali-tente-3.jpg", AltText = "kumandali-tente-3", ContentType = "image/jpeg" },
                new Media() { Id = 156, FileName = "kumandali-tente-4.jpg", Url = "/assets/img/properties/kumandali-tente-4.jpg", AltText = "kumandali-tente-4", ContentType = "image/jpeg" },
                //rolling-roof-tente
                new Media() { Id = 157, FileName = "rolling-roof-tente-1.jpg", Url = "/assets/img/properties/rolling-roof-tente-1.jpg", AltText = "rolling-roof-tente-1", ContentType = "image/jpeg" },
                new Media() { Id = 158, FileName = "rolling-roof-tente-2.jpg", Url = "/assets/img/properties/rolling-roof-tente-2.jpg", AltText = "rolling-roof-tente-2", ContentType = "image/jpeg" },
                new Media() { Id = 159, FileName = "rolling-roof-tente-3.jpg", Url = "/assets/img/properties/rolling-roof-tente-3.jpg", AltText = "rolling-roof-tente-3", ContentType = "image/jpeg" },
                new Media() { Id = 160, FileName = "rolling-roof-tente-4.jpg", Url = "/assets/img/properties/rolling-roof-tente-4.jpg", AltText = "rolling-roof-tente-4", ContentType = "image/jpeg" },
                //bio-klimatik-tente
                new Media() { Id = 161, FileName = "bio-klimatik-tente-1.jpg", Url = "/assets/img/properties/bio-klimatik-tente-1.jpg", AltText = "bio-klimatik-tente-1", ContentType = "image/jpeg" },
                new Media() { Id = 162, FileName = "bio-klimatik-tente-2.jpg", Url = "/assets/img/properties/bio-klimatik-tente-2.jpg", AltText = "bio-klimatik-tente-2", ContentType = "image/jpeg" },
                new Media() { Id = 163, FileName = "bio-klimatik-tente-3.jpg", Url = "/assets/img/properties/bio-klimatik-tente-3.jpg", AltText = "bio-klimatik-tente-3", ContentType = "image/jpeg" },
                new Media() { Id = 164, FileName = "bio-klimatik-tente-4.jpg", Url = "/assets/img/properties/bio-klimatik-tente-4.jpg", AltText = "bio-klimatik-tente-4", ContentType = "image/jpeg" },

                //Teknik özellikler
                new Media() { Id = 165, FileName = "Pergola-Tente-Teknik-Ozellikleri.jpg", Url = "/assets/img/service/teknikozellik/Pergola-Tente-Teknik-Ozellikleri.jpg", AltText = "Pergola-Tente-Teknik-Ozellikleri", ContentType = "image/jpeg" },
                //Blackout Pergola Tente Kumaşı
                new Media() { Id = 166, FileName = "blackout-pergola-tente-kumaşı-1.jpg", Url = "/assets/img/service/blackout/blackout-pergola-tente-kumaşı-1.jpg", AltText = "blackout-pergola-tente-kumaşı-1", ContentType = "image/jpeg" },
                new Media() { Id = 167, FileName = "blackout-pergola-tente-kumaşı-2.jpg", Url = "/assets/img/service/blackout/blackout-pergola-tente-kumaşı-2.jpg", AltText = "blackout-pergola-tente-kumaşı-2", ContentType = "image/jpeg" },
                new Media() { Id = 168, FileName = "blackout-pergola-tente-kumaşı-3.jpg", Url = "/assets/img/service/blackout/blackout-pergola-tente-kumaşı-3.jpg", AltText = "blackout-pergola-tente-kumaşı-3", ContentType = "image/jpeg" },
                //pergolateknik
                new Media() { Id = 169, FileName = "pergolateknik-1.jpg", Url = "/assets/img/service/pergolateknik/pergolateknik-1.jpg", AltText = "pergolateknik-1", ContentType = "image/jpeg" },
                new Media() { Id = 170, FileName = "pergolateknik-2.jpg", Url = "/assets/img/service/pergolateknik/pergolateknik-2.jpg", AltText = "pergolateknik-2", ContentType = "image/jpeg" },
                new Media() { Id = 171, FileName = "pergolateknik-3.jpg", Url = "/assets/img/service/pergolateknik/pergolateknik-3.jpg", AltText = "pergolateknik-3", ContentType = "image/jpeg" },
                //tenteimalatı
                new Media() { Id = 172, FileName = "tente-imalatı-1.jpg", Url = "/assets/img/service/tenteimalati/tente-imalatı-1.jpg", AltText = "tente-imalatı-1", ContentType = "image/jpeg" },
                new Media() { Id = 173, FileName = "tente-imalatı-2.jpg", Url = "/assets/img/service/tenteimalati/tente-imalatı-2.jpg", AltText = "tente-imalatı-2", ContentType = "image/jpeg" },
                new Media() { Id = 174, FileName = "tente-imalatı-3.jpg", Url = "/assets/img/service/tenteimalati/tente-imalatı-3.jpg", AltText = "tente-imalatı-3", ContentType = "image/jpeg" },
                //kullanim-ozellikleri
                new Media() { Id = 175, FileName = "kullanim-ozellikleri-1.jpg", Url = "/assets/img/service/kullanim-ozellikleri/kullanim-ozellikleri-1.jpg", AltText = "kullanim-ozellikleri-1", ContentType = "image/jpeg" },
                new Media() { Id = 176, FileName = "kullanim-ozellikleri-2.jpg", Url = "/assets/img/service/kullanim-ozellikleri/kullanim-ozellikleri-2.jpg", AltText = "kullanim-ozellikleri-2", ContentType = "image/jpeg" },
                new Media() { Id = 177, FileName = "kullanim-ozellikleri-3.jpg", Url = "/assets/img/service/kullanim-ozellikleri/kullanim-ozellikleri-3.jpg", AltText = "kullanim-ozellikleri-3", ContentType = "image/jpeg" },
                //projeler
                new Media() { Id = 178, FileName = "projeler-1.jpg", Url = "/assets/img/service/projeler/projeler-1.jpg", AltText = "projeler-1", ContentType = "image/jpeg" },
                new Media() { Id = 179, FileName = "projeler-2.jpg", Url = "/assets/img/service/projeler/projeler-2.jpg", AltText = "projeler-2", ContentType = "image/jpeg" },
                new Media() { Id = 180, FileName = "projeler-3.jpg", Url = "/assets/img/service/projeler/projeler-3.jpg", AltText = "projeler-3", ContentType = "image/jpeg" },
                //faydali-bilgiler
                new Media() { Id = 181, FileName = "faydali-bilgiler-1.jpg", Url = "/assets/img/service/faydali-bilgiler/faydali-bilgiler-1.jpg", AltText = "faydali-bilgiler-1", ContentType = "image/jpeg" },
                new Media() { Id = 182, FileName = "faydali-bilgiler-2.jpg", Url = "/assets/img/service/faydali-bilgiler/faydali-bilgiler-2.jpg", AltText = "faydali-bilgiler-2", ContentType = "image/jpeg" },
                new Media() { Id = 183, FileName = "faydali-bilgiler-3.jpg", Url = "/assets/img/service/faydali-bilgiler/faydali-bilgiler-3.jpg", AltText = "faydali-bilgiler-3", ContentType = "image/jpeg" },
                //teknikservis
                new Media() { Id = 184, FileName = "teknikservis-1.jpg", Url = "/assets/img/service/teknikservis/teknikservis-1.jpg", AltText = "teknikservis-1", ContentType = "image/jpeg" },
                new Media() { Id = 185, FileName = "teknikservis-2.jpg", Url = "/assets/img/service/teknikservis/teknikservis-2.jpg", AltText = "teknikservis-2", ContentType = "image/jpeg" },
                new Media() { Id = 186, FileName = "teknikservis-3.jpg", Url = "/assets/img/service/teknikservis/teknikservis-3.jpg", AltText = "teknikservis-3", ContentType = "image/jpeg" }

                );
        }
    }
}
