using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class SolicitacaoFiadorConjuge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConjugeId",
                table: "SolicitacaoVendaFiador",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NomeConjuge",
                table: "SolicitacaoVendaFiador",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConjugeId",
                table: "SolicitacaoVendaFiador");

            migrationBuilder.DropColumn(
                name: "NomeConjuge",
                table: "SolicitacaoVendaFiador");
        }
    }
}
