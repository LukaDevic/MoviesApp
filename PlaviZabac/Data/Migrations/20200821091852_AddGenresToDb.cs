using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaviZabac.Data.Migrations
{
    public partial class AddGenresToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmovi_Zanr_ZanrId",
                table: "Filmovi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zanr",
                table: "Zanr");

            migrationBuilder.RenameTable(
                name: "Zanr",
                newName: "Zanrovi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zanrovi",
                table: "Zanrovi",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmovi_Zanrovi_ZanrId",
                table: "Filmovi",
                column: "ZanrId",
                principalTable: "Zanrovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmovi_Zanrovi_ZanrId",
                table: "Filmovi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zanrovi",
                table: "Zanrovi");

            migrationBuilder.RenameTable(
                name: "Zanrovi",
                newName: "Zanr");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zanr",
                table: "Zanr",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmovi_Zanr_ZanrId",
                table: "Filmovi",
                column: "ZanrId",
                principalTable: "Zanr",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
