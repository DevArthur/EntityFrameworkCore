using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaApp.Migrations
{
    public partial class Film : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    InBillboard = table.Column<bool>(type: "bit", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    PosterURL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
