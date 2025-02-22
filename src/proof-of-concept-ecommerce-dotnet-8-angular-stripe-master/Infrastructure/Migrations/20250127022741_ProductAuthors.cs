using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b2875f-991a-461c-8cb8-06a516f63630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc84abe7-6ee9-4872-85a1-eae88ee59644");

            migrationBuilder.AddColumn<string>(
                name: "Authors",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00db9811-71bc-4ff1-a032-3a414a2268b8", "a1827672-b529-4196-bc5d-53f48dec1945", "Customer", "CUSTOMER" },
                    { "cdea594b-23a4-43c3-8169-88bd458ca8de", "63c6f13f-f6a4-4663-bb3d-9779bc683f54", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00db9811-71bc-4ff1-a032-3a414a2268b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdea594b-23a4-43c3-8169-88bd458ca8de");

            migrationBuilder.DropColumn(
                name: "Authors",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05b2875f-991a-461c-8cb8-06a516f63630", "203b8352-a108-46d1-96a1-74a576547600", "Admin", "ADMIN" },
                    { "fc84abe7-6ee9-4872-85a1-eae88ee59644", "5c319cde-34c0-4c2d-8baa-0eeace778250", "Customer", "CUSTOMER" }
                });
        }
    }
}
