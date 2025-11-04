using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false),
                    Slug = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    AltText = table.Column<string>(type: "text", nullable: false),
                    ContentType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Slug = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Services_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Slug = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "ServiceImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    MediaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceImages_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceImages_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    MediaId = table.Column<int>(type: "integer", nullable: false),
                    IsMain = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description", "ImageUrl", "Slug" },
                values: new object[,]
                {
                    { 1, "Giyotin Cam Sistemleri", "Giyotin Cam Sistemi Giyotin Cam Sistemi, Teksan All Clean, modern mimariye uyarlanmış en estetik tasarımdır. Bu uzaktan kumandalı sistem, tam panoramik manzaraya", "assets/img/categories/Giyotin-Cam-Sistemi.jpg", "giyotin-cam-sistemleri" },
                    { 2, "Tente Sistemleri", "Tente Sistemleri Fonksiyonel özellikleri ve estetik görüntüsüyle ön plana çıkan Tente modeli, mafsallı tente sınıfının en gelişmiş ve en sağlam Pergola Tente modelidir. Ticari alanlarda veya konutlarda kullanılan pergola tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergola tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar.", "assets/img/categories/pergola.jpg", "teksan-tente" },
                    { 3, "Branda Sistemleri", "Branda Branda çeşitleri, brandaların örnekleri, branda modelleri, istanbul branda, branda fiyatları, balkon brandası, branda kumaşları, Firmamız Yaygın Servis ağı ile oluşacak arıza veya hasar durumunda çadır veya tente sistemine anında müdale fırsatı sunmaktadır. Fiyat bakımından ve kalite bakımından neden uygunuz ? Biz Tente kumaşları toptan şatışı ve bu ürünlerin imalatını.", "assets/img/categories/kamelya-branda-570x350.jpg", "branda-sistemleri" },
                    { 4, "Cam Sistemleri", "Açılır Cam Tavan Sistemleri Açılır Cam Tavan Sistemleri, Kışın yağmur,kar ve rüzgarı dışarıda bırakabileceğiniz, yaz aylarında ise güneşin tadını doyasıya çıkartabileceğiniz bir yaşam alanına sahip olmaya ne dersiniz ? Sabit Cam Tavan (Veranda) uygun malzeme seçeneği Sabit Cam Tavan (Veranda) Sabit cam tavan kış bahçelerine, teras ve balkon üstlerine yapılabilen.", "assets/img/categories/Acilir-Cam-Tavan-Sistemleri.jpg", "cam-sistemleri" },
                    { 5, "Çadır Sistemleri", "Konser tören çadırı gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın daha serin bir hava ortamına sahip olmak için sizlerde bu çadırı yaptırmalısınız. Geniş renk seçeneğimiz ve dayanıklı kumaş modellerimiz ile dilediğiniz her tür marka model brandayı firmamızda bulabilirsiniz. Yapacağımız tüm çalışmalar firmamız tarafından garanti sertifikalı iş teslimatı.", "assets/img/categories/toren-cadiri.jpg", "cadır-sistemleri" },
                    { 6, "Sineklik Sistemleri", "Evlerimizde, ofislerimizde ve yaşam alanlarımızda en çok ihtiyaç duyulan konforlardan biri temiz hava alırken böcek ve haşerelerden korunmaktır. Sineklik sistemleri, estetik görünümleri ve pratik kullanımlarıyla bu ihtiyaca en ideal çözümü sunar.", "assets/img/categories/istanbul-sineklik-fiyatlari.jpg", "sineklik-sistemleri" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 1, "Tente Ürünü 1", "image/jpeg", "Pergole-Tente.jpg", "/assets/img/properties/Pergole-Tente.jpg" },
                    { 2, "Tente Ürünü 2", "image/jpeg", "Pergole-Tente-2.jpg", "/assets/img/properties/Pergole-Tente-2.jpg" },
                    { 3, "Service ilk resim", "image/jpeg", "service-2.jpg", "/assets/img/service/service-2.jpg" },
                    { 4, "koruktentekapak", "image/jpeg", "koruktente-1.jpg", "/assets/img/properties/koruktente-1.jpg" },
                    { 5, "koruktente-2", "image/jpeg", "koruktente-2.jpg", "/assets/img/properties/koruktente-2.jpg" },
                    { 6, "koruktente-3", "image/jpeg", "koruktente-3.jpg", "/assets/img/properties/koruktente-3.jpg" },
                    { 7, "koruktente-4", "image/jpeg", "koruktente-4.jpg", "/assets/img/properties/koruktente-4.jpg" },
                    { 8, "koruktente-5", "image/jpeg", "koruktente-5.jpg", "/assets/img/properties/koruktente-5.jpg" },
                    { 9, "Pergole-Tente-1.jpg", "image/jpeg", "Pergole-1.jpg", "/assets/img/properties/Pergole-Tente-1.jpg" },
                    { 10, "Pergole-Tente-3.jpg", "image/jpeg", "Pergole-3.jpg", "/assets/img/properties/Pergole-Tente-3.jpg" },
                    { 11, "Pergole-Tente-4.jpg", "image/jpeg", "Pergole-4.jpg", "/assets/img/properties/Pergole-Tente-4.jpg" },
                    { 12, "Pergole-Tente-5.jpg", "image/jpeg", "Pergole-5.jpg", "/assets/img/properties/Pergole-Tente-5.jpg" },
                    { 13, "stor-tente-1.jpg", "image/jpeg", "stor-tente-1.jpg", "/assets/img/properties/stor-tente-1.jpg" },
                    { 14, "stor-tente-2.jpg", "image/jpeg", "stor-tente-2.jpg", "/assets/img/properties/stor-tente-2.jpg" },
                    { 15, "stor-tente-3.jpg", "image/jpeg", "stor-tente-3.jpg", "/assets/img/properties/stor-tente-3.jpg" },
                    { 16, "stor-tente-4.jpg", "image/jpeg", "stor-tente-4.jpg", "/assets/img/properties/stor-tente-4.jpg" },
                    { 17, "cift-acilir-tente-1.jpg", "image/jpeg", "cift-acilir-tente-1.jpg", "/assets/img/properties/cift-acilir-tente-1.jpg" },
                    { 18, "cift-acilir-tente-2.jpg", "image/jpeg", "cift-acilir-tente-2.jpg", "/assets/img/properties/cift-acilir-tente-2.jpg" },
                    { 19, "cift-acilir-tente-3.jpg", "image/jpeg", "cift-acilir-tente-3.jpg", "/assets/img/properties/cift-acilir-tente-3.jpg" },
                    { 20, "cift-acilir-tente-4.jpg", "image/jpeg", "cift-acilir-tente-4.jpg", "/assets/img/properties/cift-acilir-tente-4.jpg" },
                    { 21, "mafsal-tente-1.jpg", "image/jpeg", "mafsal-tente-1.jpg", "/assets/img/properties/mafsal-tente-1.jpg" },
                    { 22, "mafsal-tente-2.jpg", "image/jpeg", "mafsal-tente-2.jpg", "/assets/img/properties/mafsal-tente-2.jpg" },
                    { 23, "mafsal-tente-3.jpg", "image/jpeg", "mafsal-tente-3.jpg", "/assets/img/properties/mafsal-tente-3.jpg" },
                    { 24, "mafsal-tente-4.jpg", "image/jpeg", "mafsal-tente-4.jpg", "/assets/img/properties/mafsal-tente-4.jpg" },
                    { 25, "giyotin-cam-1.jpg", "image/jpeg", "giyotin-cam-1.jpg", "/assets/img/properties/giyotin-cam-1.jpg" },
                    { 26, "giyotin-cam-2.jpg", "image/jpeg", "giyotin-cam-2.jpg", "/assets/img/properties/giyotin-cam-2.jpg" },
                    { 27, "giyotin-cam-3.jpg", "image/jpeg", "giyotin-cam-3.jpg", "/assets/img/properties/giyotin-cam-3.jpg" },
                    { 28, "giyotin-cam-4.jpg", "image/jpeg", "giyotin-cam-4.jpg", "/assets/img/properties/giyotin-cam-4.jpg" },
                    { 29, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-1.jpg", "/assets/img/properties/fotoselli-kapi-1.jpg" },
                    { 30, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-2.jpg", "/assets/img/properties/fotoselli-kapi-2.jpg" },
                    { 31, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-3.jpg", "/assets/img/properties/fotoselli-kapi-3.jpg" },
                    { 32, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-4.jpg", "/assets/img/properties/fotoselli-kapi-4.jpg" },
                    { 33, "kis-bahcecileri-1.jpg", "image/jpeg", "kis-bahcecileri-1.jpg", "/assets/img/properties/kis-bahcecileri-1.jpg" },
                    { 34, "kis-bahcecileri-2.jpg", "image/jpeg", "kis-bahcecileri-2.jpg", "/assets/img/properties/kis-bahcecileri-2.jpg" },
                    { 35, "kis-bahcecileri-3.jpg", "image/jpeg", "kis-bahcecileri-3.jpg", "/assets/img/properties/kis-bahcecileri-3.jpg" },
                    { 36, "kis-bahcecileri-4.jpg", "image/jpeg", "kis-bahcecileri-4.jpg", "/assets/img/properties/kis-bahcecileri-4.jpg" },
                    { 37, "seffaf-alan-kapama-1.jpg", "image/jpeg", "seffaf-alan-kapama-1.jpg", "/assets/img/properties/seffaf-alan-kapama-1.jpg" },
                    { 38, "seffaf-alan-kapama-2.jpg", "image/jpeg", "seffaf-alan-kapama-2.jpg", "/assets/img/properties/seffaf-alan-kapama-2.jpg" },
                    { 39, "seffaf-alan-kapama-3.jpg", "image/jpeg", "seffaf-alan-kapama-3.jpg", "/assets/img/properties/seffaf-alan-kapama-3.jpg" },
                    { 40, "seffaf-alan-kapama-4.jpg", "image/jpeg", "seffaf-alan-kapama-4.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 41, "seffaf-branda-1.jpg", "image/jpeg", "seffaf-branda-1.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 42, "seffaf-branda-2.jpg", "image/jpeg", "seffaf-branda-2.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 43, "seffaf-branda-3.jpg", "image/jpeg", "seffaf-branda-3.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 44, "seffaf-branda-4.jpg", "image/jpeg", "seffaf-branda-4.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 45, "havuz-brandasi-1.jpg", "image/jpeg", "havuz-brandasi-1.jpg", "/assets/img/properties/havuz-brandasi-1.jpg" },
                    { 46, "havuz-brandasi-2.jpg", "image/jpeg", "havuz-brandasi-2.jpg", "/assets/img/properties/havuz-brandasi-2.jpg" },
                    { 47, "havuz-brandasi-3.jpg", "image/jpeg", "havuz-brandasi-3.jpg", "/assets/img/properties/havuz-brandasi-3.jpg" },
                    { 48, "havuz-brandasi-4.jpg", "image/jpeg", "havuz-brandasi-4.jpg", "/assets/img/properties/havuz-brandasi-4.jpg" },
                    { 49, "iskele-branda-1.jpg", "image/jpeg", "iskele-branda-1.jpg", "/assets/img/properties/iskele-branda-1.jpg" },
                    { 50, "iskele-branda-2.jpg", "image/jpeg", "iskele-branda-2.jpg", "/assets/img/properties/iskele-branda-2.jpg" },
                    { 51, "iskele-branda-3.jpg", "image/jpeg", "iskele-branda-3.jpg", "/assets/img/properties/iskele-branda-3.jpg" },
                    { 52, "iskele-branda-4.jpg", "image/jpeg", "iskele-branda-4.jpg", "/assets/img/properties/iskele-branda-4.jpg" },
                    { 53, "kamleya-brandasi-1.jpg", "image/jpeg", "kamleya-brandasi-1.jpg", "/assets/img/properties/kamleya-brandasi-1.jpg" },
                    { 54, "kamleya-brandasi-2.jpg", "image/jpeg", "kamleya-brandasi-2.jpg", "/assets/img/properties/kamleya-brandasi-2.jpg" },
                    { 55, "kamleya-brandasi-3.jpg", "image/jpeg", "kamleya-brandasi-3.jpg", "/assets/img/properties/kamleya-brandasi-3.jpg" },
                    { 56, "kamleya-brandasi-4.jpg", "image/jpeg", "kamleya-brandasi-4.jpg", "/assets/img/properties/kamleya-brandasi-4.jpg" },
                    { 57, "pazar-cadir-1.jpg", "image/jpeg", "pazar-cadir-1.jpg", "/assets/img/properties/pazar-cadir-1.jpg" },
                    { 58, "pazar-cadir-2.jpg", "image/jpeg", "pazar-cadir-2.jpg", "/assets/img/properties/pazar-cadir-2.jpg" },
                    { 59, "pazar-cadir-3.jpg", "image/jpeg", "pazar-cadir-3.jpg", "/assets/img/properties/pazar-cadir-3.jpg" },
                    { 60, "reklam-afisi-1.jpg", "image/jpeg", "reklam-afisi-1.jpg", "/assets/img/properties/reklam-afisi-1.jpg" },
                    { 61, "reklam-afisi-2.jpg", "image/jpeg", "reklam-afisi-2.jpg", "/assets/img/properties/reklam-afisi-2.jpg" },
                    { 62, "reklam-afisi-3.jpg", "image/jpeg", "reklam-afisi-3.jpg", "/assets/img/properties/reklam-afisi-3.jpg" },
                    { 63, "reklam-afisi-4.jpg", "image/jpeg", "reklam-afisi-4.jpg", "/assets/img/properties/reklam-afisi-4.jpg" },
                    { 64, "arac-korumalari-1.jpg", "image/jpeg", "arac-korumalari-1.jpg", "/assets/img/properties/arac-korumalari-1.jpg" },
                    { 65, "arac-korumalari-2.jpg", "image/jpeg", "arac-korumalari-2.jpg", "/assets/img/properties/arac-korumalari-2.jpg" },
                    { 66, "arac-korumalari-3.jpg", "image/jpeg", "arac-korumalari-3.jpg", "/assets/img/properties/arac-korumalari-3.jpg" },
                    { 67, "yat-brandasi-1.jpg", "image/jpeg", "yat-brandasi-1.jpg", "/assets/img/properties/yat-brandasi-1.jpg" },
                    { 68, "yat-brandasi-2.jpg", "image/jpeg", "yat-brandasi-2.jpg", "/assets/img/properties/yat-brandasi-2.jpg" },
                    { 69, "yat-brandasi-3.jpg", "image/jpeg", "yat-brandasi-3.jpg", "/assets/img/properties/yat-brandasi-3.jpg" },
                    { 70, "cam-balkon-1.jpg", "image/jpeg", "cam-balkon-1.jpg", "/assets/img/properties/cam-balkon-1.jpg" },
                    { 71, "cam-balkon-2.jpg", "image/jpeg", "cam-balkon-2.jpg", "/assets/img/properties/cam-balkon-2.jpg" },
                    { 72, "cam-balkon-3.jpg", "image/jpeg", "cam-balkon-3.jpg", "/assets/img/properties/cam-balkon-3.jpg" },
                    { 73, "cam-balkon-4.jpg", "image/jpeg", "cam-balkon-4.jpg", "/assets/img/properties/cam-balkon-4.jpg" },
                    { 74, "cam-balkon-5.jpg", "image/jpeg", "cam-balkon-5.jpg", "/assets/img/properties/cam-balkon-5.jpg" },
                    { 75, "cam-balkon-6.jpg", "image/jpeg", "cam-balkon-6.jpg", "/assets/img/properties/cam-balkon-6.jpg" },
                    { 76, "cam-veranda-1", "image/jpeg", "cam-veranda-1.jpg", "/assets/img/properties/cam-veranda-1.jpg" },
                    { 77, "cam-veranda-2", "image/jpeg", "cam-veranda-2.jpg", "/assets/img/properties/cam-veranda-2.jpg" },
                    { 78, "cam-veranda-3", "image/jpeg", "cam-veranda-3.jpg", "/assets/img/properties/cam-veranda-3.jpg" },
                    { 79, "cam-veranda-4", "image/jpeg", "cam-veranda-4.jpg", "/assets/img/properties/cam-veranda-4.jpg" },
                    { 80, "depo-cadiri-1", "image/jpeg", "depo-cadiri-1.jpg", "/assets/img/properties/depo-cadiri-1.jpg" },
                    { 81, "depo-cadiri-2", "image/jpeg", "depo-cadiri-2.jpg", "/assets/img/properties/depo-cadiri-2.jpg" },
                    { 82, "depo-cadiri-3", "image/jpeg", "depo-cadiri-3.jpg", "/assets/img/properties/depo-cadiri-3.jpg" },
                    { 83, "depo-cadiri-4", "image/jpeg", "depo-cadiri-4.jpg", "/assets/img/properties/depo-cadiri-4.jpg" },
                    { 84, "dogal-afet-cadiri-1", "image/jpeg", "dogal-afet-cadiri-1.jpg", "/assets/img/properties/dogal-afet-cadiri-1.jpg" },
                    { 85, "dogal-afet-cadiri-2", "image/jpeg", "dogal-afet-cadiri-2.jpg", "/assets/img/properties/dogal-afet-cadiri-2.jpg" },
                    { 86, "dogal-afet-cadiri-3", "image/jpeg", "dogal-afet-cadiri-3.jpg", "/assets/img/properties/dogal-afet-cadiri-3.jpg" },
                    { 87, "hali -saha-cadiri-1", "image/jpeg", "hali -saha-cadiri-1.jpg", "/assets/img/properties/hali -saha-cadiri-1.jpg" },
                    { 88, "hali -saha-cadiri-2", "image/jpeg", "hali -saha-cadiri-2.jpg", "/assets/img/properties/hali -saha-cadiri-2.jpg" },
                    { 89, "hali -saha-cadiri-3", "image/jpeg", "hali -saha-cadiri-3.jpg", "/assets/img/properties/hali -saha-cadiri-3.jpg" },
                    { 90, "hayvan-besi-cadiri-1", "image/jpeg", "hayvan-besi-cadiri-1.jpg", "/assets/img/properties/hayvan-besi-cadiri-1.jpg" },
                    { 91, "hayvan-besi-cadiri-2", "image/jpeg", "hayvan-besi-cadiri-2.jpg", "/assets/img/properties/hayvan-besi-cadiri-2.jpg" },
                    { 92, "hayvan-besi-cadiri-3", "image/jpeg", "hayvan-besi-cadiri-3.jpg", "/assets/img/properties/hayvan-besi-cadiri-3.jpg" },
                    { 93, "spor-kompleksi-cadiri-1", "image/jpeg", "spor-kompleksi-cadiri-1.jpg", "/assets/img/properties/spor-kompleksi-cadiri-1.jpg" },
                    { 94, "spor-kompleksi-cadiri-2", "image/jpeg", "spor-kompleksi-cadiri-2.jpg", "/assets/img/properties/spor-kompleksi-cadiri-2.jpg" },
                    { 95, "spor-kompleksi-cadiri-3", "image/jpeg", "spor-kompleksi-cadiri-3.jpg", "/assets/img/properties/spor-kompleksi-cadiri-3.jpg" },
                    { 96, "santiye-cadiri-1", "image/jpeg", "santiye-cadiri-1.jpg", "/assets/img/properties/santiye-cadiri-1.jpg" },
                    { 97, "santiye-cadiri-2", "image/jpeg", "santiye-cadiri-2.jpg", "/assets/img/properties/santiye-cadiri-2.jpg" },
                    { 98, "santiye-cadiri-3", "image/jpeg", "santiye-cadiri-3.jpg", "/assets/img/properties/santiye-cadiri-3.jpg" },
                    { 99, "kiralik-cadir-1", "image/jpeg", "kiralik-cadir-1.jpg", "/assets/img/properties/kiralik-cadir-1.jpg" },
                    { 100, "kiralik-cadir-2", "image/jpeg", "kiralik-cadir-2.jpg", "/assets/img/properties/kiralik-cadir-2.jpg" },
                    { 101, "kiralik-cadir-3", "image/jpeg", "kiralik-cadir-3.jpg", "/assets/img/properties/kiralik-cadir-3.jpg" },
                    { 102, "konser-toren-cadiri-1", "image/jpeg", "konser-toren-cadiri-1.jpg", "/assets/img/properties/konser-toren-cadiri-1.jpg" },
                    { 103, "konser-toren-cadiri-2", "image/jpeg", "konser-toren-cadiri-2.jpg", "/assets/img/properties/konser-toren-cadiri-2.jpg" },
                    { 104, "konser-toren-cadiri-3", "image/jpeg", "konser-toren-cadiri-3.jpg", "/assets/img/properties/konser-toren-cadiri-3.jpg" },
                    { 105, "surgulu-sineklik-1", "image/jpeg", "surgulu-sineklik-1.jpg", "/assets/img/properties/surgulu-sineklik-1.jpg" },
                    { 106, "surgulu-sineklik-2", "image/jpeg", "surgulu-sineklik-2.jpg", "/assets/img/properties/surgulu-sineklik-2.jpg" },
                    { 107, "surgulu-sineklik-3", "image/jpeg", "surgulu-sineklik-3.jpg", "/assets/img/properties/surgulu-sineklik-3.jpg" },
                    { 108, "surgulu-sineklik-4", "image/jpeg", "surgulu-sineklik-4.jpg", "/assets/img/properties/surgulu-sineklik-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name", "ParentId", "Slug" },
                values: new object[,]
                {
                    { 1, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Teknik Servis", null, "teknik-servis" },
                    { 2, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Teknik Özellikler", null, "teknik-ozellikler" },
                    { 6, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Kullanım Özellikleri", null, "kullanim-ozellikleri" },
                    { 7, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Projeler", null, "projeler" },
                    { 8, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Faydalı Bilgiler", null, "faydali-bilgiler" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Comment", "Name", "Price", "Slug" },
                values: new object[,]
                {
                    { 1, 2, "Pergole Tenteler Ticari alanlarda veya konutlarda kullanılan pergole tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergole tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar. Bu sistemler teknolojik gelişmelerle birlikte güncellenip motor ve sensör desteğiyle daha kullanışlı hale gelmiştir. İşyeriniz veya eviniz için ihtiyacınız olan tüm pergola tenteleri firmamızdan uygun fiyatlarla tedarik edebilirsiniz. ", "Pergole Tente", null, "pergole-tente" },
                    { 2, 2, "Körüklü tentelerin kurulumu ve kullanıma kolay tente modellerinden sadece biridir. Tente Sistemi Akordeon Şeklinde Açılıp Kapanmaktadır Diğer Tentelerde Farkı yan kısımlar Kapalı olduğundan Güneş ve Yağmur gelmesini Engeller  kullanıldığı alanlarda şık Dizaynı ve Tasarımıyla bulunduğu alana ayrı bir Görsellik katar.\r\n\r\nKörüklü Sisteminin Saçak Modeli Deniz dalgası modeli veya Düz saçak modeli tercih edilmektedir.", "Körük Tente", 1m, "koruk-tente" },
                    { 3, 2, "Stor tente normal mafsallı tentenin kolsuz modelidir.karşıdan gelen güneş için tercih edilen bir modeldir. Stor tente Yukardan aşağı açılıp kapanan bir modeldir istenildiği taktirde motorlu sistemde uyumludur.stor tente asıl amacı, gölgelendirme işlevini yapmak olsa da fonksiyonellik yönünden de hiçbir şekilde sınır tanımamaktadır.", "Stor Tente", 1500m, "stor-tente" },
                    { 4, 2, "Çift açılır tente kurulumu ve kullanımı kolay tente modellerinden sadece biridir.\r\n\r\nBu tente sayesinde hem daha sağlıklı bir hava ortamına sahip olursunuz hemde iş yerleriniz daha güzel bire görünüme kavuşmaktadır. taksitli fiyatları akrilik kumaşlı ısı geçirmeyen garanti belgeli kaliteli", "Çift Açılır Tente", 5000m, "cift-acılır-tente" },
                    { 5, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Mafsallı Tente", 30000m, "mafsalli-tente" },
                    { 6, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Giyotin Cam", 30000m, "giyotin-cam" },
                    { 7, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Fotoselli Giyotin Cam Kapı", 30000m, "fotoselli-giyotin-cam-kapi" },
                    { 8, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Şeffaf Kış Bahçesi", 30000m, "seffaf-kıs-bahcesi" },
                    { 9, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Şeffaf Alan Kapama", 30000m, "seffaf-alan-kapama" },
                    { 10, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Şeffaf Pvc Mika Branda", 30000m, "seffaf-pvc-mika-branda" },
                    { 11, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Havuz Brandası", 30000m, "havuz-brandasi" },
                    { 12, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "İskele Brandası", 30000m, "iskele-brandasi" },
                    { 13, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Kamelya Branda", 30000m, "kamelya-branda" },
                    { 14, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Pazar Brandası", 30000m, "pazar-brandasi" },
                    { 15, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Reklam Brandası", 30000m, "reklam-brandasi" },
                    { 16, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Araç Koruma Brandası", 30000m, "arac-koruma-brandasi" },
                    { 17, 3, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Yat ve Tekne Brandası", 30000m, "yat-tekne-brandasi" },
                    { 18, 4, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Cam Balkon", 30000m, "cam-balkon" },
                    { 19, 4, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Cam Veranda", 30000m, "cam-veranda" },
                    { 20, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Depo Çadırı", 30000m, "depo-cadiri" },
                    { 21, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Doğal Afet Çadırı", 30000m, "dogal-afet-cadiri" },
                    { 22, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Halı Saha Çadırı", 30000m, "hali -saha-cadiri" },
                    { 23, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Hayvan Besi Çadırı", 30000m, "hayvan-besi-cadiri" },
                    { 24, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Spor Kompleksi Çadırı", 30000m, "spor-kompleksi-cadiri" },
                    { 25, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Şantiye Çadırı", 30000m, "santiye-cadiri" },
                    { 26, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Kiralık Çadır", 30000m, "kiralik-cadir" },
                    { 27, 5, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Konser Tören Çadırı", 30000m, "konser-toren-cadiri" },
                    { 28, 6, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Sürgülü Sineklik", 30000m, "surgulu-sineklik" },
                    { 29, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Motorlu Giyotin Cam", 30000m, "motorlu-giyotin-cam" },
                    { 30, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Üstte Toplanır Giyotin Cam", 30000m, "ustte-toplanır-giyotin-cam" },
                    { 31, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Silinebilir Giyotin Cam", 30000m, "silinebilir-giyotin-cam" },
                    { 32, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Isı Camlı Giyotin", 30000m, "isi-camli-giyotin" },
                    { 33, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Tek Camlı Giyotin", 30000m, "tek-camli-giyotin" },
                    { 34, 1, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Kumandalı Giyotin Cam", 30000m, "kumandali-giyotin-cam" },
                    { 35, 4, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Katlanır Cam Balkon", 30000m, "katlanir-cam-balkon" },
                    { 36, 4, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Açılır Cam Tavan Sistemleri", 30000m, "acilir-cam-tavan-sistemleri" },
                    { 37, 4, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Cam Çatı Sistemleri", 30000m, "cam-cati-sistemleri" },
                    { 38, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Motorlu Tente", 30000m, "motorlu-tente" },
                    { 39, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Sabit Tente", 30000m, "sabit-tente" },
                    { 40, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Kumandalı Tente", 30000m, "kumandali-tente" },
                    { 41, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Rolling Roof Tente", 30000m, "rolling-roof-tente " },
                    { 42, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Bio Klimatik Tente", 30000m, "bio-klimatik-tente" }
                });

            migrationBuilder.InsertData(
                table: "ServiceImages",
                columns: new[] { "Id", "MediaId", "ServiceId" },
                values: new object[] { 1, 3, 1 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name", "ParentId", "Slug" },
                values: new object[,]
                {
                    { 3, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Blackout Pergola Tente Kumaşı", 2, "blackout-pergola-tente-kumasi" },
                    { 4, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Pergola Tente Teknik Özellikleri", 2, "pergola-tente-teknik-ozellikleri" },
                    { 5, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Pergola Tente İmalatı Çeşitleri", 2, "pergola-tente-imalati-cesitleri" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, true, 1, 1 },
                    { 2, 2, false, 2, 1 },
                    { 3, 3, true, 4, 2 },
                    { 4, 3, false, 5, 2 },
                    { 5, 3, false, 6, 2 },
                    { 6, 3, false, 7, 2 },
                    { 7, 3, false, 8, 2 },
                    { 8, 3, false, 9, 1 },
                    { 9, 3, false, 10, 1 },
                    { 10, 3, false, 11, 1 },
                    { 11, 3, false, 12, 1 },
                    { 12, 3, true, 13, 3 },
                    { 13, 3, false, 14, 3 },
                    { 14, 3, false, 15, 3 },
                    { 15, 3, false, 16, 3 },
                    { 16, 3, true, 17, 4 },
                    { 17, 3, false, 18, 4 },
                    { 18, 3, false, 19, 4 },
                    { 19, 3, false, 20, 4 },
                    { 20, 3, true, 21, 5 },
                    { 21, 3, false, 22, 5 },
                    { 22, 3, false, 23, 5 },
                    { 23, 3, false, 24, 5 },
                    { 24, 3, true, 25, 6 },
                    { 25, 3, false, 26, 6 },
                    { 26, 3, false, 27, 6 },
                    { 27, 3, false, 28, 6 },
                    { 28, 3, true, 29, 7 },
                    { 29, 3, false, 30, 7 },
                    { 30, 3, false, 31, 7 },
                    { 31, 3, false, 32, 7 },
                    { 32, 3, true, 33, 8 },
                    { 33, 3, false, 34, 8 },
                    { 34, 3, false, 35, 8 },
                    { 35, 3, false, 36, 8 },
                    { 36, 3, true, 37, 9 },
                    { 37, 3, false, 38, 9 },
                    { 38, 3, false, 39, 9 },
                    { 39, 3, false, 40, 9 },
                    { 40, 3, true, 41, 10 },
                    { 41, 3, false, 42, 10 },
                    { 42, 3, false, 43, 10 },
                    { 43, 3, false, 44, 10 },
                    { 44, 3, true, 45, 11 },
                    { 45, 3, false, 46, 11 },
                    { 46, 3, false, 47, 11 },
                    { 47, 3, false, 48, 11 },
                    { 48, 3, true, 49, 12 },
                    { 49, 3, false, 50, 12 },
                    { 50, 3, false, 51, 12 },
                    { 51, 3, false, 52, 12 },
                    { 52, 3, true, 53, 13 },
                    { 53, 3, false, 54, 13 },
                    { 54, 3, false, 55, 13 },
                    { 55, 3, false, 56, 13 },
                    { 56, 3, true, 57, 14 },
                    { 57, 3, false, 58, 14 },
                    { 58, 3, false, 59, 14 },
                    { 59, 3, true, 60, 15 },
                    { 60, 3, false, 61, 15 },
                    { 61, 3, false, 62, 15 },
                    { 62, 3, false, 63, 15 },
                    { 63, 3, true, 64, 16 },
                    { 64, 3, false, 65, 16 },
                    { 65, 3, false, 66, 16 },
                    { 66, 3, true, 67, 17 },
                    { 67, 3, false, 68, 17 },
                    { 68, 3, false, 69, 17 },
                    { 69, 3, true, 70, 18 },
                    { 70, 3, false, 71, 18 },
                    { 71, 3, false, 72, 18 },
                    { 72, 3, false, 73, 18 },
                    { 73, 3, false, 74, 18 },
                    { 74, 3, false, 75, 18 },
                    { 75, 3, true, 76, 19 },
                    { 76, 3, false, 77, 19 },
                    { 77, 3, false, 78, 19 },
                    { 78, 3, false, 79, 19 },
                    { 79, 3, true, 80, 20 },
                    { 80, 3, false, 81, 20 },
                    { 81, 3, false, 82, 20 },
                    { 82, 3, false, 83, 20 },
                    { 83, 3, true, 84, 21 },
                    { 84, 3, false, 85, 21 },
                    { 85, 3, false, 86, 21 },
                    { 86, 3, true, 87, 22 },
                    { 87, 3, false, 88, 22 },
                    { 88, 3, false, 89, 22 },
                    { 89, 3, true, 90, 23 },
                    { 90, 3, false, 91, 23 },
                    { 91, 3, false, 92, 23 },
                    { 92, 3, true, 93, 24 },
                    { 93, 3, false, 94, 24 },
                    { 94, 3, false, 95, 24 },
                    { 95, 3, true, 96, 25 },
                    { 96, 3, false, 97, 25 },
                    { 97, 3, false, 98, 25 },
                    { 98, 3, true, 99, 26 },
                    { 99, 3, false, 100, 26 },
                    { 100, 3, false, 101, 26 },
                    { 101, 3, true, 102, 27 },
                    { 102, 3, false, 103, 27 },
                    { 103, 3, false, 104, 27 },
                    { 104, 3, true, 105, 28 },
                    { 105, 3, false, 106, 28 },
                    { 106, 3, false, 107, 28 },
                    { 107, 3, false, 108, 28 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_MediaId",
                table: "ProductImages",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceImages_MediaId",
                table: "ServiceImages",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceImages_ServiceId",
                table: "ServiceImages",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ParentId",
                table: "Services",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ServiceImages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
