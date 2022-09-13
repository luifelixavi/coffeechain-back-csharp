using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class ContratoCafeSaidaMappinp_SituacaoVinculoTermo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SituacaoVinculoTermo",
                table: "ContratoCafeSaida",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SituacaoVinculoTermo",
                table: "ContratoCafeSaida",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
