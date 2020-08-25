using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaviZabac.Data.Migrations
{
    public partial class SmallChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prodavnica",
                table: "Filmovi");

            migrationBuilder.AddColumn<byte>(
                name: "ProdavnicaId",
                table: "Filmovi",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdavnicaId",
                table: "Filmovi");

            migrationBuilder.AddColumn<byte>(
                name: "Prodavnica",
                table: "Filmovi",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
