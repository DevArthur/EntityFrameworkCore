using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace CinemaApp.Migrations
{
    public partial class cinemaubication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema");

            migrationBuilder.RenameTable(
                name: "Cinema",
                newName: "Cinemas");

            migrationBuilder.AddColumn<Point>(
                name: "Ubication",
                table: "Cinemas",
                type: "geography",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "Ubication",
                table: "Cinemas");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "Cinema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema",
                column: "Id");
        }
    }
}
