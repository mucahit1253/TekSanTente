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
                    { 4, "koruktentekapak", "image/jpeg", "koruktente-1.jpg", "/assents/img/properties/koruktente/koruktente-1.jpg" },
                    { 5, "koruktente-2", "image/jpeg", "koruktente-2.jpg", "/assents/img/properties/koruktente/koruktente-2.jpg" },
                    { 6, "koruktente-3", "image/jpeg", "koruktente-3.jpg", "/assents/img/properties/koruktente/koruktente-3.jpg" },
                    { 7, "koruktente-4", "image/jpeg", "koruktente-4.jpg", "/assents/img/properties/koruktente/koruktente-4.jpg" },
                    { 8, "koruktente-5", "image/jpeg", "koruktente-5.jpg", "/assents/img/properties/koruktente/koruktente-5.jpg" }
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
                    { 1, 2, "Pergole Tenteler Ticari alanlarda veya konutlarda kullanılan pergole tente sistemleri, dış mekanda yaşam kalitesini yükselten ekipmanlardan oluşur. Çok uzun yıllar boyunca kullanılan pergole tente, hava koşullarına karşı en ideal yaşam alanları oluşturmayı sağlar. Bu sistemler teknolojik gelişmelerle birlikte güncellenip motor ve sensör desteğiyle daha kullanışlı hale gelmiştir. İşyeriniz veya eviniz için ihtiyacınız olan tüm pergola tenteleri firmamızdan uygun fiyatlarla tedarik edebilirsiniz. ", "Pergole Tente", 2000m, "pergole-tente" },
                    { 2, 2, "Körüklü tentelerin kurulumu ve kullanıma kolay tente modellerinden sadece biridir. Tente Sistemi Akordeon Şeklinde Açılıp Kapanmaktadır Diğer Tentelerde Farkı yan kısımlar Kapalı olduğundan Güneş ve Yağmur gelmesini Engeller  kullanıldığı alanlarda şık Dizaynı ve Tasarımıyla bulunduğu alana ayrı bir Görsellik katar.\r\n\r\nKörüklü Sisteminin Saçak Modeli Deniz dalgası modeli veya Düz saçak modeli tercih edilmektedir.", "Körük Tente", 2500m, "koruk-tente" },
                    { 3, 2, "Stor tente normal mafsallı tentenin kolsuz modelidir.karşıdan gelen güneş için tercih edilen bir modeldir. Stor tente Yukardan aşağı açılıp kapanan bir modeldir istenildiği taktirde motorlu sistemde uyumludur.stor tente asıl amacı, gölgelendirme işlevini yapmak olsa da fonksiyonellik yönünden de hiçbir şekilde sınır tanımamaktadır.", "Stor Tente", 1500m, "stor-tente" },
                    { 4, 2, "Çift açılır tente kurulumu ve kullanımı kolay tente modellerinden sadece biridir.\r\n\r\nBu tente sayesinde hem daha sağlıklı bir hava ortamına sahip olursunuz hemde iş yerleriniz daha güzel bire görünüme kavuşmaktadır. taksitli fiyatları akrilik kumaşlı ısı geçirmeyen garanti belgeli kaliteli", "Çift Açılır Tente", 5000m, "cift-acılır-tente" },
                    { 5, 2, "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "Mafsallı Tente", 30000m, "mafsalli-tente" }
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
                    { 7, 3, false, 8, 2 }
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
