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
                    { 108, "surgulu-sineklik-4", "image/jpeg", "surgulu-sineklik-4.jpg", "/assets/img/properties/surgulu-sineklik-4.jpg" },
                    { 109, "motorlu-giyotin-cam-1", "image/jpeg", "motorlu-giyotin-cam-1.jpg", "/assets/img/properties/motorlu-giyotin-cam-1.jpg" },
                    { 110, "motorlu-giyotin-cam-2", "image/jpeg", "motorlu-giyotin-cam-2.jpg", "/assets/img/properties/motorlu-giyotin-cam-2.jpg" },
                    { 111, "motorlu-giyotin-cam-3", "image/jpeg", "motorlu-giyotin-cam-3.jpg", "/assets/img/properties/motorlu-giyotin-cam-3.jpg" },
                    { 112, "motorlu-giyotin-cam-4", "image/jpeg", "motorlu-giyotin-cam-4.jpg", "/assets/img/properties/motorlu-giyotin-cam-4.jpg" },
                    { 113, "ustte-toplanır-giyotin-cam-1", "image/jpeg", "ustte-toplanır-giyotin-cam-1.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-1.jpg" },
                    { 114, "ustte-toplanır-giyotin-cam-2", "image/jpeg", "ustte-toplanır-giyotin-cam-2.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-2.jpg" },
                    { 115, "ustte-toplanır-giyotin-cam-3", "image/jpeg", "ustte-toplanır-giyotin-cam-3.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-3.jpg" },
                    { 116, "ustte-toplanır-giyotin-cam-4", "image/jpeg", "ustte-toplanır-giyotin-cam-4.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-4.jpg" },
                    { 117, "silinebilir-giyotin-cam-1", "image/jpeg", "silinebilir-giyotin-cam-1.jpg", "/assets/img/properties/silinebilir-giyotin-cam-1.jpg" },
                    { 118, "silinebilir-giyotin-cam-2", "image/jpeg", "silinebilir-giyotin-cam-2.jpg", "/assets/img/properties/silinebilir-giyotin-cam-2.jpg" },
                    { 119, "silinebilir-giyotin-cam-3", "image/jpeg", "silinebilir-giyotin-cam-3.jpg", "/assets/img/properties/silinebilir-giyotin-cam-3.jpg" },
                    { 120, "silinebilir-giyotin-cam-4", "image/jpeg", "silinebilir-giyotin-cam-4.jpg", "/assets/img/properties/silinebilir-giyotin-cam-4.jpg" },
                    { 121, "isi-camli-giyotin-1", "image/jpeg", "isi-camli-giyotin-1.jpg", "/assets/img/properties/isi-camli-giyotin-1.jpg" },
                    { 122, "isi-camli-giyotin-2", "image/jpeg", "isi-camli-giyotin-2.jpg", "/assets/img/properties/isi-camli-giyotin-2.jpg" },
                    { 123, "isi-camli-giyotin-3", "image/jpeg", "isi-camli-giyotin-3.jpg", "/assets/img/properties/isi-camli-giyotin-3.jpg" },
                    { 124, "isi-camli-giyotin-4", "image/jpeg", "isi-camli-giyotin-4.jpg", "/assets/img/properties/isi-camli-giyotin-4.jpg" },
                    { 125, "tek-camli-giyotin-1", "image/jpeg", "tek-camli-giyotin-1.jpg", "/assets/img/properties/tek-camli-giyotin-1.jpg" },
                    { 126, "tek-camli-giyotin-2", "image/jpeg", "tek-camli-giyotin-2.jpg", "/assets/img/properties/tek-camli-giyotin-2.jpg" },
                    { 127, "tek-camli-giyotin-3", "image/jpeg", "tek-camli-giyotin-3.jpg", "/assets/img/properties/tek-camli-giyotin-3.jpg" },
                    { 128, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 129, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 130, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 131, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 132, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 133, "katlanir-cam-balkon-1", "image/jpeg", "katlanir-cam-balkon-1.jpg", "/assets/img/properties/katlanir-cam-balkon-1.jpg" },
                    { 134, "katlanir-cam-balkon-2", "image/jpeg", "katlanir-cam-balkon-2.jpg", "/assets/img/properties/katlanir-cam-balkon-2.jpg" },
                    { 135, "katlanir-cam-balkon-3", "image/jpeg", "katlanir-cam-balkon-3.jpg", "/assets/img/properties/katlanir-cam-balkon-3.jpg" },
                    { 136, "katlanir-cam-balkon-4", "image/jpeg", "katlanir-cam-balkon-4.jpg", "/assets/img/properties/katlanir-cam-balkon-4.jpg" },
                    { 137, "acilir-cam-tavan-sistemleri-1", "image/jpeg", "acilir-cam-tavan-sistemleri-1.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-1.jpg" },
                    { 138, "acilir-cam-tavan-sistemleri-2", "image/jpeg", "acilir-cam-tavan-sistemleri-2.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-2.jpg" },
                    { 139, "acilir-cam-tavan-sistemleri-3", "image/jpeg", "acilir-cam-tavan-sistemleri-3.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-3.jpg" },
                    { 140, "acilir-cam-tavan-sistemleri-4", "image/jpeg", "acilir-cam-tavan-sistemleri-4.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-4.jpg" },
                    { 141, "cam-cati-sistemleri-1", "image/jpeg", "cam-cati-sistemleri-1.jpg", "/assets/img/properties/cam-cati-sistemleri-1.jpg" },
                    { 142, "cam-cati-sistemleri-2", "image/jpeg", "cam-cati-sistemleri-2.jpg", "/assets/img/properties/cam-cati-sistemleri-2.jpg" },
                    { 143, "cam-cati-sistemleri-3", "image/jpeg", "cam-cati-sistemleri-3.jpg", "/assets/img/properties/cam-cati-sistemleri-3.jpg" },
                    { 144, "cam-cati-sistemleri-4", "image/jpeg", "cam-cati-sistemleri-4.jpg", "/assets/img/properties/cam-cati-sistemleri-4.jpg" },
                    { 145, "motorlu-tente-1", "image/jpeg", "motorlu-tente-1.jpg", "/assets/img/properties/motorlu-tente-1.jpg" },
                    { 146, "motorlu-tente-2", "image/jpeg", "motorlu-tente-2.jpg", "/assets/img/properties/motorlu-tente-2.jpg" },
                    { 147, "motorlu-tente-3", "image/jpeg", "motorlu-tente-3.jpg", "/assets/img/properties/motorlu-tente-3.jpg" },
                    { 148, "motorlu-tente-4", "image/jpeg", "motorlu-tente-4.jpg", "/assets/img/properties/motorlu-tente-4.jpg" },
                    { 149, "sabit-tente-1", "image/jpeg", "sabit-tente-1.jpg", "/assets/img/properties/sabit-tente-1.jpg" },
                    { 150, "sabit-tente-2", "image/jpeg", "sabit-tente-2.jpg", "/assets/img/properties/sabit-tente-2.jpg" },
                    { 151, "sabit-tente-3", "image/jpeg", "sabit-tente-3.jpg", "/assets/img/properties/sabit-tente-3.jpg" },
                    { 152, "sabit-tente-4", "image/jpeg", "sabit-tente-4.jpg", "/assets/img/properties/sabit-tente-4.jpg" },
                    { 153, "kumandali-tente-1", "image/jpeg", "kumandali-tente-1.jpg", "/assets/img/properties/kumandali-tente-1.jpg" },
                    { 154, "kumandali-tente-2", "image/jpeg", "kumandali-tente-2.jpg", "/assets/img/properties/kumandali-tente-2.jpg" },
                    { 155, "kumandali-tente-3", "image/jpeg", "kumandali-tente-3.jpg", "/assets/img/properties/kumandali-tente-3.jpg" },
                    { 156, "kumandali-tente-4", "image/jpeg", "kumandali-tente-4.jpg", "/assets/img/properties/kumandali-tente-4.jpg" },
                    { 157, "rolling-roof-tente-1", "image/jpeg", "rolling-roof-tente-1.jpg", "/assets/img/properties/rolling-roof-tente-1.jpg" },
                    { 158, "rolling-roof-tente-2", "image/jpeg", "rolling-roof-tente-2.jpg", "/assets/img/properties/rolling-roof-tente-2.jpg" },
                    { 159, "rolling-roof-tente-3", "image/jpeg", "rolling-roof-tente-3.jpg", "/assets/img/properties/rolling-roof-tente-3.jpg" },
                    { 160, "rolling-roof-tente-4", "image/jpeg", "rolling-roof-tente-4.jpg", "/assets/img/properties/rolling-roof-tente-4.jpg" },
                    { 161, "bio-klimatik-tente-1", "image/jpeg", "bio-klimatik-tente-1.jpg", "/assets/img/properties/bio-klimatik-tente-1.jpg" },
                    { 162, "bio-klimatik-tente-2", "image/jpeg", "bio-klimatik-tente-2.jpg", "/assets/img/properties/bio-klimatik-tente-2.jpg" },
                    { 163, "bio-klimatik-tente-3", "image/jpeg", "bio-klimatik-tente-3.jpg", "/assets/img/properties/bio-klimatik-tente-3.jpg" },
                    { 164, "bio-klimatik-tente-4", "image/jpeg", "bio-klimatik-tente-4.jpg", "/assets/img/properties/bio-klimatik-tente-4.jpg" },
                    { 165, "Pergola-Tente-Teknik-Ozellikleri", "image/jpeg", "Pergola-Tente-Teknik-Ozellikleri.jpg", "/assets/img/service/teknikozellik/Pergola-Tente-Teknik-Ozellikleri.jpg" },
                    { 166, "blackout-pergola-tente-kumaşı-1", "image/jpeg", "blackout-pergola-tente-kumaşı-1.jpg", "/assets/img/service/blackout/blackout-pergola-tente-kumaşı-1.jpg" },
                    { 167, "blackout-pergola-tente-kumaşı-2", "image/jpeg", "blackout-pergola-tente-kumaşı-2.jpg", "/assets/img/service/blackout/blackout-pergola-tente-kumaşı-2.jpg" },
                    { 168, "blackout-pergola-tente-kumaşı-3", "image/jpeg", "blackout-pergola-tente-kumaşı-3.jpg", "/assets/img/service/blackout/blackout-pergola-tente-kumaşı-3.jpg" },
                    { 169, "pergolateknik-1", "image/jpeg", "pergolateknik-1.jpg", "/assets/img/service/pergolateknik/pergolateknik-1.jpg" },
                    { 170, "pergolateknik-2", "image/jpeg", "pergolateknik-2.jpg", "/assets/img/service/pergolateknik/pergolateknik-2.jpg" },
                    { 171, "pergolateknik-3", "image/jpeg", "pergolateknik-3.jpg", "/assets/img/service/pergolateknik/pergolateknik-3.jpg" },
                    { 172, "tente-imalatı-1", "image/jpeg", "tente-imalatı-1.jpg", "/assets/img/service/tenteimalati/tente-imalatı-1.jpg" },
                    { 173, "tente-imalatı-2", "image/jpeg", "tente-imalatı-2.jpg", "/assets/img/service/tenteimalati/tente-imalatı-2.jpg" },
                    { 174, "tente-imalatı-3", "image/jpeg", "tente-imalatı-3.jpg", "/assets/img/service/tenteimalati/tente-imalatı-3.jpg" },
                    { 175, "kullanim-ozellikleri-1", "image/jpeg", "kullanim-ozellikleri-1.jpg", "/assets/img/service/kullanim-ozellikleri/kullanim-ozellikleri-1.jpg" },
                    { 176, "kullanim-ozellikleri-2", "image/jpeg", "kullanim-ozellikleri-2.jpg", "/assets/img/service/kullanim-ozellikleri/kullanim-ozellikleri-2.jpg" },
                    { 177, "kullanim-ozellikleri-3", "image/jpeg", "kullanim-ozellikleri-3.jpg", "/assets/img/service/kullanim-ozellikleri/kullanim-ozellikleri-3.jpg" },
                    { 178, "projeler-1", "image/jpeg", "projeler-1.jpg", "/assets/img/service/projeler/projeler-1.jpg" },
                    { 179, "projeler-2", "image/jpeg", "projeler-2.jpg", "/assets/img/service/projeler/projeler-2.jpg" },
                    { 180, "projeler-3", "image/jpeg", "projeler-3.jpg", "/assets/img/service/projeler/projeler-3.jpg" },
                    { 181, "faydali-bilgiler-1", "image/jpeg", "faydali-bilgiler-1.jpg", "/assets/img/service/faydali-bilgiler/faydali-bilgiler-1.jpg" },
                    { 182, "faydali-bilgiler-2", "image/jpeg", "faydali-bilgiler-2.jpg", "/assets/img/service/faydali-bilgiler/faydali-bilgiler-2.jpg" },
                    { 183, "faydali-bilgiler-3", "image/jpeg", "faydali-bilgiler-3.jpg", "/assets/img/service/faydali-bilgiler/faydali-bilgiler-3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name", "ParentId", "Slug" },
                values: new object[,]
                {
                    { 1, "Firmamız satış dışında Teknik Servisleri montaj hizmeti de vermektedir. Ayrıca kurulmuş olan yapıları yeni yerinize en uygun şekilde uyarlayarak kurulum hizmetini de sunmaktayız.", "Teknik Servis", null, "teknik-servis" },
                    { 2, "Yüksek mukametli alimunyum alışımlı yapılmış elektros statik toz boya ile boyalı iskelet\r\nHer türlü hava koşuluna dayanıklı su geçirmeme özelliğine sahip Pvc bloklardan oluşan yüzey Malzemesi 850 gram alev yürütmeme özelliğine sahip blockout branda\r\n120 x 80 mm ölçülerinde taşıyıcılar 150 x 70 mm ray Sistemleri Uzaktan kumandalı Alman Becker motor desteği Gergi için özel olarak üretilmiş Alman Triger kayış sistemi İtalyan rulman makara sistemi özel estetik görünümlü alimunyum yağmur ve dere inişleri ile su taşıyıcı giderleri Ürünlerimiz 5 yıl garantili", "Teknik Özellikler", null, "teknik-ozellikler" },
                    { 6, "TekSan Tente sistemleri, her mevsimde konforlu ve estetik yaşam alanları sunmak için tasarlanmıştır. Yüksek kalite standartlarında üretilen tente sistemlerimiz, dış mekanlarınızı hem koruyucu hem de dekoratif bir alana dönüştürür.Dayanıklı Malzeme Yapısı: Alüminyum, galvanizli çelik ve paslanmaz bağlantı elemanlarıyla uzun ömürlü kullanım sağlar.\r\n\r\nSu ve Güneş Direnci: UV korumalı, su geçirmez ithal kumaşlar sayesinde güneş ışınlarına ve yağmura karşı tam koruma sunar.\r\n\r\nMotorlu ve Manuel Seçenekler: Uzaktan kumandalı veya manuel açma-kapama sistemleriyle kolay kullanım imkânı.\r\n\r\nEstetik Tasarım: Modern çizgilere sahip, her mekâna uyum sağlayan farklı renk ve model seçenekleriyle üretim yapılır.\r\n\r\nRüzgâr Dayanımı: Yüksek rüzgâr dayanımı için güçlendirilmiş taşıyıcı profiller ve kaliteli bağlantı sistemleri kullanılır.\r\n\r\nBakım Kolaylığı: Kolay temizlenebilir kumaş ve modüler sistem yapısı sayesinde uzun süre sorunsuz kullanım.\r\n\r\nOpsiyonel Donanımlar: LED aydınlatma, ısıtıcı, sensör sistemleri ve otomatik kontrol panelleriyle akıllı kullanım deneyimi.", "Kullanım Özellikleri", null, "kullanim-ozellikleri" },
                    { 7, "Yapı ruhsatı gerektirmeden uygulanabilen tamamı otomatik açılır &\r\nkapanır şekilde tasarlanan, ergonomik ve fonksiyonel bir tente sistemidir. Pergola Tente\r\n\r\nGeçmişten günümüze yapmış olduğumuz projelerimizi sosyal medya hesaplarımızdan ve sitemizden paylaşmaktayız.. Her daim müşteri desteği sağlıyoruz ve ayrıca müşterilerimiz için çok yüksek düzeyde bir memnuniyet garantisi veriyoruz. Bir sorunuz varsa daha fazla ayrıntı için  numarasından bizimle iletişim kurmaktan çekinmeyin.\r\n\r\nArtık mekânlarınız, olması gerektiği gibi, kullanışlı ve keyifli. Sosyal alan veya evsel lüks ve konforunu arttırabilirsiniz. Pergola tentelerimiz küçük ve büyük alanlar, bağlantısız veya duvara monte edilmiş şekilde tasarlanmışlardır ve çeşitli yenilikçi alüminyum tasarımlarında mevcutturlar. Pergola Tente Yetkili Servis ", "Projeler", null, "projeler" },
                    { 8, "Pergola Tente Faydalı Bilgiler, deri, Pvc, dokuma bezi vb. Malzemeden yapılarak tutturulan, taşınabilir barınak. Modern tipteki çadırlar bir hayli lüks olabilmekle birlikte çoğu durumda en ucuz konaklama biçimi. Genellikle güneşten korunmak için bir yerin üzerine gerilen bez, naylon vb.nden yapılmış örtü.\r\n\r\n", "Faydalı Bilgiler", null, "faydali-bilgiler" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Comment", "Name", "Price", "Slug" },
                values: new object[,]
                {
                    { 1, 2, "Pergole Tenteler Ticari alanlarda veya konutlarda kullanılan pergole tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergole tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar. Bu sistemler teknolojik gelişmelerle birlikte güncellenip motor ve sensör desteğiyle daha kullanışlı hale gelmiştir. İşyeriniz veya eviniz için ihtiyacınız olan tüm pergola tenteleri firmamızdan uygun fiyatlarla tedarik edebilirsiniz. ", "Pergole Tente", null, "pergole-tente" },
                    { 2, 2, "Körüklü tentelerin kurulumu ve kullanıma kolay tente modellerinden sadece biridir. Tente Sistemi Akordeon Şeklinde Açılıp Kapanmaktadır Diğer Tentelerde Farkı yan kısımlar Kapalı olduğundan Güneş ve Yağmur gelmesini Engeller  kullanıldığı alanlarda şık Dizaynı ve Tasarımıyla bulunduğu alana ayrı bir Görsellik katar.\r\n\r\nKörüklü Sisteminin Saçak Modeli Deniz dalgası modeli veya Düz saçak modeli tercih edilmektedir.", "Körük Tente", null, "koruk-tente" },
                    { 3, 2, "Stor tente normal mafsallı tentenin kolsuz modelidir.karşıdan gelen güneş için tercih edilen bir modeldir. Stor tente Yukardan aşağı açılıp kapanan bir modeldir istenildiği taktirde motorlu sistemde uyumludur.stor tente asıl amacı, gölgelendirme işlevini yapmak olsa da fonksiyonellik yönünden de hiçbir şekilde sınır tanımamaktadır.", "Stor Tente", null, "stor-tente" },
                    { 4, 2, "Çift açılır tente kurulumu ve kullanımı kolay tente modellerinden sadece biridir.\r\n\r\nBu tente sayesinde hem daha sağlıklı bir hava ortamına sahip olursunuz hemde iş yerleriniz daha güzel bire görünüme kavuşmaktadır. taksitli fiyatları akrilik kumaşlı ısı geçirmeyen garanti belgeli kaliteli", "Çift Açılır Tente", null, "cift-acılır-tente" },
                    { 5, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Mafsallı Tente", null, "mafsalli-tente" },
                    { 6, 1, "Giyotin cam sistemleri, özellikle teras, balkon, kış bahçesi ve geniş cephe uygulamalarında şık, kullanışlı ve modern bir çözümdür. Üstten ya da alttan raylar üzerinde dikey olarak kayan cam paneller sayesinde açıklık tamamen açılabilir ya da istenirse tamamen kapanabilir.Cam panellerin pürüzsüz kayışıyla yüksek manevra kabiliyeti sunar.Isı, ses ve rüzgâr yalıtımında etkili çözümler sağlar.Minimal profil tasarımıyla görüş alanını geniş tutar, mekâna ferahlık katar.Üstten kilit mekanizmaları ve güvenlik cam seçenekleriyle güvenli kullanım sunar.Farklı açılı uygulamalara (örneğin çatı çıkıntıları veya yüksek cepheler) adaptasyon imkânı verir.Giyotin cam sistemleri, hem estetik hem teknik açıdan yükselen bir tercih olarak dış mekânların yaşam alanına dönüşmesine katkı sağlar.", "Giyotin Cam", null, "giyotin-cam" },
                    { 7, 1, "Fotoselli giyotin cam kapı sistemleri, modern mimarinin şık görünümünü ileri düzey teknolojiyle birleştiren otomatik kapı çözümleridir. Dikey hareketli cam paneller, sensör (fotosel) yardımıyla kişi veya araç algılandığında otomatik olarak açılıp kapanır. Bu sayede hem kullanım kolaylığı hem de enerji verimliliği sağlar.", "Fotoselli Giyotin Cam Kapı", null, "fotoselli-giyotin-cam-kapi" },
                    { 8, 3, "Şeffaf kış bahçesi brandası, açık alanları dört mevsim kullanılabilir hale getiren en pratik ve ekonomik çözümlerden biridir. Soğuk, rüzgâr, yağmur ve kar gibi dış etkenlerden korunmak için tasarlanan bu sistem, mekanın doğal ışığını kesmeden mükemmel bir koruma sağlar.", "Şeffaf Kış Bahçesi", null, "seffaf-kıs-bahcesi" },
                    { 9, 3, "Şeffaf alan kapama sistemleri, açık alanları dış etkenlerden koruyarak dört mevsim kullanılabilir hale getiren modern çözümlerdir. Yüksek kaliteli şeffaf PVC malzemeden üretilen bu brandalar, hem dayanıklı hem de estetik bir kullanım sunar. Mekânın doğal ışığını engellemeden koruma sağlar; böylece iç mekânlar ferahlığını kaybetmeden dış ortam koşullarına karşı korunur.", "Şeffaf Alan Kapama", null, "seffaf-alan-kapama" },
                    { 10, 3, "Şeffaf PVC Mika branda, dış mekânları her mevsim konforlu ve kullanışlı hale getiren modern koruma sistemlerinden biridir. Tam şeffaf yapısı sayesinde dış ortamla görsel bağlantıyı kesmeden, yağmur, rüzgâr, toz ve soğuk gibi olumsuz hava koşullarına karşı mükemmel koruma sağlar.", "Şeffaf Pvc Mika Branda", null, "seffaf-pvc-mika-branda" },
                    { 11, 3, "Havuz brandası, yüzme havuzlarını dış etkenlerden korumak, güvenliği artırmak ve temizlik maliyetlerini düşürmek için geliştirilen dayanıklı bir kaplama sistemidir. Mevsimsel kullanıma uygun olan bu brandalar, hem açık hem de kapalı havuzlarda estetik ve fonksiyonel bir çözüm sunar.", "Havuz Brandası", null, "havuz-brandasi" },
                    { 12, 3, "İskele brandası, inşaat ve tadilat alanlarında güvenliği sağlamak, çevreyi korumak ve estetik bir görünüm oluşturmak amacıyla kullanılan özel bir koruma sistemidir. Dayanıklı PVC veya polietilen (PE) malzemeden üretilen iskele brandaları, hem çalışanların hem de çevredeki insanların güvenliğini artırırken, yapı alanını dış etkenlerden korur.", "İskele Brandası", null, "iskele-brandasi" },
                    { 13, 3, "Kamelya brandası, açık alanlarda bulunan kamelya, çardak ve oturma alanlarını dört mevsim koruma altına almak için tasarlanmış şık ve dayanıklı bir kaplama sistemidir. Estetik görünümü, uzun ömürlü malzemesi ve hava koşullarına karşı yüksek direnci sayesinde konforlu bir dış mekân deneyimi sunar.", "Kamelya Branda", null, "kamelya-branda" },
                    { 14, 3, "Pazar brandası, açık alanlarda kurulan pazar yerleri, tezgâhlar ve satış alanlarını güneş, yağmur, rüzgâr gibi dış etkenlerden korumak için özel olarak üretilen dayanıklı kaplama sistemidir. Hafif yapısı, kolay kurulumu ve uzun ömürlü malzemesi sayesinde esnaflar ve organizasyon alanları için pratik bir çözümdür.", "Pazar Brandası", null, "pazar-brandasi" },
                    { 15, 3, "Reklam brandası, markanı veya işletmeni geniş kitlelere tanıtmak için kullanılan en etkili ve ekonomik açık hava reklam çözümlerinden biridir. Dayanıklı branda kumaşı üzerine yüksek çözünürlüklü dijital baskı uygulanarak üretilen bu sistemler, hem iç hem de dış mekânlarda uzun süreli görünürlük sağlar.", "Reklam Brandası", null, "reklam-brandasi" },
                    { 16, 3, "Araç koruma brandası, otomobilleri güneş, yağmur, dolu, kar, kuş pisliği, toz ve ağaç reçinesi gibi dış etkenlerden korumak için özel olarak tasarlanmış pratik bir örtü sistemidir. Dayanıklı, su geçirmez ve UV ışınlarına karşı dirençli yapısı sayesinde aracınızın dış yüzeyini her mevsim güvenle korur.", "Araç Koruma Brandası", null, "arac-koruma-brandasi" },
                    { 17, 3, "Yat ve tekne brandası, deniz taşıtlarını güneş, tuzlu su, yağmur, rüzgâr ve kuş pisliği gibi dış etkenlerden korumak için özel olarak tasarlanmış dayanıklı bir koruma sistemidir. Su geçirmez, UV dayanımlı ve uzun ömürlü kumaş yapısı sayesinde teknenizi yıl boyunca güvenle muhafaza eder.", "Yat ve Tekne Brandası", null, "yat-tekne-brandasi" },
                    { 18, 4, "Cam balkon sistemleri, balkonları dört mevsim kullanılabilir hale getiren, modern, estetik ve fonksiyonel bir kaplama çözümüdür. Isı, ses ve rüzgâr yalıtımı sağlayan bu sistemler, mekânın mimarisine değer katarken yaşam alanlarına da konfor kazandırır.", "Cam Balkon", null, "cam-balkon" },
                    { 19, 4, "Cam veranda sistemleri, açık alanları modern, estetik ve korunaklı yaşam alanlarına dönüştüren şık mimari çözümlerden biridir. Dört mevsim kullanılabilen yapısıyla verandanı hem yağmurdan hem rüzgârdan korur; aynı zamanda ferah, aydınlık ve konforlu bir ortam oluşturur.", "Cam Veranda", null, "cam-veranda" },
                    { 20, 5, "Depo çadırı, sanayi, tarım ve lojistik sektörlerinde malzeme, ürün ve ekipmanların güvenli bir şekilde korunması için tasarlanmış, dayanıklı ve ekonomik bir kapalı alan çözümüdür. Hızlı kurulumu, taşınabilir yapısı ve uzun ömürlü malzemesi sayesinde kalıcı binalara alternatif olarak sıkça tercih edilir.", "Depo Çadırı", null, "depo-cadiri" },
                    { 21, 5, "Doğal afet çadırı, deprem, sel, yangın, fırtına veya diğer acil durumlarda barınma ihtiyacını hızlı bir şekilde karşılamak üzere tasarlanmış, dayanıklı ve pratik kurulumlu geçici yaşam alanıdır. Zorlu hava koşullarına dayanıklı yapısı ve kolay taşınabilirliği sayesinde, afet bölgelerinde en güvenilir barınma çözümlerinden biridir.", "Doğal Afet Çadırı", null, "dogal-afet-cadiri" },
                    { 22, 5, "Halı saha çadırı, açık veya kapalı spor alanlarını dört mevsim kullanılabilir hale getiren, dayanıklı ve estetik bir kaplama sistemidir. Spor tesisleri için özel olarak tasarlanan bu yapılar; hava koşullarına karşı tam koruma sağlarken, aynı zamanda modern ve ferah bir oyun ortamı sunar.", "Halı Saha Çadırı", null, "hali -saha-cadiri" },
                    { 23, 5, "Hayvan besi çadırı, büyükbaş ve küçükbaş hayvanların barınma, beslenme ve üretim süreçlerinde kullanılan, dayanıklı ve ekonomik bir barınak çözümüdür. Hızlı kurulumu, geniş iç hacmi ve uzun ömürlü yapısıyla modern hayvancılık işletmeleri için ideal bir seçenektir.", "Hayvan Besi Çadırı", null, "hayvan-besi-cadiri" },
                    { 24, 5, "Spor kompleksi çadırı, kapalı veya yarı kapalı spor alanlarını dört mevsim kullanılabilir hale getiren modern, dayanıklı ve ekonomik çözümlerden biridir. Hızlı kurulumu, uzun ömürlü yapısı ve estetik tasarımı sayesinde farklı spor dallarına uygun, geniş ve ferah bir oyun alanı oluşturur.", "Spor Kompleksi Çadırı", null, "spor-kompleksi-cadiri" },
                    { 25, 5, "Şantiye çadırı, inşaat ve saha çalışmalarında personel, malzeme ve ekipmanların korunması için kullanılan pratik, dayanıklı ve ekonomik barınma çözümlerinden biridir. Hızlı kurulumu, taşınabilir yapısı ve uzun ömürlü malzemesi sayesinde her türlü zemin ve iklim koşulunda güvenli kullanım sağlar.", "Şantiye Çadırı", null, "santiye-cadiri" },
                    { 26, 5, "Kiralık çadır sistemleri, kısa süreli organizasyon, etkinlik, fuar, düğün, inşaat veya geçici depolama ihtiyaçları için en pratik ve ekonomik çözümlerden biridir. Dayanıklı yapısı, kolay kurulumu ve taşınabilirliği sayesinde farklı sektörlerde güvenle kullanılabilir.", "Kiralık Çadır", null, "kiralik-cadir" },
                    { 27, 5, "Konser ve tören çadırı sistemleri, açık alan etkinliklerinde hava koşullarından etkilenmeden güvenli, konforlu ve estetik bir organizasyon ortamı oluşturmak için tasarlanmış modern çözümlerdir. Dayanıklı yapısı, geniş alan kaplama kapasitesi ve şık tasarımıyla her türlü etkinliğe profesyonel bir görünüm kazandırır.", "Konser Tören Çadırı", null, "konser-toren-cadiri" },
                    { 28, 6, "Sürgülü sineklik sistemleri, pencere ve kapılarda havalandırma konforunu bozmadan sinek, böcek ve haşerelere karşı etkili koruma sağlayan pratik çözümlerdir. Şık tasarımı, kolay kullanımı ve uzun ömürlü yapısıyla modern yaşam alanlarının vazgeçilmez bir parçasıdır.", "Sürgülü Sineklik", null, "surgulu-sineklik" },
                    { 29, 1, "Motorlu giyotin cam sistemleri, modern mimarinin en şık ve işlevsel çözümlerinden biridir. Dikey hareketle çalışan otomatik cam paneller, uzaktan kumanda veya buton yardımıyla kolayca açılıp kapanabilir. Bu sayede mekanlarda estetik, konfor ve teknolojiyi bir arada sunar.", "Motorlu Giyotin Cam", null, "motorlu-giyotin-cam" },
                    { 30, 1, "Üstte toplanır giyotin cam sistemleri, modern mimaride estetik ve konforu bir araya getiren yenilikçi bir cam kapama çözümüdür. Dikey hareketli paneller, özel motor sistemi sayesinde yukarı doğru toplanarak açık alanların pratik şekilde kontrol edilmesini sağlar. Kafe, restoran, otel, veranda ve teraslarda sıklıkla tercih edilir.", "Üstte Toplanır Giyotin Cam", null, "ustte-toplanır-giyotin-cam" },
                    { 31, 1, "Silinebilir giyotin cam sistemleri, modern yapılarda estetik görünüm, konfor ve kolay bakım avantajlarını bir arada sunan yenilikçi bir cam kaplama çözümüdür. Dikey hareketli cam paneller, özel mekanizması sayesinde kolayca temizlenebilir ve bakım gerektirmeden uzun yıllar kullanılabilir.", "Silinebilir Giyotin Cam", null, "silinebilir-giyotin-cam" },
                    { 32, 1, "Isı camlı giyotin cam sistemleri, modern mimarinin zarif tasarımını yüksek ısı yalıtımıyla birleştiren yenilikçi bir cam kapama çözümüdür. Dikey hareketli cam paneller, uzaktan kumanda veya buton yardımıyla kolayca kontrol edilirken, çift cam teknolojisi sayesinde hem enerji tasarrufu hem de konfor sağlar.", "Isı Camlı Giyotin", null, "isi-camli-giyotin" },
                    { 33, 1, "Tek camlı giyotin sistemleri, modern mimarinin zarif çizgilerini pratik kullanım ve ekonomik çözümlerle birleştiren yenilikçi cam kapama sistemleridir. Dikey hareketle çalışan cam paneller, motorlu veya manuel mekanizma sayesinde kolayca açılıp kapanabilir. Şeffaf, estetik ve hafif yapısıyla hem konut hem de ticari alanlarda sıkça tercih edilir.", "Tek Camlı Giyotin", null, "tek-camli-giyotin" },
                    { 34, 1, "Kumandalı giyotin cam sistemleri, modern yaşam alanlarında konfor, güvenlik ve estetiği bir araya getiren yenilikçi bir cam kaplama çözümüdür. Uzaktan kumanda veya buton yardımıyla kolayca kontrol edilen dikey hareketli cam paneller, açık alanları dilediğin gibi yönetme özgürlüğü sunar.", "Kumandalı Giyotin Cam", null, "kumandali-giyotin-cam" },
                    { 35, 4, "Katlanır cam balkon sistemleri, modern yaşam alanlarında estetik, konfor ve fonksiyonelliği bir araya getiren en popüler cam kapama çözümlerinden biridir. Cam panellerin yana doğru katlanarak tamamen açılabilmesi, balkonları ve terasları dört mevsim kullanılabilir hale getirir.", "Katlanır Cam Balkon", null, "katlanir-cam-balkon" },
                    { 36, 4, "Açılır cam tavan sistemleri, iç mekânlara doğal ışık kazandırırken dış etkenlerden korunmayı sağlayan modern ve estetik mimari çözümlerden biridir. Uzaktan kumanda veya manuel mekanizma ile kolayca açılıp kapanabilen bu sistemler, yaşam alanlarını dört mevsim kullanılabilir hale getirir.", "Açılır Cam Tavan Sistemleri", null, "acilir-cam-tavan-sistemleri" },
                    { 37, 4, "Cam çatı sistemleri, mimaride şeffaflık ve doğal ışığı ön plana çıkaran modern bir kaplama çözümüdür. Dayanıklı yapısı ve estetik görünümüyle hem konutlarda hem de ticari yapılarda tercih edilir. Geniş açıklıkları kapatarak mekânlara ferahlık kazandıran bu sistemler, dört mevsim konforu bir arada sunar.", "Cam Çatı Sistemleri", null, "cam-cati-sistemleri" },
                    { 38, 2, "Motorlu tente sistemleri, modern yaşam alanlarında konfor, estetik ve işlevselliği bir araya getiren en pratik gölgelendirme çözümlerinden biridir. Uzaktan kumanda, buton veya sensör desteğiyle kolayca açılıp kapanan bu sistemler, güneşten, yağmurdan ve rüzgârdan koruma sağlayarak açık alanları dört mevsim kullanılabilir hale getirir.", "Motorlu Tente", null, "motorlu-tente" },
                    { 39, 2, "Sabit tente sistemleri, dayanıklılığı ve estetik görünümüyle uzun yıllar boyunca koruma sağlayan en klasik ve güvenilir gölgelendirme çözümlerinden biridir. Yapıya sabit şekilde monte edilen bu tenteler, her türlü hava koşuluna karşı koruma sunarken mekânlara modern bir görünüm kazandırır.", "Sabit Tente", null, "sabit-tente" },
                    { 40, 2, "Kumandalı tente sistemleri, modern yaşam alanlarında konforu ve estetiği bir araya getiren en gelişmiş gölgelendirme çözümlerinden biridir. Uzaktan kumanda veya buton yardımıyla kolayca açılıp kapanabilen bu sistemler, hem kullanıcı dostu yapısı hem de şık tasarımıyla açık alanları dört mevsim kullanılabilir hale getirir.", "Kumandalı Tente", null, "kumandali-tente" },
                    { 41, 2, "Rolling Roof tente sistemleri, modern mimarinin en yenilikçi dış mekân çözümlerinden biridir. Açılır-kapanır tavan yapısı sayesinde tam gölgelendirme, havalandırma ve koruma sunan bu sistem, hem estetik hem de teknolojik yapısıyla yaşam alanlarını dört mevsim kullanılabilir hale getirir.", "Rolling Roof Tente", null, "rolling-roof-tente" },
                    { 42, 2, "Biyoklimatik tente sistemleri, doğa ile uyumlu şekilde tasarlanmış, modern yaşam alanlarına konfor ve estetik kazandıran ileri teknoloji gölgelendirme çözümleridir. Alüminyum panellerin açılıp kapanabilen yapısı sayesinde güneş ışığını, havayı ve yağmuru kontrollü şekilde yönlendirir; böylece açık alanlar dört mevsim kullanılabilir hale gelir.", "Bio Klimatik Tente", null, "bio-klimatik-tente" }
                });

            migrationBuilder.InsertData(
                table: "ServiceImages",
                columns: new[] { "Id", "MediaId", "ServiceId" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 2, 165, 2 },
                    { 12, 175, 6 },
                    { 13, 176, 6 },
                    { 14, 177, 6 },
                    { 15, 178, 7 },
                    { 16, 179, 7 },
                    { 17, 180, 7 },
                    { 18, 181, 8 },
                    { 19, 182, 8 },
                    { 20, 183, 8 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name", "ParentId", "Slug" },
                values: new object[,]
                {
                    { 3, "Pergola Tente Kumaşı Özellikleri ,-25 soğuğa,+70 sıcağa ve yağmura dayanıklı çadır, kaliteli tente kumaşları, uzman işçiliği ile müşterilerine uygun fiyatlarla.\r\ndilmesinin nedeni; tentenin güneşi ışıklarını maksimum derecede kesmesi ve tente altında kalan yaşam mahalini oldukça serin tutması olarak gösterilebilir. Kumaş kendiliğinden üç boyutlu bir desene sahip olması ve sıkı dokunuşlu oluşundan diğer kumaşlardan ayrılmaktadır. Özellikle raylı tente imalarında kullanılan bir kumaştır. Çok fazla renk seçimi sunmaz, fakat uzun ömürlüdür. Güneş ve yağmur geçirmez, Koku yapmaz, yosunlanmaz. Elbette fiyat olarak diğer türlere göre oldukça pahalıdır.", "Blackout Pergola Tente Kumaşı", 2, "blackout-pergola-tente-kumasi" },
                    { 4, "Sistemde kullanılacak tüm aluminyum ekstrüzyon profillerin 6063 T6 alaşımı ile ,ISO 9001:2008, Alüminyum ve alaşımları , eloksal ,toz boya kaplaması üretimi ve satışı kalite yönetim sistemi altında EN 15088 Alüminyum ve Alüminyum Alaşımları-Yapım işleri için yapısal mamüller muayene ve teslim için teknik şartlar ,EN755-1 Alüminyum ve Alüminyum alaşımları Ekstrüzyonla imal edilmiş Tellik Çubuk/Çubuk, boru ve profiller, TS EN 12020-1 , EN AW-6063 alaşımlarından ekstrüzyon ile imal edilmiş hassas profiller için teknik muayene ve teslim şartları , TS EN 12020-2 , EN AW-6063 alaşımlarından ekstrüzyon ile imal edilmiş hassas profiller için boyut ve şekil toleransları , normlarına uygunluğu üretici veya aluminyum ekstrüzyon tedarikçi firma tarafından geçerli uygunluk belgesi ile belgelendirilmelidir.\r\nSistemin Alüminyum Ekstrüzyon Profillerinde Uygulanacak Elektrostatik toz boya işleminin minimum 120 mikron kalınlıkta ve ‘’Qualicoat’’ kalite sistem markalı , uygulama proseslerine uygunluğu yine üretici veya aluminyum ektrüzyon tedarikçi firma tarafından uygunluğu geçerli uygunluk belgesi ile belgelendirilmelidir.", "Pergola Tente Teknik Özellikleri", 2, "pergola-tente-teknik-ozellikleri" },
                    { 5, "TekSan Tente, dış mekânlarda konforu, estetiği ve dayanıklılığı bir araya getiren Pergola Tente Sistemleri ile yaşam alanlarınıza değer katar. Modern mimariyle uyumlu, yüksek kaliteli malzemelerden üretilen pergola sistemlerimiz; otel, restoran, kafe, teras, bahçe ve veranda gibi alanlarda dört mevsim kesintisiz kullanım imkânı sunar.", "Pergola Tente İmalatı Çeşitleri", 2, "pergola-tente-imalati-cesitleri" }
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
                    { 107, 3, false, 108, 28 },
                    { 108, 3, true, 109, 29 },
                    { 109, 3, false, 110, 29 },
                    { 110, 3, false, 111, 29 },
                    { 111, 3, false, 112, 29 },
                    { 112, 3, true, 113, 30 },
                    { 113, 3, false, 114, 30 },
                    { 114, 3, false, 115, 30 },
                    { 115, 3, false, 116, 30 },
                    { 116, 3, true, 117, 31 },
                    { 117, 3, false, 118, 31 },
                    { 118, 3, false, 119, 31 },
                    { 119, 3, false, 120, 31 },
                    { 120, 3, true, 121, 32 },
                    { 121, 3, false, 122, 32 },
                    { 122, 3, false, 123, 32 },
                    { 123, 3, false, 124, 32 },
                    { 124, 3, true, 125, 33 },
                    { 125, 3, false, 126, 33 },
                    { 126, 3, false, 127, 33 },
                    { 127, 3, false, 128, 33 },
                    { 128, 3, true, 129, 34 },
                    { 129, 3, false, 130, 34 },
                    { 130, 3, false, 131, 34 },
                    { 131, 3, false, 132, 34 },
                    { 132, 3, true, 133, 35 },
                    { 133, 3, false, 134, 35 },
                    { 134, 3, false, 135, 35 },
                    { 135, 3, false, 136, 35 },
                    { 136, 3, true, 137, 36 },
                    { 137, 3, false, 138, 36 },
                    { 138, 3, false, 139, 36 },
                    { 139, 3, false, 140, 36 },
                    { 140, 3, true, 141, 37 },
                    { 141, 3, false, 142, 37 },
                    { 142, 3, false, 143, 37 },
                    { 143, 3, false, 144, 37 },
                    { 144, 3, true, 145, 38 },
                    { 145, 3, false, 146, 38 },
                    { 146, 3, false, 147, 38 },
                    { 147, 3, false, 148, 38 },
                    { 148, 3, true, 149, 39 },
                    { 149, 3, false, 150, 39 },
                    { 150, 3, false, 151, 39 },
                    { 151, 3, false, 152, 39 },
                    { 152, 3, true, 153, 40 },
                    { 153, 3, false, 154, 40 },
                    { 154, 3, false, 155, 40 },
                    { 155, 3, false, 156, 40 },
                    { 156, 3, true, 157, 41 },
                    { 157, 3, false, 158, 41 },
                    { 158, 3, false, 159, 41 },
                    { 159, 3, false, 160, 41 },
                    { 160, 3, true, 161, 42 },
                    { 161, 3, false, 162, 42 },
                    { 162, 3, false, 163, 42 },
                    { 163, 3, false, 163, 42 }
                });

            migrationBuilder.InsertData(
                table: "ServiceImages",
                columns: new[] { "Id", "MediaId", "ServiceId" },
                values: new object[,]
                {
                    { 3, 166, 3 },
                    { 4, 167, 3 },
                    { 5, 168, 3 },
                    { 6, 169, 4 },
                    { 7, 170, 4 },
                    { 8, 171, 4 },
                    { 9, 172, 5 },
                    { 10, 173, 5 },
                    { 11, 174, 5 }
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
