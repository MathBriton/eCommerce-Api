using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BasicDataRolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05b2875f-991a-461c-8cb8-06a516f63630", "203b8352-a108-46d1-96a1-74a576547600", "Admin", "ADMIN" },
                    { "fc84abe7-6ee9-4872-85a1-eae88ee59644", "5c319cde-34c0-4c2d-8baa-0eeace778250", "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b2875f-991a-461c-8cb8-06a516f63630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc84abe7-6ee9-4872-85a1-eae88ee59644");
        }
    }
}
