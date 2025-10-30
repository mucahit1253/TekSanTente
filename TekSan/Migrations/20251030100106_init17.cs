using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
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
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 108);
        }
    }
}
