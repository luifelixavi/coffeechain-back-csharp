using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelefoneAgronomo",
                table: "SolicitacaoVenda",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<bool>(
                name: "Bloqueado",
                table: "SolicitacaoVenda",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelefoneAgronomo",
                table: "SolicitacaoVenda",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Bloqueado",
                table: "SolicitacaoVenda",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
