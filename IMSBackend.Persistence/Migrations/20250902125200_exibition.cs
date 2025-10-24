using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class exibition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("02c23292-9fae-414c-a811-bdb5833b8b6d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0ad830d0-98b9-4768-a5e7-7a23b65177ba"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1172b4ea-a701-49b2-b23e-fdd762885386"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3c62514e-e965-497f-985b-e015dc8123c9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("42bc842f-4fd2-4ccc-8eb5-07029e54e26d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("46d76747-ece5-40dc-8259-f21eb78afe7d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4e4c534e-195d-46be-9751-fbc5b1cef65c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("56882067-ed36-48ed-bb80-dc3623b98cc3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6390f02b-8aa5-485e-8248-9f8c895df538"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("65a55d68-0b08-4ad9-ac93-ae02600c620f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6665035b-01a7-4511-9608-acb241104e86"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7709f7e5-fef8-469e-bef9-a660b60beccb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("77879907-81f8-4a2c-aa87-e17a686aefb2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7b17f827-7266-4df4-af13-95cb9268ebd4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7b9f2d94-5499-4da3-a4ae-289963ac4642"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("805e2e43-b475-4e84-ad50-6175d61726c9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8d5074f3-d161-42ac-b5da-b1ac997e0b09"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("948d0478-b537-4090-a748-f4bb71960ee9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a5df7b21-8950-4818-912c-b8f83192c0a7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a800ffe5-bb91-4040-ba06-20b1ddfa1357"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a905a803-20e5-4cbe-9827-1af3d246599b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("aa26e331-0921-474c-af88-c606d02c2e38"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("be76e2a0-d1d3-400e-b7b0-77a01dd84cfa"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c98e68e7-b771-4426-90f9-0389fa171b67"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dea50086-08a6-4a61-9670-ba73cdbd23d5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f02bf12c-3955-4d6c-83e6-2a6e6d72a271"));

            migrationBuilder.CreateTable(
                name: "ExibitionStand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TikTokHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExitibitionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrandLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SampleProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExitibionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExibitionStand", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1130787a-ac2d-4e0b-90f8-b270b471f121"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(330), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(330), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("157bab4a-5d7c-415c-87c0-b034b0a24aec"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(313), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(313), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("2b0dadd4-88d5-4bab-b397-74697a915a05"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(365), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(366), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("2fc208d7-c600-4dd8-9453-8a4ed0f3f6be"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(370), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(370), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("4423d681-c799-43e7-b9ff-b76729c1e6f4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(338), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(338), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("45b9b927-2908-498c-8f82-f53d8e872c89"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(327), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(328), null, false, "Craft Mastery Award", false, null },
                    { new Guid("53a69d78-a431-4d25-beb5-ede1b9993caf"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(345), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(345), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("540a4e83-eefa-435c-90cf-e5926c0ac326"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(296), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(296), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("563e007a-bf1c-41d7-8f6c-0fef2c1753e0"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(356), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(357), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("5703aac3-b8c8-48a9-a9a3-e46e4edc89e9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(320), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(321), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("598e3e96-82c7-440d-93f3-817130c2404e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(336), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(336), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("5df4f5ea-de3c-4147-b7f4-a6c2f91a1c1b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(342), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(343), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("60075000-5d59-4f4e-afce-a3ababac8c2e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(367), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(368), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("86c42e48-9390-4bc1-906a-9de6a7fa7041"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(323), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("8d2db3ac-49e9-4716-86fa-b85f642deae2"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(358), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(359), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("981908d6-4fcc-4e04-8846-854bb745ae1e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(325), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(325), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("9cda9241-0b26-42c1-8108-2b41dcf21161"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(299), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(299), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("a9e496f9-8aee-4559-90cc-8ff37c2ac5fe"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(253), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(256), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("bbbfb182-c51a-4a0e-bb95-7879cde84af6"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(361), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(361), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("ce64e040-23bd-41de-997a-8bd1c6429bdb"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(315), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("d2aead3d-af26-4896-9b3e-39fd3d686192"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(340), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(340), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("e3293a7f-0ade-4a55-b962-8be0a91e4fa3"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(318), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(318), null, false, "Most Creative Baker", false, null },
                    { new Guid("ea736d6b-ef8e-4695-a6cd-db4234eeaaf6"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(351), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(351), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("f59df638-1334-4996-bbcf-86b0037e65b2"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(363), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(363), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("f64ae92a-d2b3-4b90-8608-8ffd16ef8b1d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(349), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(349), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("ffdbb1b1-58cc-44b1-9e4a-47a401d73c06"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(347), new DateTime(2025, 9, 2, 12, 51, 59, 257, DateTimeKind.Utc).AddTicks(347), null, false, "Textile Manufacturing Brand of the Year", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1130787a-ac2d-4e0b-90f8-b270b471f121"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("157bab4a-5d7c-415c-87c0-b034b0a24aec"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b0dadd4-88d5-4bab-b397-74697a915a05"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2fc208d7-c600-4dd8-9453-8a4ed0f3f6be"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4423d681-c799-43e7-b9ff-b76729c1e6f4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("45b9b927-2908-498c-8f82-f53d8e872c89"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("53a69d78-a431-4d25-beb5-ede1b9993caf"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("540a4e83-eefa-435c-90cf-e5926c0ac326"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("563e007a-bf1c-41d7-8f6c-0fef2c1753e0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5703aac3-b8c8-48a9-a9a3-e46e4edc89e9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("598e3e96-82c7-440d-93f3-817130c2404e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5df4f5ea-de3c-4147-b7f4-a6c2f91a1c1b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("60075000-5d59-4f4e-afce-a3ababac8c2e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("86c42e48-9390-4bc1-906a-9de6a7fa7041"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8d2db3ac-49e9-4716-86fa-b85f642deae2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("981908d6-4fcc-4e04-8846-854bb745ae1e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9cda9241-0b26-42c1-8108-2b41dcf21161"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a9e496f9-8aee-4559-90cc-8ff37c2ac5fe"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bbbfb182-c51a-4a0e-bb95-7879cde84af6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ce64e040-23bd-41de-997a-8bd1c6429bdb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d2aead3d-af26-4896-9b3e-39fd3d686192"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e3293a7f-0ade-4a55-b962-8be0a91e4fa3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ea736d6b-ef8e-4695-a6cd-db4234eeaaf6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f59df638-1334-4996-bbcf-86b0037e65b2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f64ae92a-d2b3-4b90-8608-8ffd16ef8b1d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ffdbb1b1-58cc-44b1-9e4a-47a401d73c06"));

            migrationBuilder.CreateTable(
                name: "ExibitionStands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExitibionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExitibitionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SampleProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TikTokHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExibitionStands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("02c23292-9fae-414c-a811-bdb5833b8b6d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6231), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6232), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("0ad830d0-98b9-4768-a5e7-7a23b65177ba"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6178), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6178), null, false, "Most Creative Baker", false, null },
                    { new Guid("1172b4ea-a701-49b2-b23e-fdd762885386"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6205), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6206), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("3c62514e-e965-497f-985b-e015dc8123c9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6207), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6208), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("42bc842f-4fd2-4ccc-8eb5-07029e54e26d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6193), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("46d76747-ece5-40dc-8259-f21eb78afe7d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6236), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6236), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("4e4c534e-195d-46be-9751-fbc5b1cef65c"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6176), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6176), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("56882067-ed36-48ed-bb80-dc3623b98cc3"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6174), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("6390f02b-8aa5-485e-8248-9f8c895df538"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6169), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("65a55d68-0b08-4ad9-ac93-ae02600c620f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6223), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6223), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("6665035b-01a7-4511-9608-acb241104e86"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6195), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6195), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("7709f7e5-fef8-469e-bef9-a660b60beccb"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6227), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6227), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("77879907-81f8-4a2c-aa87-e17a686aefb2"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6217), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6217), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("7b17f827-7266-4df4-af13-95cb9268ebd4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6125), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6127), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("7b9f2d94-5499-4da3-a4ae-289963ac4642"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6220), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6221), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("805e2e43-b475-4e84-ad50-6175d61726c9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6171), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("8d5074f3-d161-42ac-b5da-b1ac997e0b09"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6234), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6234), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("948d0478-b537-4090-a748-f4bb71960ee9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6225), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6225), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("a5df7b21-8950-4818-912c-b8f83192c0a7"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6238), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6238), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("a800ffe5-bb91-4040-ba06-20b1ddfa1357"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6197), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6197), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("a905a803-20e5-4cbe-9827-1af3d246599b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6199), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6199), null, false, "Craft Mastery Award", false, null },
                    { new Guid("aa26e331-0921-474c-af88-c606d02c2e38"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6215), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6215), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("be76e2a0-d1d3-400e-b7b0-77a01dd84cfa"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6201), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6201), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("c98e68e7-b771-4426-90f9-0389fa171b67"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6213), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6213), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("dea50086-08a6-4a61-9670-ba73cdbd23d5"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6203), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6204), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("f02bf12c-3955-4d6c-83e6-2a6e6d72a271"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6219), new DateTime(2025, 9, 2, 12, 45, 24, 875, DateTimeKind.Utc).AddTicks(6219), null, false, "Outstanding Female Entrepreneur of the Year", false, null }
                });
        }
    }
}
