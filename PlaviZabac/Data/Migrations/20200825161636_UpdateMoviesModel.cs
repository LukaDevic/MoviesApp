using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaviZabac.Data.Migrations
{
    public partial class UpdateMoviesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Filmovi_ProdavnicaId",
                table: "Filmovi",
                column: "ProdavnicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmovi_Prodavnice_ProdavnicaId",
                table: "Filmovi",
                column: "ProdavnicaId",
                principalTable: "Prodavnice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmovi_Prodavnice_ProdavnicaId",
                table: "Filmovi");

            migrationBuilder.DropIndex(
                name: "IX_Filmovi_ProdavnicaId",
                table: "Filmovi");
        }
    }
}
