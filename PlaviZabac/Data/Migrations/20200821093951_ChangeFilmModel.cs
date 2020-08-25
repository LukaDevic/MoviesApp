using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaviZabac.Data.Migrations
{
    public partial class ChangeFilmModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DostupnaKolicina",
                table: "Filmovi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "DostupnaKolicina",
                table: "Filmovi",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
