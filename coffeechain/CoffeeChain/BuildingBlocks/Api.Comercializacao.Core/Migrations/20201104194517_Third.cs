using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SituacaoSolicitacao",
                table: "SolicitacaoVenda",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusSolicitacao",
                table: "SolicitacaoVenda",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SituacaoSolicitacao",
                table: "SolicitacaoVenda");

            migrationBuilder.DropColumn(
                name: "StatusSolicitacao",
                table: "SolicitacaoVenda");
        }
    }
}
