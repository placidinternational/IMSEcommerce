using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class businesscat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPitch_Category_BusinessCategoryId",
                table: "BusinessPitch");

            migrationBuilder.DropIndex(
                name: "IX_BusinessPitch_BusinessCategoryId",
                table: "BusinessPitch");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("01c6e045-09e4-45f8-9423-600124abdaf6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("03ca09b7-720f-43e5-a0b8-cb4b6d3df2cd"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0cc535e8-2e97-493c-ac03-716e474171c5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0fef58b0-8b2a-45b7-8561-f91dc8bee0eb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("28ef22a2-bb0c-4b7e-8b9d-98d5d0b93df5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("405bcb50-d6c3-466d-8c56-cb24579b8753"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("485460cc-d7a4-49df-98d3-573b23a62f91"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("49265fa9-7b4b-40ee-88ee-d32ea1525ca9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4b188100-241a-4d6b-806d-b852935c2588"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("69acfb47-042b-4025-bd3d-63f5c5d66705"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6b34fe96-6462-4326-8f94-25449064213c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("818a63b6-3b51-4328-a94e-3cc4372bb81f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8bcc6027-0bb8-4467-93ce-d6d53f232e7b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("91a47c1f-7f23-4017-a85f-d50e8d95fcff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9f90e8a7-e76a-40f4-a1f9-e42bbdbbcf00"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a9bea257-136a-4692-abdc-4d2e2a6faeea"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b6b21e83-8016-4f63-ac78-c9b33610742b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bc823b15-a365-42df-9525-7e506c4c81f4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c3996d99-c7fb-4796-a9b3-b02f7ed3e0aa"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cbe5c04c-5ea7-46c6-8f09-e434b97c4165"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d7752749-148f-4584-8283-dae959dc5d8a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dc8ed7c9-c20f-4560-a670-083e1431fb4e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("deb96481-f35e-4056-b2fb-70b27e1d9fe9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ebf5f117-b292-47c4-b357-c557f6fa6041"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f8dafd25-ab70-475d-b563-027562a6bf9a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("fcc9b083-a964-46ca-a7dc-1eac8fe2b909"));

            migrationBuilder.DeleteData(
                table: "PitchPrice",
                keyColumn: "Id",
                keyValue: new Guid("6ffe4b4f-e0a4-497b-b65d-22225b9ac29b"));

            migrationBuilder.DropColumn(
                name: "BusinessCategoryId",
                table: "BusinessPitch");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("05747381-6023-4ac3-ac89-0236b3431f9e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1862), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1863), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("21feea10-65a7-4fd3-8402-0df8ece8baf5"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1892), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1892), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("2229e98f-7e89-4c38-914b-d6ac8aaca23c"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1879), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1879), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("3d63c319-aba3-41cc-8d3c-5239cc0aae40"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1859), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1860), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("4476c4a3-3379-4e1e-b1d3-9cddb6724b5d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1855), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1855), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("5107ef93-27a4-4582-88ea-7ea43fa6ad9f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1889), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1889), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("577d780f-3268-4149-99d4-6da02c67fa43"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1916), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1916), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("69a84fc1-8917-4ea4-bedc-bf3fa35f47be"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1940), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1940), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("7371ef9a-23ba-46d6-883c-ddd3d5d981ce"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1931), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1931), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("77f562ca-543d-43d0-9c7a-9e9fa56a7c33"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1876), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1876), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("7a3f5895-90a8-4a03-89b9-5d5965c82079"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1886), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1886), null, false, "Craft Mastery Award", false, null },
                    { new Guid("7bcd1cc5-c56d-4e98-b4d4-48888b68c5ac"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1928), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1928), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("81f049d2-da45-4b54-b5bb-e7c42b55aec8"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1922), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1922), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("83a557f0-eb37-493d-8c8f-254bfbe1d247"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1866), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1866), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("86ef0375-d1aa-419b-99fb-f685aa2d14b4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1919), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("8ba3c5f5-0421-4e60-9bb1-238c1e9cb17b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1901), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1901), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("9cd9cae1-1806-4671-9118-49cb1f971e66"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1913), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("9d85dc7c-1fe7-4228-852c-3df4f6b04125"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1933), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1934), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("d17b98cc-f5aa-4874-a5ee-84e4be26085d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1759), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1762), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("d3dab2e7-baa9-4b29-9d3a-6c16afc837cb"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1898), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1898), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("da2821f6-cacb-4e4c-b3e3-267a52651c76"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1895), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("e3af6b4f-a76b-4972-8afe-f67654320ce4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1873), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1873), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("e971430e-c11a-44a1-8626-0f93c04ab964"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1904), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1904), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("f4ae9154-caa6-4a38-a48f-b4a826ffd662"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1907), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1907), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("f68f6faf-7bc5-44ad-bee9-af470675874a"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1925), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1925), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("f841fbbf-0c09-48dc-b188-0d6fea189cd4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1869), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(1870), null, false, "Most Creative Baker", false, null }
                });

            migrationBuilder.InsertData(
                table: "PitchPrice",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Price", "UpdatedBy" },
                values: new object[] { new Guid("aec9d2e1-d4ce-4c09-a55a-09ec81f0a3f3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(2200), new DateTime(2025, 8, 26, 10, 3, 42, 356, DateTimeKind.Utc).AddTicks(2200), null, false, 15000m, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("05747381-6023-4ac3-ac89-0236b3431f9e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21feea10-65a7-4fd3-8402-0df8ece8baf5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2229e98f-7e89-4c38-914b-d6ac8aaca23c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3d63c319-aba3-41cc-8d3c-5239cc0aae40"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4476c4a3-3379-4e1e-b1d3-9cddb6724b5d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5107ef93-27a4-4582-88ea-7ea43fa6ad9f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("577d780f-3268-4149-99d4-6da02c67fa43"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("69a84fc1-8917-4ea4-bedc-bf3fa35f47be"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7371ef9a-23ba-46d6-883c-ddd3d5d981ce"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("77f562ca-543d-43d0-9c7a-9e9fa56a7c33"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7a3f5895-90a8-4a03-89b9-5d5965c82079"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7bcd1cc5-c56d-4e98-b4d4-48888b68c5ac"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("81f049d2-da45-4b54-b5bb-e7c42b55aec8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("83a557f0-eb37-493d-8c8f-254bfbe1d247"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("86ef0375-d1aa-419b-99fb-f685aa2d14b4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8ba3c5f5-0421-4e60-9bb1-238c1e9cb17b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9cd9cae1-1806-4671-9118-49cb1f971e66"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9d85dc7c-1fe7-4228-852c-3df4f6b04125"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d17b98cc-f5aa-4874-a5ee-84e4be26085d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d3dab2e7-baa9-4b29-9d3a-6c16afc837cb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("da2821f6-cacb-4e4c-b3e3-267a52651c76"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e3af6b4f-a76b-4972-8afe-f67654320ce4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e971430e-c11a-44a1-8626-0f93c04ab964"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4ae9154-caa6-4a38-a48f-b4a826ffd662"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f68f6faf-7bc5-44ad-bee9-af470675874a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f841fbbf-0c09-48dc-b188-0d6fea189cd4"));

            migrationBuilder.DeleteData(
                table: "PitchPrice",
                keyColumn: "Id",
                keyValue: new Guid("aec9d2e1-d4ce-4c09-a55a-09ec81f0a3f3"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessCategoryId",
                table: "BusinessPitch",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("01c6e045-09e4-45f8-9423-600124abdaf6"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7142), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("03ca09b7-720f-43e5-a0b8-cb4b6d3df2cd"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7149), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7149), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("0cc535e8-2e97-493c-ac03-716e474171c5"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7124), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7124), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("0fef58b0-8b2a-45b7-8561-f91dc8bee0eb"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7156), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7157), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("28ef22a2-bb0c-4b7e-8b9d-98d5d0b93df5"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7178), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7178), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("405bcb50-d6c3-466d-8c56-cb24579b8753"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7116), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7116), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("485460cc-d7a4-49df-98d3-573b23a62f91"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7162), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7163), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("49265fa9-7b4b-40ee-88ee-d32ea1525ca9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7077), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7079), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("4b188100-241a-4d6b-806d-b852935c2588"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7180), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7181), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("69acfb47-042b-4025-bd3d-63f5c5d66705"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7144), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("6b34fe96-6462-4326-8f94-25449064213c"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7175), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7176), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("818a63b6-3b51-4328-a94e-3cc4372bb81f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7193), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7193), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("8bcc6027-0bb8-4467-93ce-d6d53f232e7b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7139), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("91a47c1f-7f23-4017-a85f-d50e8d95fcff"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7170), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7171), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("9f90e8a7-e76a-40f4-a1f9-e42bbdbbcf00"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7119), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("a9bea257-136a-4692-abdc-4d2e2a6faeea"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7152), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("b6b21e83-8016-4f63-ac78-c9b33610742b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7191), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7191), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("bc823b15-a365-42df-9525-7e506c4c81f4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7168), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7168), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("c3996d99-c7fb-4796-a9b3-b02f7ed3e0aa"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7121), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7121), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("cbe5c04c-5ea7-46c6-8f09-e434b97c4165"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7188), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7189), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("d7752749-148f-4584-8283-dae959dc5d8a"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7154), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7154), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("dc8ed7c9-c20f-4560-a670-083e1431fb4e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7173), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7173), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("deb96481-f35e-4056-b2fb-70b27e1d9fe9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7126), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7127), null, false, "Most Creative Baker", false, null },
                    { new Guid("ebf5f117-b292-47c4-b357-c557f6fa6041"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7165), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7166), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("f8dafd25-ab70-475d-b563-027562a6bf9a"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7186), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7186), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("fcc9b083-a964-46ca-a7dc-1eac8fe2b909"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7147), null, false, "Craft Mastery Award", false, null }
                });

            migrationBuilder.InsertData(
                table: "PitchPrice",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Price", "UpdatedBy" },
                values: new object[] { new Guid("6ffe4b4f-e0a4-497b-b65d-22225b9ac29b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7423), new DateTime(2025, 8, 16, 14, 3, 5, 360, DateTimeKind.Utc).AddTicks(7424), null, false, 15000m, null });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPitch_BusinessCategoryId",
                table: "BusinessPitch",
                column: "BusinessCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPitch_Category_BusinessCategoryId",
                table: "BusinessPitch",
                column: "BusinessCategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
