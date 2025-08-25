using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8594), "nigel@nigel.nigel", "Nigel", "+44729388192", new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8709) },
                    { 2, new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8798), "dave@dave.dave", "Dave", "+44729388180", new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8799) },
                    { 3, new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8800), "walter@white.bb", "Walter", "+44729383492", new DateTime(2025, 8, 25, 7, 55, 18, 39, DateTimeKind.Utc).AddTicks(8800) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
