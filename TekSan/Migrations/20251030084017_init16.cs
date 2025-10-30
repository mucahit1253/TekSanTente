using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 70, "cam-balkon-1.jpg", "image/jpeg", "cam-balkon-1.jpg", "/assets/img/properties/cam-balkon-1.jpg" },
                    { 71, "cam-balkon-2.jpg", "image/jpeg", "cam-balkon-2.jpg", "/assets/img/properties/cam-balkon-2.jpg" },
                    { 72, "cam-balkon-3.jpg", "image/jpeg", "cam-balkon-3.jpg", "/assets/img/properties/cam-balkon-3.jpg" },
                    { 73, "cam-balkon-4.jpg", "image/jpeg", "cam-balkon-4.jpg", "/assets/img/properties/cam-balkon-4.jpg" },
                    { 74, "cam-balkon-5.jpg", "image/jpeg", "cam-balkon-5.jpg", "/assets/img/properties/cam-balkon-5.jpg" },
                    { 75, "cam-balkon-6.jpg", "image/jpeg", "cam-balkon-6.jpg", "/assets/img/properties/cam-balkon-6.jpg" },
                    { 76, "cam-veranda-1", "image/jpeg", "cam-veranda-1.jpg", "/assets/img/properties/cam-veranda-1.jpg" },
                    { 77, "cam-veranda-2", "image/jpeg", "cam-veranda-2.jpg", "/assets/img/properties/cam-veranda-2.jpg" },
                    { 78, "cam-veranda-3", "image/jpeg", "cam-veranda-3.jpg", "/assets/img/properties/cam-veranda-3.jpg" },
                    { 79, "cam-veranda-4", "image/jpeg", "cam-veranda-4.jpg", "/assets/img/properties/cam-veranda-4.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ProductId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ProductId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ProductId",
                value: 17);

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 69, 3, true, 70, 18 },
                    { 70, 3, false, 71, 18 },
                    { 71, 3, false, 72, 18 },
                    { 72, 3, false, 73, 18 },
                    { 73, 3, false, 74, 18 },
                    { 74, 3, false, 75, 18 },
                    { 75, 3, true, 76, 19 },
                    { 76, 3, false, 77, 19 },
                    { 77, 3, false, 78, 19 },
                    { 78, 3, false, 79, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ProductId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ProductId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ProductId",
                value: 16);
        }
    }
}
