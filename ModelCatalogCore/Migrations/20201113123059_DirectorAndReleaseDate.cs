using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelCatalogCore.Migrations
{
    public partial class DirectorAndReleaseDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(type: "VARCHAR(50) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Director_DirectorId",
                table: "Movies",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Director_DirectorId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");
        }
    }
}
