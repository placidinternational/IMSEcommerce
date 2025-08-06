using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMSBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[] { new Guid("e45306fb-973b-48a4-a764-8a656b7b371b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 5, 21, 51, 35, 347, DateTimeKind.Utc).AddTicks(7959), new DateTime(2025, 8, 5, 21, 51, 35, 347, DateTimeKind.Utc).AddTicks(7961), null, false, "Technology", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e45306fb-973b-48a4-a764-8a656b7b371b"));
        }
    }
}
