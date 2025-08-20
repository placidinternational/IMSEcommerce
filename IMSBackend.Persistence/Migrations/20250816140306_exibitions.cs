using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class exibitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("004c06b7-6cf8-4475-b4e4-8ccd4b98c557"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1c82436d-5509-44ba-97c3-e66cbece2c00"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("30752231-0e4d-4ac9-a2be-e68e4372f24e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3816fe83-286b-4de7-9f59-6224f7ae73c0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4674c7d2-6ca4-42e8-9394-66d7c3aae3c4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5025ab9f-bc92-485a-9696-4da0e8a95a0d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5079fc81-2abf-4206-b212-b96b8925b5b9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("52c9415d-e2d7-40ee-888b-cc600246b4bd"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5919f07e-af23-4dfd-9e73-ab2fe80b1c29"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("82e6d0bb-6f3b-4cd0-9ac3-b3a65f8425a1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("857a9675-92c8-4106-a031-e81a4d083b0b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8bc84fd4-8bd3-430d-acb5-c1d5e819cdac"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9161989f-0a96-4ccd-a484-5f6c56199c24"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9c171568-a796-4a11-923b-038f98b2187a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9cbb4f50-e22f-44df-8dd7-c1b61be46953"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ad183490-1bea-454d-9cc8-1d965d817b24"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bf22a8a2-ef92-4888-a292-68104fdc3218"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d11fc563-2073-4bf9-9564-1ff831cc3f33"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d4e094ce-5ced-4fad-96e1-75e625aedfae"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d721f495-1a34-4465-b6e3-f22bfe0a7baf"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d7fcf8d8-e50a-42ba-8a0a-dcae300a3ea9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d9ba2211-71a1-4439-a4dd-3ee456701146"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("da54d812-f912-4d76-a1dd-92ff5d7f3470"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e56a5161-900a-41dc-95fd-edd1ee309d24"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ef6538b5-9fd6-4cb4-8815-ef39731b8e68"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("fb12fd26-0a33-4520-99e8-785588c27156"));

            migrationBuilder.DeleteData(
                table: "PitchPrice",
                keyColumn: "Id",
                keyValue: new Guid("686202a1-b84a-4094-9e37-634ff6f195a2"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("004c06b7-6cf8-4475-b4e4-8ccd4b98c557"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1905), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("1c82436d-5509-44ba-97c3-e66cbece2c00"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1879), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1879), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("30752231-0e4d-4ac9-a2be-e68e4372f24e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1855), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1855), null, false, "Most Creative Baker", false, null },
                    { new Guid("3816fe83-286b-4de7-9f59-6224f7ae73c0"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1881), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1881), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("4674c7d2-6ca4-42e8-9394-66d7c3aae3c4"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1844), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1845), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("5025ab9f-bc92-485a-9696-4da0e8a95a0d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1898), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1898), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("5079fc81-2abf-4206-b212-b96b8925b5b9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1857), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1857), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("52c9415d-e2d7-40ee-888b-cc600246b4bd"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1850), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1850), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("5919f07e-af23-4dfd-9e73-ab2fe80b1c29"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1893), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1894), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("82e6d0bb-6f3b-4cd0-9ac3-b3a65f8425a1"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1870), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1870), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("857a9675-92c8-4106-a031-e81a4d083b0b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1907), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1907), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("8bc84fd4-8bd3-430d-acb5-c1d5e819cdac"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1886), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1886), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("9161989f-0a96-4ccd-a484-5f6c56199c24"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1916), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("9c171568-a796-4a11-923b-038f98b2187a"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1807), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1809), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("9cbb4f50-e22f-44df-8dd7-c1b61be46953"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1903), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("ad183490-1bea-454d-9cc8-1d965d817b24"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1877), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1877), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("bf22a8a2-ef92-4888-a292-68104fdc3218"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1914), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("d11fc563-2073-4bf9-9564-1ff831cc3f33"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1873), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1873), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("d4e094ce-5ced-4fad-96e1-75e625aedfae"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1847), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1847), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("d721f495-1a34-4465-b6e3-f22bfe0a7baf"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1891), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1891), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("d7fcf8d8-e50a-42ba-8a0a-dcae300a3ea9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1900), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1900), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("d9ba2211-71a1-4439-a4dd-3ee456701146"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1911), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("da54d812-f912-4d76-a1dd-92ff5d7f3470"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1896), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("e56a5161-900a-41dc-95fd-edd1ee309d24"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1875), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1875), null, false, "Craft Mastery Award", false, null },
                    { new Guid("ef6538b5-9fd6-4cb4-8815-ef39731b8e68"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1883), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1884), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("fb12fd26-0a33-4520-99e8-785588c27156"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1852), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(1852), null, false, "Top Rated, Dessert and Finger Food", false, null }
                });

            migrationBuilder.InsertData(
                table: "PitchPrice",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Price", "UpdatedBy" },
                values: new object[] { new Guid("686202a1-b84a-4094-9e37-634ff6f195a2"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(2121), new DateTime(2025, 8, 16, 13, 56, 8, 332, DateTimeKind.Utc).AddTicks(2121), null, false, 15000m, null });
        }
    }
}
