using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class accountmodifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistrationOtps_Nominee_AgentId",
                table: "RegistrationOtps");

            migrationBuilder.DropTable(
                name: "Nominee");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e45306fb-973b-48a4-a764-8a656b7b371b"));

            migrationBuilder.RenameColumn(
                name: "AgentId",
                table: "RegistrationOtps",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_RegistrationOtps_AgentId",
                table: "RegistrationOtps",
                newName: "IX_RegistrationOtps_AccountId");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[] { new Guid("7de6ff55-9bf9-4eda-8b79-dbf2fd9d21d9"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 5, 22, 11, 34, 85, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 8, 5, 22, 11, 34, 85, DateTimeKind.Utc).AddTicks(5700), null, false, "Technology", null });

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrationOtps_Accounts_AccountId",
                table: "RegistrationOtps",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistrationOtps_Accounts_AccountId",
                table: "RegistrationOtps");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7de6ff55-9bf9-4eda-8b79-dbf2fd9d21d9"));

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "RegistrationOtps",
                newName: "AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_RegistrationOtps_AccountId",
                table: "RegistrationOtps",
                newName: "IX_RegistrationOtps_AgentId");

            migrationBuilder.CreateTable(
                name: "Nominee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomineeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nominee_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nominee_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[] { new Guid("e45306fb-973b-48a4-a764-8a656b7b371b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 5, 21, 51, 35, 347, DateTimeKind.Utc).AddTicks(7959), new DateTime(2025, 8, 5, 21, 51, 35, 347, DateTimeKind.Utc).AddTicks(7961), null, false, "Technology", null });

            migrationBuilder.CreateIndex(
                name: "IX_Nominee_AccountId",
                table: "Nominee",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Nominee_CategoryId",
                table: "Nominee",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrationOtps_Nominee_AgentId",
                table: "RegistrationOtps",
                column: "AgentId",
                principalTable: "Nominee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
