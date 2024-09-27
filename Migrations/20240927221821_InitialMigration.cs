using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace depi_real_state_management_system.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RealStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME2", maxLength: 256, nullable: false),
                    Price = table.Column<decimal>(type: "DECIMAL(10,2)", maxLength: 256, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RealStates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RealStates_UserId",
                table: "RealStates",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RealStates");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
