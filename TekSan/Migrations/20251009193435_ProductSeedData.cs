using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Price", "Slug" },
                values: new object[,]
                {
                    { 1, 1, "Pergole Tente", 2000m, "pergole-tente" },
                    { 2, 1, "Körük Tente", 2500m, "koruk-tente" },
                    { 3, 1, "Stor Tente", 1500m, "stor-tente" },
                    { 4, 1, "Çift Açılır Tente", 5000m, "cift-acılır-tente" },
                    { 5, 1, "Mafsallı Tente", 30000m, "mafsalli-tente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
