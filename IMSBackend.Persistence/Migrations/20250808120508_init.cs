using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Payments_PaymentId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_PaymentId",
                table: "Votes");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("011256a4-1c2b-46fe-bdf3-e0ac1346fa83"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("08fe0f4c-7d79-4d95-a6bd-2c4c083bba34"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1095ee84-2638-49e7-b71b-2e1860ab83ee"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1ea5465e-29e8-4d45-9c9c-6dc1ab3a2e40"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("41837871-21fb-4588-8f0b-6223655dd694"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4528a8ce-2631-4411-9b60-17b4d6d325b5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("454a53b4-c8b7-47cb-9c53-0e05d5d70354"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("457887b7-f55f-4d81-8e29-da0240e4f97b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("47d1fb8c-6594-4afd-b4b7-e0f32e25e93b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("697d012f-0328-418b-a60d-21c805068590"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7823e5ed-617f-41ec-9a34-62c2b87b1d7e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9749500e-23e5-4a63-b971-e1ff37598129"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a38ffc23-5941-4e69-908b-097349fbc32f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a6dfdac3-caa6-43c6-8f2e-80a9a13df1f8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a91628b2-53ce-4f50-86c4-1f0e0cb19a48"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a9983ad5-5704-431d-ab29-570cf4689cb2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ae15dd5b-74dc-41ad-987e-3eb1618cdb90"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bb9d93a8-2488-4f97-9c5e-11d3685c0563"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bfc23686-e4f9-4ec7-a994-de6af5e9f1f9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ca9c4a55-ee67-4a78-a652-83f016270e63"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d0447c95-7683-495d-81a4-5e8ab551b92f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d7113b36-1e3c-455e-a0a0-c6e845779737"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d988d8fe-b2f0-4cd9-b6ec-a0ed605d2321"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dd7a3e06-18f3-4578-a085-045737af959a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e2648237-0705-45b8-9637-3aeb084df613"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e8bb2082-41ed-4617-84e1-47642d1d55f0"));

            migrationBuilder.DeleteData(
                table: "PitchPrice",
                keyColumn: "Id",
                keyValue: new Guid("7a2c6c47-fa12-4c9f-9c7a-d649bfdb63b9"));

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Votes");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentId",
                table: "Votes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("011256a4-1c2b-46fe-bdf3-e0ac1346fa83"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5657), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5657), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("08fe0f4c-7d79-4d95-a6bd-2c4c083bba34"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5678), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5678), null, false, "Craft Mastery Award", false, null },
                    { new Guid("1095ee84-2638-49e7-b71b-2e1860ab83ee"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5702), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5702), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("1ea5465e-29e8-4d45-9c9c-6dc1ab3a2e40"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5733), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5733), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("41837871-21fb-4588-8f0b-6223655dd694"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5745), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5745), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("4528a8ce-2631-4411-9b60-17b4d6d325b5"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5708), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5708), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("454a53b4-c8b7-47cb-9c53-0e05d5d70354"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5550), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5554), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("457887b7-f55f-4d81-8e29-da0240e4f97b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5721), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5721), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("47d1fb8c-6594-4afd-b4b7-e0f32e25e93b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5738), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5739), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("697d012f-0328-418b-a60d-21c805068590"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5660), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5660), null, false, "Most Creative Baker", false, null },
                    { new Guid("7823e5ed-617f-41ec-9a34-62c2b87b1d7e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5711), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5711), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("9749500e-23e5-4a63-b971-e1ff37598129"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5730), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5730), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("a38ffc23-5941-4e69-908b-097349fbc32f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5727), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5727), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("a6dfdac3-caa6-43c6-8f2e-80a9a13df1f8"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5667), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5668), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("a91628b2-53ce-4f50-86c4-1f0e0cb19a48"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5736), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5736), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("a9983ad5-5704-431d-ab29-570cf4689cb2"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5699), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5699), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("ae15dd5b-74dc-41ad-987e-3eb1618cdb90"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5717), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5717), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("bb9d93a8-2488-4f97-9c5e-11d3685c0563"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5650), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5651), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("bfc23686-e4f9-4ec7-a994-de6af5e9f1f9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5681), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5681), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("ca9c4a55-ee67-4a78-a652-83f016270e63"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5670), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5671), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("d0447c95-7683-495d-81a4-5e8ab551b92f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5664), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5664), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("d7113b36-1e3c-455e-a0a0-c6e845779737"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5646), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5647), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("d988d8fe-b2f0-4cd9-b6ec-a0ed605d2321"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5696), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5696), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("dd7a3e06-18f3-4578-a085-045737af959a"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5705), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5705), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("e2648237-0705-45b8-9637-3aeb084df613"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5654), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5654), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("e8bb2082-41ed-4617-84e1-47642d1d55f0"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5724), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(5725), null, false, "Best Emerging Entrepreneur of the Year", false, null }
                });

            migrationBuilder.InsertData(
                table: "PitchPrice",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Price", "UpdatedBy" },
                values: new object[] { new Guid("7a2c6c47-fa12-4c9f-9c7a-d649bfdb63b9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(6157), new DateTime(2025, 8, 8, 11, 48, 2, 990, DateTimeKind.Utc).AddTicks(6158), null, false, 15000m, null });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PaymentId",
                table: "Votes",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Payments_PaymentId",
                table: "Votes",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }
    }
}
