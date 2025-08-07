using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class paymentandvotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("25f38329-554c-4345-909b-1154224722dc"));

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountExpected = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomineeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VoterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_Nominees_NomineeId",
                        column: x => x.NomineeId,
                        principalTable: "Nominees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Votes_NomineeId",
                table: "Votes",
                column: "NomineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PaymentId",
                table: "Votes",
                column: "PaymentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "Payments");

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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[] { new Guid("25f38329-554c-4345-909b-1154224722dc"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 5, 22, 22, 51, 153, DateTimeKind.Utc).AddTicks(44), new DateTime(2025, 8, 5, 22, 22, 51, 153, DateTimeKind.Utc).AddTicks(48), null, false, "Technology", null });
        }
    }
}
