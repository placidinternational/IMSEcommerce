using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class nominee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7de6ff55-9bf9-4eda-8b79-dbf2fd9d21d9"));

            migrationBuilder.CreateTable(
                name: "Nominees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomineeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nominees_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nominees_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[] { new Guid("25f38329-554c-4345-909b-1154224722dc"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 5, 22, 22, 51, 153, DateTimeKind.Utc).AddTicks(44), new DateTime(2025, 8, 5, 22, 22, 51, 153, DateTimeKind.Utc).AddTicks(48), null, false, "Technology", null });

            migrationBuilder.CreateIndex(
                name: "IX_Nominees_AccountId",
                table: "Nominees",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Nominees_CategoryId",
                table: "Nominees",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nominees");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("25f38329-554c-4345-909b-1154224722dc"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[] { new Guid("7de6ff55-9bf9-4eda-8b79-dbf2fd9d21d9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 5, 22, 11, 34, 85, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 8, 5, 22, 11, 34, 85, DateTimeKind.Utc).AddTicks(5700), null, false, "Technology", null });
        }
    }
}
