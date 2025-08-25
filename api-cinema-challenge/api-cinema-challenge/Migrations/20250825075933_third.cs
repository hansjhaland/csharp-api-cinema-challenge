using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8594), new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8800), new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8800) });
        }
    }
}
