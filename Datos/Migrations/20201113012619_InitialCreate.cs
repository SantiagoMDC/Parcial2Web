using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(nullable: false),
                    TipoDeDocumento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(nullable: false),
                    InstitucionEducativa = table.Column<string>(nullable: true),
                    NombreAcudiente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "vacunas",
                columns: table => new
                {
                    Identificacionv = table.Column<string>(nullable: false),
                    TipoDeDocumentov = table.Column<string>(nullable: true),
                    Nombrev = table.Column<string>(nullable: true),
                    FechaDeNacimientov = table.Column<DateTime>(nullable: false),
                    InstitucionEducativav = table.Column<string>(nullable: true),
                    NombreAcudientev = table.Column<string>(nullable: true),
                    NombreVacuna = table.Column<string>(nullable: true),
                    FechaVacuna = table.Column<DateTime>(nullable: false),
                    EdadVacuna = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacunas", x => x.Identificacionv);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "vacunas");
        }
    }
}
