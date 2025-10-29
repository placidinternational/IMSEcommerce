using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "EmaulAddress",
                table: "Customers",
                newName: "EmailAddress");

            migrationBuilder.AddColumn<bool>(
                name: "IsAnonymous",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnonymous",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Customers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Customers",
                newName: "EmaulAddress");
        }
    }
}
