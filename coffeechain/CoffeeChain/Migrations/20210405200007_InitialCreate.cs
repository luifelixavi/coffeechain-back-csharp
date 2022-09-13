using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeChain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    CNPJEmpresa = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    TelefoneEmpresa = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    EnderecoEmpresa = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CidadeEmpresa = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    UfEmpresa = table.Column<string>(type: "VARCHAR(2)", nullable: true),
                    PaisEmpresa = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    CepEmpresa = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    EmailEmpresa = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "Produtor",
                columns: table => new
                {
                    ProdutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProdutor = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CpfProdutor = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    RgProdutor = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    TelefoneProdutor = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    EnderecoProdutor = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CidadeProdutor = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    UfProdutor = table.Column<string>(type: "VARCHAR(2)", nullable: true),
                    EmailProdutor = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CepProdutor = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtor", x => x.ProdutorId);
                });

            migrationBuilder.CreateTable(
                name: "Armazem",
                columns: table => new
                {
                    ArmazemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    TelefoneArmazem = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    EnderecoArmazem = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    CidadeArmazem = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    UfArmazem = table.Column<string>(type: "VARCHAR(2)", nullable: true),
                    EmailArmazem = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armazem", x => x.ArmazemId);
                    table.ForeignKey(
                        name: "FK_Armazem_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Propriedade",
                columns: table => new
                {
                    PropriedadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutorId = table.Column<int>(type: "int", nullable: false),
                    NomeFazenda = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CNPJFazenda = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    InscEstadual = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    TelefonePropriedade = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    EnderecoPropriedade = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    CidadePropriedade = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    UfPropriedade = table.Column<string>(type: "VARCHAR(2)", nullable: true),
                    EmailPropriedade = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CepPropriedade = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propriedade", x => x.PropriedadeId);
                    table.ForeignKey(
                        name: "FK_Propriedade_Produtor_ProdutorId",
                        column: x => x.ProdutorId,
                        principalTable: "Produtor",
                        principalColumn: "ProdutorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    EntradaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutorId = table.Column<int>(type: "int", nullable: false),
                    PropriedadeId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    ArmazemId = table.Column<int>(type: "int", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "DATE", nullable: false),
                    CodigoLote = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    QtdSacas = table.Column<decimal>(type: "DECIMAL(9)", nullable: false),
                    PrecoLote = table.Column<decimal>(type: "DECIMAL(9)", nullable: false),
                    CustoEntrada = table.Column<decimal>(type: "DECIMAL(9)", nullable: false),
                    NfeEntrada = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    TipoEntrada = table.Column<int>(type: "INTEGER", nullable: false),
                    Safra = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    TipoCafe = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    LocalArmazenado = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    EmbalagemArmazenado = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.EntradaId);
                    table.ForeignKey(
                        name: "FK_Entradas_Armazem_ArmazemId",
                        column: x => x.ArmazemId,
                        principalTable: "Armazem",
                        principalColumn: "ArmazemId");
                    table.ForeignKey(
                        name: "FK_Entradas_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId");
                    table.ForeignKey(
                        name: "FK_Entradas_Produtor_ProdutorId",
                        column: x => x.ProdutorId,
                        principalTable: "Produtor",
                        principalColumn: "ProdutorId");
                    table.ForeignKey(
                        name: "FK_Entradas_Propriedade_PropriedadeId",
                        column: x => x.PropriedadeId,
                        principalTable: "Propriedade",
                        principalColumn: "PropriedadeId");
                });

            migrationBuilder.CreateTable(
                name: "Saidas",
                columns: table => new
                {
                    SaidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinoProdutorId = table.Column<int>(type: "int", nullable: false),
                    DestinoPropriedadeId = table.Column<int>(type: "int", nullable: false),
                    DestinoEmpresaId = table.Column<int>(type: "int", nullable: false),
                    EntradaId = table.Column<int>(type: "int", nullable: false),
                    DestinoArmazemId = table.Column<int>(type: "int", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "DATE", nullable: false),
                    QtdSacas = table.Column<decimal>(type: "DECIMAL(9)", nullable: false),
                    TipoSaida = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecoSaida = table.Column<decimal>(type: "DECIMAL(9)", nullable: false),
                    CustoSaida = table.Column<decimal>(type: "DECIMAL(9)", nullable: false),
                    NfeSaida = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    EmbalagemSaida = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saidas", x => x.SaidaId);
                    table.ForeignKey(
                        name: "FK_Saidas_Armazem_DestinoArmazemId",
                        column: x => x.DestinoArmazemId,
                        principalTable: "Armazem",
                        principalColumn: "ArmazemId");
                    table.ForeignKey(
                        name: "FK_Saidas_Empresa_DestinoEmpresaId",
                        column: x => x.DestinoEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId");
                    table.ForeignKey(
                        name: "FK_Saidas_Entradas_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entradas",
                        principalColumn: "EntradaId");
                    table.ForeignKey(
                        name: "FK_Saidas_Produtor_DestinoProdutorId",
                        column: x => x.DestinoProdutorId,
                        principalTable: "Produtor",
                        principalColumn: "ProdutorId");
                    table.ForeignKey(
                        name: "FK_Saidas_Propriedade_DestinoPropriedadeId",
                        column: x => x.DestinoPropriedadeId,
                        principalTable: "Propriedade",
                        principalColumn: "PropriedadeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armazem_EmpresaId",
                table: "Armazem",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_ArmazemId",
                table: "Entradas",
                column: "ArmazemId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_EmpresaId",
                table: "Entradas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_ProdutorId",
                table: "Entradas",
                column: "ProdutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_PropriedadeId",
                table: "Entradas",
                column: "PropriedadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Propriedade_ProdutorId",
                table: "Propriedade",
                column: "ProdutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_DestinoArmazemId",
                table: "Saidas",
                column: "DestinoArmazemId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_DestinoEmpresaId",
                table: "Saidas",
                column: "DestinoEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_DestinoProdutorId",
                table: "Saidas",
                column: "DestinoProdutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_DestinoPropriedadeId",
                table: "Saidas",
                column: "DestinoPropriedadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_EntradaId",
                table: "Saidas",
                column: "EntradaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saidas");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Armazem");

            migrationBuilder.DropTable(
                name: "Propriedade");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Produtor");
        }
    }
}
