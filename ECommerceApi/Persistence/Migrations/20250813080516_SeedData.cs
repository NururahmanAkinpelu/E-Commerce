using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "IsDeleteBy", "IsDeleteOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Electronics", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2522), "High-quality wireless headphones with noise cancellation and 30-hour battery life", "https://example.com/products/headphones.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Wireless Bluetooth Headphones", 99.99m, 50 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "Accessories", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2533), "Durable protective case for smartphones with shock absorption", "https://example.com/products/phone-case.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Smartphone Case", 24.99m, 100 },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Home & Kitchen", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2551), "Programmable coffee maker with 12-cup capacity and auto-shutoff feature", "https://example.com/products/coffee-maker.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Coffee Maker", 79.99m, 25 },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), "Electronics", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2561), "High-precision gaming mouse with RGB lighting and programmable buttons", "https://example.com/products/gaming-mouse.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Gaming Mouse", 59.99m, 75 },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "Sports & Fitness", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2570), "Non-slip yoga mat with extra cushioning for comfortable practice", "https://example.com/products/yoga-mat.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Yoga Mat", 29.99m, 40 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedOn", "Email", "FirstName", "IsDeleteBy", "IsDeleteOn", "IsDeleted", "IsEmailVerified", "IsPhoneNumberVerified", "LastModifiedBy", "LastModifiedOn", "LastName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "Role" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "123 Main St, New York, NY 10001", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2474), "john.doe@example.com", "John", new Guid("00000000-0000-0000-0000-000000000000"), null, false, true, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Doe", "hashedpassword123", "+1234567890", "https://example.com/profiles/john.jpg", "User" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "456 Oak Ave, Los Angeles, CA 90210", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2492), "jane.smith@example.com", "Jane", new Guid("00000000-0000-0000-0000-000000000000"), null, false, true, true, new Guid("00000000-0000-0000-0000-000000000000"), null, "Smith", "hashedpassword456", "+1987654321", "https://example.com/profiles/jane.jpg", "User" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "789 Admin Blvd, Chicago, IL 60601", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2505), "admin@example.com", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), null, false, true, true, new Guid("00000000-0000-0000-0000-000000000000"), null, "User", "hashedpasswordadmin", "+1555666777", "https://example.com/profiles/admin.jpg", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));
        }
    }
}
