using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 17, "cift-acilir-tente-1.jpg", "image/jpeg", "cift-acilir-tente-1.jpg", "/assets/img/properties/cift-acilir-tente-1.jpg" },
                    { 18, "cift-acilir-tente-2.jpg", "image/jpeg", "cift-acilir-tente-2.jpg", "/assets/img/properties/cift-acilir-tente-2.jpg" },
                    { 19, "cift-acilir-tente-3.jpg", "image/jpeg", "cift-acilir-tente-3.jpg", "/assets/img/properties/cift-acilir-tente-3.jpg" },
                    { 20, "cift-acilir-tente-4.jpg", "image/jpeg", "cift-acilir-tente-4.jpg", "/assets/img/properties/cift-acilir-tente-4.jpg" },
                    { 21, "mafsal-tente-1.jpg", "image/jpeg", "mafsal-tente-1.jpg", "/assets/img/properties/mafsal-tente-1.jpg" },
                    { 22, "mafsal-tente-2.jpg", "image/jpeg", "mafsal-tente-2.jpg", "/assets/img/properties/mafsal-tente-2.jpg" },
                    { 23, "mafsal-tente-3.jpg", "image/jpeg", "mafsal-tente-3.jpg", "/assets/img/properties/mafsal-tente-3.jpg" },
                    { 24, "mafsal-tente-4.jpg", "image/jpeg", "mafsal-tente-4.jpg", "/assets/img/properties/mafsal-tente-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 16, 3, true, 17, 4 },
                    { 17, 3, false, 18, 4 },
                    { 18, 3, false, 19, 4 },
                    { 19, 3, false, 20, 4 },
                    { 20, 3, false, 21, 5 },
                    { 21, 3, false, 22, 5 },
                    { 22, 3, false, 23, 5 },
                    { 23, 3, false, 24, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
