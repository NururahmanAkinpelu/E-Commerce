using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SecondSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "IsDeleteBy", "IsDeleteOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Electronics", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6543), "Fast wireless charging pad compatible with all Qi-enabled devices", "https://example.com/products/wireless-charger.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Wireless Charging Pad", 39.99m, 60 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Electronics", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6551), "Portable waterproof Bluetooth speaker with 360-degree sound", "https://example.com/products/bluetooth-speaker.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Bluetooth Speaker", 89.99m, 35 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Accessories", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6566), "Adjustable aluminum laptop stand for better ergonomics", "https://example.com/products/laptop-stand.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Laptop Stand", 49.99m, 45 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Sports & Fitness", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6576), "Insulated stainless steel water bottle that keeps drinks cold for 24 hours", "https://example.com/products/water-bottle.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Water Bottle", 19.99m, 80 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Home & Office", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6590), "Adjustable LED desk lamp with USB charging port and touch controls", "https://example.com/products/desk-lamp.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "LED Desk Lamp", 34.99m, 30 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Electronics", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6598), "True wireless earbuds with active noise cancellation and 8-hour battery", "https://example.com/products/wireless-earbuds.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Wireless Earbuds", 129.99m, 40 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Sports & Fitness", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6607), "Smart fitness tracker with heart rate monitor and sleep tracking", "https://example.com/products/fitness-tracker.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Fitness Tracker", 79.99m, 55 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Home & Kitchen", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6616), "Digital kitchen scale with precision weighing up to 11 lbs", "https://example.com/products/kitchen-scale.jpg", new Guid("00000000-0000-0000-0000-000000000000"), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null, "Kitchen Scale", 24.99m, 25 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 11, 37, 20, 757, DateTimeKind.Utc).AddTicks(6463));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedOn",
                value: new DateTime(2025, 8, 13, 8, 5, 14, 60, DateTimeKind.Utc).AddTicks(2505));
        }
    }
}
