using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class solicitacaoFiadorDerivativoUsuarioId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FiadorId",
                table: "SolicitacaoVendaFiador",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "UsuarioId",
            //    table: "ContratoCafeDerivativoMov",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FiadorId",
                table: "AutorizacaoVendaFiador",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FiadorId",
                table: "SolicitacaoVendaFiador",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "UsuarioId",
            //    table: "ContratoCafeDerivativoMov",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "FiadorId",
                table: "AutorizacaoVendaFiador",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
