using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaviZabac.Data.Migrations
{
    public partial class addProdavniceToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmovi_Zanrovi_ZanrId",
                table: "Filmovi");

            migrationBuilder.DropIndex(
                name: "IX_Filmovi_ZanrId",
                table: "Filmovi");

            migrationBuilder.AddColumn<byte>(
                name: "Prodavnica",
                table: "Filmovi",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "Prodavnice",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Ime = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodavnice", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prodavnice");

            migrationBuilder.DropColumn(
                name: "Prodavnica",
                table: "Filmovi");

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
    }
}
