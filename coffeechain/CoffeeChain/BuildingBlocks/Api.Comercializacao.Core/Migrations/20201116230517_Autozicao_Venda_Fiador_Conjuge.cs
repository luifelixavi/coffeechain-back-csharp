using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class Autozicao_Venda_Fiador_Conjuge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConjugeId",
                table: "AutorizacaoVendaFiador",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NomeConjuge",
                table: "AutorizacaoVendaFiador",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConjugeId",
                table: "AutorizacaoVendaFiador");

            migrationBuilder.DropColumn(
                name: "NomeConjuge",
                table: "AutorizacaoVendaFiador");
        }
    }
}
