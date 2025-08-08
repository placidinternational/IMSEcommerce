using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("01ffda8e-784e-41f7-abfa-ad074515ffe9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("10864083-5aa8-4139-aebd-306a9b517224"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("10dbfde8-b914-41a1-99d9-e14398c1deb0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("12b8e2da-d52b-4152-8a7a-33a06a68adf6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("26c6f3e3-9926-4ea8-beba-95d81fb0bade"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("27c303db-cd34-4937-acff-54a1aaab9f69"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2c08af38-128f-44c5-bba0-a1c686d3f546"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("50e63d5c-3324-47d1-b6dc-f4e4a6aac065"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5dec334b-144c-4372-b474-a8871886094a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("661fb8da-da25-4aa9-b3a6-e9266c50d2a0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6de60535-1ec3-4621-a39b-bbc12ce71899"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6f51e185-e78a-45ab-b419-fc07a20de354"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("70f140f8-20f6-44dd-b508-9f9deed2cb05"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("78b286d7-095c-4e80-a454-f880892215a0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8a3aefe1-6830-4948-a99d-37bdef65e110"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8e49843f-aab0-4bac-bed2-0ec269175953"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eff98ea-d5e1-4a80-9011-c70abbf3faa4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a310ad01-cace-4526-9885-e65056283f2d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b9989359-33d2-4e09-b125-296ec312680f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c4e18beb-a302-468b-bac7-8d619c1cec81"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d9721ba0-52e0-4436-b51b-c144c098287d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df8103f6-848c-48b2-abde-c4f1215183ed"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e9ede2c7-7e24-4dde-a1a8-a6e7d904b2ea"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f539d32b-8e39-40fe-b1f7-5910d45e9308"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f64f0444-c0d4-4df2-a1b4-762959d5f354"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("fbfe531b-65ca-43cf-ad26-b05703fd7298"));

            migrationBuilder.DeleteData(
                table: "PitchPrice",
                keyColumn: "Id",
                keyValue: new Guid("d3307b7b-b3f1-439b-8172-69ae23351229"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("029f94ba-9c50-4d57-ac9f-17629780bd28"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2849), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2850), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("18f5f143-ec8e-4001-ba67-2ce9f01218ca"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2870), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2870), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("200f069a-a43d-4503-8e0c-aedf95eadc70"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2875), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2876), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("230cb77b-a547-4a63-b18a-c216284c6c03"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2835), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2835), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("23a17a4c-b34e-4f3e-9e52-7ce5f4b0cbc2"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2861), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2862), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("28dd89cd-b3b4-45f3-ba71-35f085cb6277"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2832), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2832), null, false, "Most Creative Baker", false, null },
                    { new Guid("2aaf17ee-df56-46c9-ab88-8115238bf8a6"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2855), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2856), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("2e6f7d69-a944-4498-91f5-973292be5a6f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2872), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2873), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("3398c49d-0fb5-4817-9969-34c2c6e568a7"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2808), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2809), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("3d706d9a-738c-4386-8d39-a64bed2e8e82"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2867), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2867), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("40a8bc6b-e935-412d-a8b5-2b0ea0a28fc4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2905), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2905), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("46bf17d0-ce2c-418b-880b-02de93cef3b8"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2766), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2769), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("5ecb05e7-7dcb-418a-bfdd-9ab09b9756ed"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2864), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2864), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("772857db-dc53-44fb-aa93-75964282fdcf"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2844), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2844), null, false, "Craft Mastery Award", false, null },
                    { new Guid("79605358-ccab-4eb3-ab99-e52f04dcbe06"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2894), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2894), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("7e70401b-71f0-4de6-9f2e-77e87cbd5109"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2899), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2899), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("932842e1-b3ef-4272-81dd-355642e03f97"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2896), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2897), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("96d16cf4-5562-4405-a527-b307da3e35a8"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2838), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2838), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("9a6699d4-a706-4e17-adb5-1f2f49260bf4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2829), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2829), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("a2f8ab18-16dd-4a35-8182-5530e6afafb7"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2902), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2902), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("aa4bc673-4f30-4d6d-b4b0-535f6157692f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2816), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2816), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("cb89ba7c-fbe4-41b0-822c-74cc12b9d6ce"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2847), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2847), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("d0bc9629-1e2b-4394-9332-761d3fe35448"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2858), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2859), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("d5cd2ef5-c73d-4571-b3b5-1d702c5fadab"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2841), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2841), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("dafccfde-e3c8-4806-97ea-b8781f656ec1"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2891), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2891), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("e942057a-bb1f-4b30-b07c-e4a9fb61c101"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2812), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(2813), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null }
                });

            migrationBuilder.InsertData(
                table: "PitchPrice",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Price", "UpdatedBy" },
                values: new object[] { new Guid("c90b88d0-955d-4def-b7af-1d0235ca3886"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(3132), new DateTime(2025, 8, 8, 12, 6, 36, 440, DateTimeKind.Utc).AddTicks(3132), null, false, 15000m, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("029f94ba-9c50-4d57-ac9f-17629780bd28"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("18f5f143-ec8e-4001-ba67-2ce9f01218ca"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("200f069a-a43d-4503-8e0c-aedf95eadc70"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("230cb77b-a547-4a63-b18a-c216284c6c03"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("23a17a4c-b34e-4f3e-9e52-7ce5f4b0cbc2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("28dd89cd-b3b4-45f3-ba71-35f085cb6277"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2aaf17ee-df56-46c9-ab88-8115238bf8a6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2e6f7d69-a944-4498-91f5-973292be5a6f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3398c49d-0fb5-4817-9969-34c2c6e568a7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3d706d9a-738c-4386-8d39-a64bed2e8e82"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("40a8bc6b-e935-412d-a8b5-2b0ea0a28fc4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("46bf17d0-ce2c-418b-880b-02de93cef3b8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ecb05e7-7dcb-418a-bfdd-9ab09b9756ed"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("772857db-dc53-44fb-aa93-75964282fdcf"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("79605358-ccab-4eb3-ab99-e52f04dcbe06"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7e70401b-71f0-4de6-9f2e-77e87cbd5109"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("932842e1-b3ef-4272-81dd-355642e03f97"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("96d16cf4-5562-4405-a527-b307da3e35a8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9a6699d4-a706-4e17-adb5-1f2f49260bf4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2f8ab18-16dd-4a35-8182-5530e6afafb7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("aa4bc673-4f30-4d6d-b4b0-535f6157692f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cb89ba7c-fbe4-41b0-822c-74cc12b9d6ce"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d0bc9629-1e2b-4394-9332-761d3fe35448"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d5cd2ef5-c73d-4571-b3b5-1d702c5fadab"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dafccfde-e3c8-4806-97ea-b8781f656ec1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e942057a-bb1f-4b30-b07c-e4a9fb61c101"));

            migrationBuilder.DeleteData(
                table: "PitchPrice",
                keyColumn: "Id",
                keyValue: new Guid("c90b88d0-955d-4def-b7af-1d0235ca3886"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("01ffda8e-784e-41f7-abfa-ad074515ffe9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1383), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1383), null, false, "Most Creative Baker", false, null },
                    { new Guid("10864083-5aa8-4139-aebd-306a9b517224"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1417), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1417), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("10dbfde8-b914-41a1-99d9-e14398c1deb0"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1442), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1443), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("12b8e2da-d52b-4152-8a7a-33a06a68adf6"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1411), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("26c6f3e3-9926-4ea8-beba-95d81fb0bade"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1420), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1420), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("27c303db-cd34-4937-acff-54a1aaab9f69"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1389), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1390), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("2c08af38-128f-44c5-bba0-a1c686d3f546"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1414), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("50e63d5c-3324-47d1-b6dc-f4e4a6aac065"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1439), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1440), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("5dec334b-144c-4372-b474-a8871886094a"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1393), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1393), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("661fb8da-da25-4aa9-b3a6-e9266c50d2a0"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1433), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1433), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("6de60535-1ec3-4621-a39b-bbc12ce71899"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1373), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1373), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("6f51e185-e78a-45ab-b419-fc07a20de354"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1423), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1424), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("70f140f8-20f6-44dd-b508-9f9deed2cb05"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1404), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("78b286d7-095c-4e80-a454-f880892215a0"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1282), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1285), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("8a3aefe1-6830-4948-a99d-37bdef65e110"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1430), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1430), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("8e49843f-aab0-4bac-bed2-0ec269175953"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1459), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("9eff98ea-d5e1-4a80-9011-c70abbf3faa4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1386), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1387), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("a310ad01-cace-4526-9885-e65056283f2d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1400), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1401), null, false, "Craft Mastery Award", false, null },
                    { new Guid("b9989359-33d2-4e09-b125-296ec312680f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1452), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1452), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("c4e18beb-a302-468b-bac7-8d619c1cec81"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1380), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1380), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("d9721ba0-52e0-4436-b51b-c144c098287d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1436), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1436), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("df8103f6-848c-48b2-abde-c4f1215183ed"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1376), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1377), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("e9ede2c7-7e24-4dde-a1a8-a6e7d904b2ea"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1449), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1449), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("f539d32b-8e39-40fe-b1f7-5910d45e9308"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1446), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1446), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("f64f0444-c0d4-4df2-a1b4-762959d5f354"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1368), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1369), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("fbfe531b-65ca-43cf-ad26-b05703fd7298"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1407), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1407), null, false, "Creative Bridal Hairstylist of the Year", false, null }
                });

            migrationBuilder.InsertData(
                table: "PitchPrice",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Price", "UpdatedBy" },
                values: new object[] { new Guid("d3307b7b-b3f1-439b-8172-69ae23351229"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1735), new DateTime(2025, 8, 8, 12, 5, 7, 932, DateTimeKind.Utc).AddTicks(1736), null, false, 15000m, null });
        }
    }
}
