using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class awardandpitchcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("007310b9-2bb9-48fe-9e3a-883d20b0f6b6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3f18f9c9-f9ea-4bce-83b5-d0873bf53dda"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4130c9ea-b535-4a72-bd59-10e05eaac9e6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4631ab50-7a2e-4e3d-9a84-0542bc957c73"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463a4643-033b-4430-baba-088feea18fe3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("478b3358-5565-45af-88ae-7ca62f608fd8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4fe046c9-bcc1-4a19-a1a0-a50a55369bfb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5a4e2bb6-e672-4075-94a0-031220a3c499"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("64e5d723-9f71-4063-a4e8-099b9b992410"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("86c34bdd-1b48-4128-8a23-2b6bc4c6044a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("86de2dbc-d9d5-4db8-8e96-1cacf6db18c2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8a8e1816-1a7a-4a9a-b05c-277653ef4345"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8dc601dc-8852-4ac6-859f-671efd63ce54"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("adb652e7-d1c4-4119-ad2e-e9006c5c152e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("aeb7dc78-8082-4dd1-91a0-b204b2a3b78f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b1a1e6b3-2a1f-406d-855e-009023eb329f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b6002b1d-dd17-473e-a7fe-3199f700be5e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b6105429-5ce9-4415-8298-83dec1dce4d8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b700bfc7-2c07-4b5f-b639-0e8ac82e483a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d2b2c896-0aa3-4364-9db5-68afe5e5b7ec"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d7f2d0aa-4ee6-4b66-ada8-c434279a91fd"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d9d26d19-7927-4bf0-8001-84049f06c900"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dc7b36ac-5cf8-4c4d-bf98-9c515a7e63ff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e885efa5-6022-49a8-84c4-ea9d1eea2f86"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e892977d-9575-4c42-9f6f-d72534568ae7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e9867b49-07d8-475a-98ad-fa8380669695"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Nominees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Award",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Pitch",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "BusinessPitch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnersPicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessPitch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessPitch_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessPitch_Category_BusinessCategoryId",
                        column: x => x.BusinessCategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PitchPrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitchPrice", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPitch_AccountId",
                table: "BusinessPitch",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPitch_BusinessCategoryId",
                table: "BusinessPitch",
                column: "BusinessCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessPitch");

            migrationBuilder.DropTable(
                name: "PitchPrice");

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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Nominees");

            migrationBuilder.DropColumn(
                name: "Award",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Pitch",
                table: "Category");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("007310b9-2bb9-48fe-9e3a-883d20b0f6b6"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6206), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6206), null, false, "Media and Entertainment Brand of the Year", null },
                    { new Guid("3f18f9c9-f9ea-4bce-83b5-d0873bf53dda"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6199), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6199), null, false, "Fabric Vendor of the Year", null },
                    { new Guid("4130c9ea-b535-4a72-bd59-10e05eaac9e6"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6171), null, false, "Most Creative Baker", null },
                    { new Guid("4631ab50-7a2e-4e3d-9a84-0542bc957c73"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6207), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6208), null, false, "Creative Branding and Printing Excellence", null },
                    { new Guid("463a4643-033b-4430-baba-088feea18fe3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6167), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6167), null, false, "Outstanding Beverage Brand of the Year", null },
                    { new Guid("478b3358-5565-45af-88ae-7ca62f608fd8"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6182), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6183), null, false, "Best Emerging Food brand of the year", null },
                    { new Guid("4fe046c9-bcc1-4a19-a1a0-a50a55369bfb"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6197), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6197), null, false, "Outstanding Female Entrepreneur of the Year", null },
                    { new Guid("5a4e2bb6-e672-4075-94a0-031220a3c499"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6191), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6191), null, false, "Outstanding Fenalr Entrepreneur in Agro-Retail", null },
                    { new Guid("64e5d723-9f71-4063-a4e8-099b9b992410"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6181), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6181), null, false, "Craft Mastery Award", null },
                    { new Guid("86c34bdd-1b48-4128-8a23-2b6bc4c6044a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6162), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6163), null, false, "Outstanding Fashion Entrepreneur of the Year", null },
                    { new Guid("86de2dbc-d9d5-4db8-8e96-1cacf6db18c2"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6169), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6169), null, false, "Top Rated, Dessert and Finger Food", null },
                    { new Guid("8a8e1816-1a7a-4a9a-b05c-277653ef4345"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6175), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6175), null, false, "Best Indigenous Snack brand", null },
                    { new Guid("8dc601dc-8852-4ac6-859f-671efd63ce54"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6204), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6204), null, false, "Outstanding Full-Service Beauty SPA", null },
                    { new Guid("adb652e7-d1c4-4119-ad2e-e9006c5c152e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6209), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6209), null, false, "Health and Wellness Brand of the Year", null },
                    { new Guid("aeb7dc78-8082-4dd1-91a0-b204b2a3b78f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6202), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6202), null, false, "Best Emerging Fashion Retail Brand of the Year", null },
                    { new Guid("b1a1e6b3-2a1f-406d-855e-009023eb329f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6177), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6177), null, false, "Outstanding Quality Hair Entrepreneur of the Year", null },
                    { new Guid("b6002b1d-dd17-473e-a7fe-3199f700be5e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6186), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6186), null, false, "Top Rated, Event Catering Brand", null },
                    { new Guid("b6105429-5ce9-4415-8298-83dec1dce4d8"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6193), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6193), null, false, "Textile Manufacturing Brand of the Year", null },
                    { new Guid("b700bfc7-2c07-4b5f-b639-0e8ac82e483a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6184), null, false, "Creative Bridal Hairstylist of the Year", null },
                    { new Guid("d2b2c896-0aa3-4364-9db5-68afe5e5b7ec"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6173), null, false, "Most Innovative Product of the Year", null },
                    { new Guid("d7f2d0aa-4ee6-4b66-ada8-c434279a91fd"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6165), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6165), null, false, "Beauty and Personal Care Entrepreneur of the Year", null },
                    { new Guid("d9d26d19-7927-4bf0-8001-84049f06c900"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6187), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6188), null, false, "Fastest Growing Perfume Business", null },
                    { new Guid("dc7b36ac-5cf8-4c4d-bf98-9c515a7e63ff"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6200), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6201), null, false, "Best Emerging Entrepreneur of the Year", null },
                    { new Guid("e885efa5-6022-49a8-84c4-ea9d1eea2f86"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6189), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6189), null, false, "Outstanding Female Fashion Designer of the Year", null },
                    { new Guid("e892977d-9575-4c42-9f6f-d72534568ae7"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6087), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6089), null, false, "African Women’s Fashion Talent of the Year", null },
                    { new Guid("e9867b49-07d8-475a-98ad-fa8380669695"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6213), new DateTime(2025, 8, 7, 11, 53, 21, 908, DateTimeKind.Utc).AddTicks(6213), null, false, "Brand Evolution Excellence Award", null }
                });
        }
    }
}
