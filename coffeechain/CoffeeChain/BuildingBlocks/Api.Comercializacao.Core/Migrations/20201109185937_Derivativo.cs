using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class Derivativo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificacaCafe",
                table: "ModalidadeCafeEP");

            migrationBuilder.AddColumn<int>(
                name: "CertificacaoCafeId",
                table: "ModalidadeCafeEP",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BancoId",
                table: "ContratoCafeDerivativo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NomeBanco",
                table: "ContratoCafeDerivativo",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadeCafeEP_CertificacaoCafeId",
                table: "ModalidadeCafeEP",
                column: "CertificacaoCafeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModalidadeCafeEP_CertificacaoCafe_CertificacaoCafeId",
                table: "ModalidadeCafeEP",
                column: "CertificacaoCafeId",
                principalTable: "CertificacaoCafe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModalidadeCafeEP_CertificacaoCafe_CertificacaoCafeId",
                table: "ModalidadeCafeEP");

            migrationBuilder.DropIndex(
                name: "IX_ModalidadeCafeEP_CertificacaoCafeId",
                table: "ModalidadeCafeEP");

            migrationBuilder.DropColumn(
                name: "CertificacaoCafeId",
                table: "ModalidadeCafeEP");

            migrationBuilder.DropColumn(
                name: "BancoId",
                table: "ContratoCafeDerivativo");

            migrationBuilder.DropColumn(
                name: "NomeBanco",
                table: "ContratoCafeDerivativo");

            migrationBuilder.AddColumn<string>(
                name: "CertificacaCafe",
                table: "ModalidadeCafeEP",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
