using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ISFEATURED : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Vendors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Vendors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Vendors");
        }
    }
}
