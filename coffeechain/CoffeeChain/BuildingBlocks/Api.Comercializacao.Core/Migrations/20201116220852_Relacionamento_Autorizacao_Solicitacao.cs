using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class Relacionamento_Autorizacao_Solicitacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacaoVenda_SolicitacaoVenda_ModalidadeId",
                table: "AutorizacaoVenda");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacaoVenda_SolicitacaoId",
                table: "AutorizacaoVenda",
                column: "SolicitacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacaoVenda_SolicitacaoVenda_SolicitacaoId",
                table: "AutorizacaoVenda",
                column: "SolicitacaoId",
                principalTable: "SolicitacaoVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacaoVenda_SolicitacaoVenda_SolicitacaoId",
                table: "AutorizacaoVenda");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacaoVenda_SolicitacaoId",
                table: "AutorizacaoVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacaoVenda_SolicitacaoVenda_ModalidadeId",
                table: "AutorizacaoVenda",
                column: "ModalidadeId",
                principalTable: "SolicitacaoVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
