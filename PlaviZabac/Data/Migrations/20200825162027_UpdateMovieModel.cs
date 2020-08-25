using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaviZabac.Data.Migrations
{
    public partial class UpdateMovieModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DodatoDatuma",
                table: "Filmovi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DodatoDatuma",
                table: "Filmovi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
