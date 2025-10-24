using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dinerticket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "DinnerTickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinnerTickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00edfb3d-e7de-4c63-83bd-39218de22bb6"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3034), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3034), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("0760a065-69ad-434c-97c2-4a479a2aaae9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3085), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3086), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("133f1911-9f84-4d27-b77d-bcb5c7bd7cd9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2987), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2988), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("2d713b6c-ee2a-45a3-8832-3db157cebc83"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3049), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3050), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("4386cc6a-03c8-48b8-8286-239e6131ded2"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3044), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3045), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("529cd1dc-c66c-4e99-92ba-58530e787b3d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3076), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3077), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("57e00e4d-eaa6-452e-9c7d-a5662b38621f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2983), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2984), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("5b3a07bd-9549-4137-a56e-7bbb207e8c3f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3100), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3101), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("5faf92c6-5437-4242-90e9-cebc83ffada6"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3005), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3005), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("7f9e8e49-518c-4359-ae1b-6e70fec36b99"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3117), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3118), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("8390e87f-2d7b-49b5-9071-f4385d21b51d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3054), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3054), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("847e4009-4eff-434f-9312-2383d2aa3988"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3105), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3106), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("875aca65-ecc6-46f8-bd00-a90e6c1ac035"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3025), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3025), null, false, "Craft Mastery Award", false, null },
                    { new Guid("9a069e76-4f82-49fc-a369-4f66cc69d3ad"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3090), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3091), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("9cd50e90-c54e-41b6-bdde-1ee072d589c9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3010), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3011), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("a3f8d09a-cba2-4689-b2bc-b7fa38bd65ff"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3095), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3096), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("aa71ad01-314a-4f7e-9ab7-bc1239aab10a"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3080), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3081), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("ad405f2a-9868-4feb-894c-aef942da9693"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3069), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3070), null, false, "Outstanding Female Entrepreneur of the Year", false, null },
                    { new Guid("b1bf7036-c277-4e22-9000-19b571e80cda"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2993), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2993), null, false, "Most Creative Baker", false, null },
                    { new Guid("c08c7672-1968-4ccc-a198-4020db94fdf0"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3039), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3040), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("c0a66cec-3d73-43d0-af44-20c0e9b8d67e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3029), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3030), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("cbf1ceea-aff3-4992-8be4-fb4c119b73fe"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2977), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2978), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("d906704e-a7fb-4b17-8d81-8f10ddfe1ed7"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2970), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2970), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("e1155b2c-7125-42a5-90d3-3bb321d788af"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2999), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3000), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("f18d9f37-7cf3-48e2-90a4-1294ea53b50d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3059), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(3059), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("f59a7a9d-677f-47db-ab11-24881bdeb5e9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2842), new DateTime(2025, 9, 2, 15, 50, 47, 538, DateTimeKind.Utc).AddTicks(2848), null, false, "African Women’s Fashion Talent of the Year", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DinnerTickets");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("00edfb3d-e7de-4c63-83bd-39218de22bb6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0760a065-69ad-434c-97c2-4a479a2aaae9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("133f1911-9f84-4d27-b77d-bcb5c7bd7cd9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2d713b6c-ee2a-45a3-8832-3db157cebc83"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4386cc6a-03c8-48b8-8286-239e6131ded2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("529cd1dc-c66c-4e99-92ba-58530e787b3d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("57e00e4d-eaa6-452e-9c7d-a5662b38621f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5b3a07bd-9549-4137-a56e-7bbb207e8c3f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5faf92c6-5437-4242-90e9-cebc83ffada6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7f9e8e49-518c-4359-ae1b-6e70fec36b99"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8390e87f-2d7b-49b5-9071-f4385d21b51d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("847e4009-4eff-434f-9312-2383d2aa3988"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("875aca65-ecc6-46f8-bd00-a90e6c1ac035"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9a069e76-4f82-49fc-a369-4f66cc69d3ad"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9cd50e90-c54e-41b6-bdde-1ee072d589c9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3f8d09a-cba2-4689-b2bc-b7fa38bd65ff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("aa71ad01-314a-4f7e-9ab7-bc1239aab10a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ad405f2a-9868-4feb-894c-aef942da9693"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b1bf7036-c277-4e22-9000-19b571e80cda"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c08c7672-1968-4ccc-a198-4020db94fdf0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c0a66cec-3d73-43d0-af44-20c0e9b8d67e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cbf1ceea-aff3-4992-8be4-fb4c119b73fe"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d906704e-a7fb-4b17-8d81-8f10ddfe1ed7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e1155b2c-7125-42a5-90d3-3bb321d788af"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f18d9f37-7cf3-48e2-90a4-1294ea53b50d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f59a7a9d-677f-47db-ab11-24881bdeb5e9"));

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
    }
}
