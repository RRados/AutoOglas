using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppOglas.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automobil",
                columns: table => new
                {
                    idAutomobil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marka = table.Column<string>(maxLength: 50, nullable: false),
                    godiste = table.Column<int>(nullable: false),
                    zapremina_motora = table.Column<int>(nullable: false),
                    snaga = table.Column<int>(nullable: false),
                    gorivo = table.Column<string>(maxLength: 50, nullable: false),
                    karoserija = table.Column<string>(maxLength: 50, nullable: false),
                    fotografija = table.Column<string>(maxLength: 50, nullable: true),
                    opis = table.Column<string>(maxLength: 50, nullable: false),
                    cena = table.Column<int>(nullable: false),
                    kontakt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobil", x => x.idAutomobil);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automobil");
        }
    }
}
