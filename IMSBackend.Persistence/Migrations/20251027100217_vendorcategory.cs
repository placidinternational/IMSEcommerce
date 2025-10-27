using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class vendorcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_VendorCategories_CategoryId",
                table: "Vendors");

            migrationBuilder.DropTable(
                name: "VendorCategories");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_CategoryId",
                table: "Vendors");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Vendors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Vendors",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "VendorCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_CategoryId",
                table: "Vendors",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_VendorCategories_CategoryId",
                table: "Vendors",
                column: "CategoryId",
                principalTable: "VendorCategories",
                principalColumn: "Id");
        }
    }
}
