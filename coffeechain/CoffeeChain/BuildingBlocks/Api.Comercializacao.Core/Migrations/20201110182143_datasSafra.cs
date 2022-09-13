using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class datasSafra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DtPagamento",
                table: "SafraComercialFuturo",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DtLimite",
                table: "SafraComercialFuturo",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DtEntrega",
                table: "SafraComercialFuturo",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AddColumn<bool>(
                name: "ContratoAssinado",
                table: "ContratoCafeEntrada",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContratoAssinado",
                table: "ContratoCafeEntrada");

            migrationBuilder.AlterColumn<string>(
                name: "DtPagamento",
                table: "SafraComercialFuturo",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "DtLimite",
                table: "SafraComercialFuturo",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "DtEntrega",
                table: "SafraComercialFuturo",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
