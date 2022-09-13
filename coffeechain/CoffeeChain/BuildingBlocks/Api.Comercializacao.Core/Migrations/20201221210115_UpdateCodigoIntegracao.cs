using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class UpdateCodigoIntegracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoIntegracao",
                table: "TermoContratoCafe",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoIntegracao",
                table: "ContratoCafeSaida",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoIntegracao",
                table: "ContratoCafeEntrada",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoIntegracao",
                table: "ContratoCafeDerivativo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoIntegracao",
                table: "TermoContratoCafe");

            migrationBuilder.DropColumn(
                name: "CodigoIntegracao",
                table: "ContratoCafeSaida");

            migrationBuilder.DropColumn(
                name: "CodigoIntegracao",
                table: "ContratoCafeEntrada");

            migrationBuilder.DropColumn(
                name: "CodigoIntegracao",
                table: "ContratoCafeDerivativo");
        }
    }
}
