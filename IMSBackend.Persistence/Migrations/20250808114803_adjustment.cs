using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class adjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Payments_PaymentId",
                table: "Votes");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("001e206c-e584-47d0-9c7b-3eeee824fd2f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("03679c8f-10ae-4006-a502-8283baf4e0fc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("19e03f10-8ea5-440c-89fc-6d5cc989a2ed"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4ad60ec4-406c-4d7e-9a1d-d9a4db0e4096"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("624c7db4-cfbb-48a1-a01a-253a4057a02c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("656e1364-ce03-4222-9812-7378d357ac1f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6c27d4b1-7d4c-4e44-b81e-ddb8054026a2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("757e6f2f-058e-4d66-bf08-ddeed65a0d0b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7b0886f7-b822-461b-8848-01063007d366"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("82cb1716-99da-438a-8d2c-38273e68ce8f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("96482c93-b1c9-4f65-9978-e222c9f33121"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("99a933f3-3331-4e42-a722-b64fd0d2c75b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9a9fcd29-96c2-4dae-a1cf-f13a9b76a1ce"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a08a4187-1db3-4506-9216-183f930bba14"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3e227b7-1bc3-4a54-8f45-984ad0925d8b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cb40ec30-6ab4-4809-9915-878877b73434"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dc9ce812-052c-4f32-9bb5-db64dd8d80da"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e2ab5d97-7170-4802-8975-c6bb00b29f04"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e38bd9ed-8879-4e28-9401-5e7e4a4a2d13"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e557d476-d8d5-434f-9d46-52a9db984879"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e8f0d27b-439a-4fa3-8f95-b89783029472"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ea5680cd-6f2b-47b2-9206-f1edb4574149"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("eb94aff6-00e0-4318-a627-d9e905103a74"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4241592-c258-4a9a-9852-2e9d52aadc28"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4af0081-d875-4bd6-9ace-0daad09f47bf"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f98c63d7-8387-4f2d-a068-def29a70df5d"));

            migrationBuilder.DeleteData(
                table: "PitchPrice",
                keyColumn: "Id",
                keyValue: new Guid("f284f91a-601e-4110-a5c6-6b7495503caa"));

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentId",
                table: "Votes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Payments_PaymentId",
                table: "Votes",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Payments_PaymentId",
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

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentId",
                table: "Votes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Award", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "Pitch", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("001e206c-e584-47d0-9c7b-3eeee824fd2f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7093), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7094), null, false, "Textile Manufacturing Brand of the Year", false, null },
                    { new Guid("03679c8f-10ae-4006-a502-8283baf4e0fc"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7152), null, false, "Brand Evolution Excellence Award", false, null },
                    { new Guid("19e03f10-8ea5-440c-89fc-6d5cc989a2ed"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7062), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7062), null, false, "Top Rated, Event Catering Brand", false, null },
                    { new Guid("4ad60ec4-406c-4d7e-9a1d-d9a4db0e4096"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7111), null, false, "Best Emerging Entrepreneur of the Year", false, null },
                    { new Guid("624c7db4-cfbb-48a1-a01a-253a4057a02c"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7011), null, false, "Outstanding Quality Hair Entrepreneur of the Year", false, null },
                    { new Guid("656e1364-ce03-4222-9812-7378d357ac1f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6946), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6947), null, false, "Outstanding Fashion Entrepreneur of the Year", false, null },
                    { new Guid("6c27d4b1-7d4c-4e44-b81e-ddb8054026a2"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7086), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7087), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", false, null },
                    { new Guid("757e6f2f-058e-4d66-bf08-ddeed65a0d0b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7105), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7106), null, false, "Fabric Vendor of the Year", false, null },
                    { new Guid("7b0886f7-b822-461b-8848-01063007d366"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7055), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7055), null, false, "Creative Bridal Hairstylist of the Year", false, null },
                    { new Guid("82cb1716-99da-438a-8d2c-38273e68ce8f"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6863), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6869), null, false, "African Women’s Fashion Talent of the Year", false, null },
                    { new Guid("96482c93-b1c9-4f65-9978-e222c9f33121"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7047), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7048), null, false, "Best Emerging Food brand of the year", false, null },
                    { new Guid("99a933f3-3331-4e42-a722-b64fd0d2c75b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7122), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7123), null, false, "Outstanding Full-Service Beauty SPA", false, null },
                    { new Guid("9a9fcd29-96c2-4dae-a1cf-f13a9b76a1ce"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6961), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6962), null, false, "Outstanding Beverage Brand of the Year", false, null },
                    { new Guid("a08a4187-1db3-4506-9216-183f930bba14"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6967), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6968), null, false, "Top Rated, Dessert and Finger Food", false, null },
                    { new Guid("a3e227b7-1bc3-4a54-8f45-984ad0925d8b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6954), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6955), null, false, "Beauty and Personal Care Entrepreneur of the Year", false, null },
                    { new Guid("cb40ec30-6ab4-4809-9915-878877b73434"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6998), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6998), null, false, "Most Innovative Product of the Year", false, null },
                    { new Guid("dc9ce812-052c-4f32-9bb5-db64dd8d80da"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7016), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7017), null, false, "Craft Mastery Award", false, null },
                    { new Guid("e2ab5d97-7170-4802-8975-c6bb00b29f04"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7080), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7081), null, false, "Outstanding Female Fashion Designer of the Year", false, null },
                    { new Guid("e38bd9ed-8879-4e28-9401-5e7e4a4a2d13"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7146), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7147), null, false, "Health and Wellness Brand of the Year", false, null },
                    { new Guid("e557d476-d8d5-434f-9d46-52a9db984879"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7004), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7004), null, false, "Best Indigenous Snack brand", false, null },
                    { new Guid("e8f0d27b-439a-4fa3-8f95-b89783029472"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7067), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7068), null, false, "Fastest Growing Perfume Business", false, null },
                    { new Guid("ea5680cd-6f2b-47b2-9206-f1edb4574149"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7135), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7135), null, false, "Media and Entertainment Brand of the Year", false, null },
                    { new Guid("eb94aff6-00e0-4318-a627-d9e905103a74"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7141), null, false, "Creative Branding and Printing Excellence", false, null },
                    { new Guid("f4241592-c258-4a9a-9852-2e9d52aadc28"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6973), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(6974), null, false, "Most Creative Baker", false, null },
                    { new Guid("f4af0081-d875-4bd6-9ace-0daad09f47bf"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7116), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7117), null, false, "Best Emerging Fashion Retail Brand of the Year", false, null },
                    { new Guid("f98c63d7-8387-4f2d-a068-def29a70df5d"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7099), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7100), null, false, "Outstanding Female Entrepreneur of the Year", false, null }
                });

            migrationBuilder.InsertData(
                table: "PitchPrice",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Price", "UpdatedBy" },
                values: new object[] { new Guid("f284f91a-601e-4110-a5c6-6b7495503caa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 8, 8, 11, 12, 1, 730, DateTimeKind.Utc).AddTicks(7701), null, false, 15000m, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Payments_PaymentId",
                table: "Votes",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
