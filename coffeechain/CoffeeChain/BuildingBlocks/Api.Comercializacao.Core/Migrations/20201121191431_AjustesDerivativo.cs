using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class AjustesDerivativo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcluidoPor",
                table: "ContratoCafeDerivativo",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContratoExportacaoReferencia",
                table: "ContratoCafeDerivativo",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcluidoPor",
                table: "ContratoCafeDerivativo");

            migrationBuilder.DropColumn(
                name: "ContratoExportacaoReferencia",
                table: "ContratoCafeDerivativo");
        }
    }
}
