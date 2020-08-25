using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaviZabac.Data.Migrations
{
    public partial class UpdateFilmoviModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Filmovi_ZanrId",
                table: "Filmovi",
                column: "ZanrId");

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

            migrationBuilder.DropIndex(
                name: "IX_Filmovi_ZanrId",
                table: "Filmovi");
        }
    }
}
