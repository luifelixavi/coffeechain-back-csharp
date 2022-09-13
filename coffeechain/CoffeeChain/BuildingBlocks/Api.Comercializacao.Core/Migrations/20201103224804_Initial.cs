using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocapec.ContratoFuturo.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloqueioVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bloquear = table.Column<string>(type: "varchar(1)", nullable: false),
                    ParceiroNegocioId = table.Column<int>(nullable: false),
                    NomeParceiroNegocio = table.Column<string>(type: "varchar(150)", nullable: false),
                    TipoBloqueio = table.Column<int>(nullable: false),
                    DescricaoBloqueio = table.Column<string>(type: "varchar(100)", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(50)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloqueioVenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificacaoCafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoResumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificacaoCafe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeCafeEP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoResumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    CafeCertificacao = table.Column<string>(type: "varchar(1)", nullable: false),
                    CertificacaCafe = table.Column<string>(nullable: true),
                    TipoEquivalencia = table.Column<int>(nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeCafeEP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeDerivativo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoModalidadeDerivativo = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoResumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeDerivativo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperacaoESContratoCafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoResumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Bloqueado = table.Column<string>(type: "varchar(1)", nullable: false),
                    OperacaoES = table.Column<string>(type: "varchar(1)", nullable: false),
                    OperacaoEntregaCafe = table.Column<string>(type: "varchar(1)", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperacaoESContratoCafe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperacaoESDerivativoCafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoResumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Bloqueado = table.Column<string>(type: "varchar(1)", nullable: false),
                    OperacaoES = table.Column<string>(type: "varchar(1)", nullable: false),
                    OperacaoLiquidacaoTotal = table.Column<string>(type: "varchar(1)", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperacaoESDerivativoCafe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalidadeDerivativo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoFinalidadeDerivativo = table.Column<string>(type: "varchar(100)", nullable: false),
                    ResumoDescricaoFinalidadeDerivativo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalidadeDerivativo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoFinalidadeContrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoFinalidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Resumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    CodRefTipoFinalidade = table.Column<int>(nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoFinalidadeContrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoModalidadeContrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Resumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoModalidadeContrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoMoeda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoMoeda = table.Column<string>(type: "varchar(50)", nullable: false),
                    RotuloMoeda = table.Column<string>(type: "varchar(10)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMoeda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProcessamentoCafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescProcessCafe = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescProcessCafeAbreviacao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProcessamentoCafe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalidadeContratoCafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoResumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoFinalidadeId = table.Column<int>(nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalidadeContratoCafe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalidadeContratoCafe_TipoFinalidadeContrato_TipoFinalidadeId",
                        column: x => x.TipoFinalidadeId,
                        principalTable: "TipoFinalidadeContrato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeDerivativo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefMesId = table.Column<int>(nullable: false),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    SituacaoContrato = table.Column<int>(nullable: false),
                    SituacaoVinculoTermo = table.Column<int>(nullable: false),
                    TipoDerivativo = table.Column<int>(nullable: false),
                    ModalidadeDerivativoId = table.Column<int>(nullable: false),
                    FinalidadeDerivativoId = table.Column<int>(nullable: false),
                    ReferenciaDerCompl = table.Column<int>(nullable: false),
                    TipoOperacaoDerivativo = table.Column<int>(nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    ValorUnitario = table.Column<double>(type: "float", nullable: false),
                    ValorContrato = table.Column<double>(type: "float", nullable: false),
                    TipoMoedaId = table.Column<int>(nullable: false),
                    CotacaoMoeda = table.Column<double>(type: "float", nullable: false),
                    TaxasContratuais = table.Column<double>(type: "float", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    RegistroCETIP = table.Column<int>(nullable: false),
                    DocumentoReferencia = table.Column<string>(type: "varchar(20)", nullable: false),
                    DocumentoBolsaReferencia = table.Column<string>(type: "varchar(20)", nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    VinculadoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeDerivativo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativo_ModalidadeDerivativo_ModalidadeDerivativoId",
                        column: x => x.ModalidadeDerivativoId,
                        principalTable: "ModalidadeDerivativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativo_FinalidadeDerivativo_FinalidadeDerivativoId",
                        column: x => x.FinalidadeDerivativoId,
                        principalTable: "FinalidadeDerivativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativo_TipoMoeda_TipoMoedaId",
                        column: x => x.TipoMoedaId,
                        principalTable: "TipoMoeda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeContratoCafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinalidadeContratoId = table.Column<int>(nullable: false),
                    TipoModalidadeContratoId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoResumo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Bloqueado = table.Column<string>(type: "varchar(1)", nullable: false),
                    DRTRequerProtecaoValor = table.Column<string>(type: "varchar(1)", nullable: false),
                    DRTRequerValorSacaFlex = table.Column<string>(type: "varchar(1)", nullable: false),
                    DRTRequerModalidadeCafeEP = table.Column<string>(type: "varchar(1)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeContratoCafe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModalidadeContratoCafe_FinalidadeContratoCafe_FinalidadeContratoId",
                        column: x => x.FinalidadeContratoId,
                        principalTable: "FinalidadeContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModalidadeContratoCafe_TipoModalidadeContrato_TipoModalidadeContratoId",
                        column: x => x.TipoModalidadeContratoId,
                        principalTable: "TipoModalidadeContrato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeDerivativoMov",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoDerivativoId = table.Column<int>(nullable: false),
                    OperacaoESDerivativoCafeId = table.Column<int>(nullable: false),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    SituacaoMovimento = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DTOperacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DescOperacaoESDerivativoCafe = table.Column<string>(nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    ValorUnitario = table.Column<double>(type: "float", nullable: false),
                    ValorOperacao = table.Column<double>(type: "float", nullable: false),
                    ValorAjusteUnitario = table.Column<double>(type: "float", nullable: false),
                    ValorAjusteOperacao = table.Column<double>(type: "float", nullable: false),
                    RegistroCETIP = table.Column<int>(type: "int", nullable: false),
                    DocumentoCETIPRefer = table.Column<string>(type: "varchar(20)", nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeDerivativoMov", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativoMov_ContratoCafeDerivativo_ContratoDerivativoId",
                        column: x => x.ContratoDerivativoId,
                        principalTable: "ContratoCafeDerivativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativoMov_OperacaoESDerivativoCafe_OperacaoESDerivativoCafeId",
                        column: x => x.OperacaoESDerivativoCafeId,
                        principalTable: "OperacaoESDerivativoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeDerivativoPAD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoDerivativoId = table.Column<int>(nullable: false),
                    DataPosicaoId = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModalidadePosicaoPAD = table.Column<int>(type: "int", nullable: false),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    ValorAjusteUnitario = table.Column<double>(type: "float", nullable: false),
                    ValorAjustePosicao = table.Column<double>(type: "float", nullable: false),
                    ValorAMPosicaoCliente = table.Column<double>(type: "float", nullable: false),
                    ValorAMPosicaoBanco = table.Column<double>(type: "float", nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeDerivativoPAD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativoPAD_ContratoCafeDerivativo_ContratoDerivativoId",
                        column: x => x.ContratoDerivativoId,
                        principalTable: "ContratoCafeDerivativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoDerivativoSaldo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoDerivativoId = table.Column<int>(nullable: false),
                    ExercicioId = table.Column<int>(nullable: false),
                    MesRef = table.Column<int>(type: "int", nullable: false),
                    EntradaQuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    SaidaQuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    SaldoQuantidadeSacas = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoDerivativoSaldo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoDerivativoSaldo_ContratoCafeDerivativo_ContratoDerivativoId",
                        column: x => x.ContratoDerivativoId,
                        principalTable: "ContratoCafeDerivativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SafraComercialFuturo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SafraId = table.Column<int>(nullable: false),
                    Safra = table.Column<string>(type: "varchar(20)", nullable: false),
                    ModalidadeId = table.Column<int>(nullable: false),
                    DtEntrega = table.Column<string>(type: "varchar(20)", nullable: false),
                    DtPagamento = table.Column<string>(type: "varchar(20)", nullable: false),
                    DtLimite = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafraComercialFuturo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SafraComercialFuturo_ModalidadeContratoCafe_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "ModalidadeContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeDerivativoPADHS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PADId = table.Column<int>(nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(150)", nullable: false),
                    ContratoDerivativoId = table.Column<int>(type: "int", nullable: false),
                    DataPosicaoId = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModalidadePosicao = table.Column<int>(type: "int", nullable: false),
                    TimeStampHistoricoId = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    ValorAjusteUnitario = table.Column<double>(type: "float", nullable: false),
                    ValorAjustePosicao = table.Column<double>(type: "float", nullable: false),
                    ValorAMPosicaoCliente = table.Column<double>(type: "float", nullable: false),
                    ValorAMPosicaoBanco = table.Column<double>(type: "float", nullable: false),
                    OrigemLancamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeDerivativoPADHS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativoPADHS_ContratoCafeDerivativoPAD_PADId",
                        column: x => x.PADId,
                        principalTable: "ContratoCafeDerivativoPAD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeSaida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeId = table.Column<int>(nullable: false),
                    NomeUnidadeEmpresa = table.Column<string>(type: "varchar(100)", nullable: false),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    SituacaoContrato = table.Column<int>(nullable: false),
                    SituacaoVinculoTermo = table.Column<string>(type: "varchar(1)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ParceiroId = table.Column<int>(nullable: false),
                    NomeParceiro = table.Column<string>(type: "varchar(150)", nullable: false),
                    ParceiroSegmentacaoId = table.Column<int>(nullable: false),
                    ParceiroSegmentacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    ValorUnitario = table.Column<double>(type: "float", nullable: false),
                    CotacaoMoeda = table.Column<double>(type: "float", nullable: false),
                    DtEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEmissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEntrega = table.Column<DateTime>(type: "datetime", nullable: false),
                    RequerFinalidadeContrato = table.Column<string>(type: "varchar(1)", nullable: false),
                    FinalidadeContratoId = table.Column<int>(nullable: true),
                    RequerModalidadeCafeEP = table.Column<string>(type: "varchar(1)", nullable: false),
                    RequerCertificacaoCafe = table.Column<string>(type: "varchar(1)", nullable: false),
                    ModalidadeCafeEpId = table.Column<int>(nullable: true),
                    TipoMoedaId = table.Column<int>(nullable: false),
                    SafraComercialFuturoId = table.Column<int>(nullable: false),
                    CertificacaoId = table.Column<int>(nullable: true),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    VinculadoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    ConcluidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    DocumentoRefer = table.Column<string>(type: "varchar(30)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false),
                    NomeCorretor = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeSaida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaida_CertificacaoCafe_CertificacaoId",
                        column: x => x.CertificacaoId,
                        principalTable: "CertificacaoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaida_FinalidadeContratoCafe_FinalidadeContratoId",
                        column: x => x.FinalidadeContratoId,
                        principalTable: "FinalidadeContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaida_ModalidadeCafeEP_ModalidadeCafeEpId",
                        column: x => x.ModalidadeCafeEpId,
                        principalTable: "ModalidadeCafeEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaida_SafraComercialFuturo_SafraComercialFuturoId",
                        column: x => x.SafraComercialFuturoId,
                        principalTable: "SafraComercialFuturo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaida_TipoMoeda_TipoMoedaId",
                        column: x => x.TipoMoedaId,
                        principalTable: "TipoMoeda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SafraComercialVigencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SafraComercialFuturoId = table.Column<int>(nullable: false),
                    DtVigencia = table.Column<DateTime>(type: "datetime", nullable: false),
                    LimiteCoop = table.Column<double>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafraComercialVigencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SafraComercialVigencia_SafraComercialFuturo_SafraComercialFuturoId",
                        column: x => x.SafraComercialFuturoId,
                        principalTable: "SafraComercialFuturo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeId = table.Column<int>(nullable: false),
                    NomeUnidadeEmpresa = table.Column<string>(type: "varchar(100)", nullable: false),
                    ParceiroId = table.Column<int>(nullable: false),
                    NomeParceiro = table.Column<string>(type: "varchar(150)", nullable: false),
                    ParceiroSegmentacaoId = table.Column<int>(nullable: false),
                    ParceiroSegmentacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    Bloqueado = table.Column<string>(type: "varchar(1)", nullable: false),
                    DescricaoBloqueio = table.Column<string>(type: "varchar(150)", nullable: false),
                    NaoProprietario = table.Column<bool>(nullable: false),
                    SaldoInsuficiente = table.Column<bool>(nullable: false),
                    DescricaoSolicitacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    SafraComercialFuturoId = table.Column<int>(nullable: false),
                    PrecoMinimoAutorizado = table.Column<double>(nullable: false),
                    VolumeSolicitado = table.Column<double>(nullable: false),
                    LimiteSacas = table.Column<double>(nullable: false),
                    SacasContratoBaixados = table.Column<double>(nullable: false),
                    SacasAutorizacoesPendentes = table.Column<double>(nullable: false),
                    PrevisaoSafra = table.Column<string>(type: "varchar(150)", nullable: false),
                    SaldoDespersonalizado = table.Column<string>(type: "varchar(150)", nullable: false),
                    TelefoneCooperado = table.Column<string>(type: "varchar(30)", nullable: false),
                    Agronomo = table.Column<string>(type: "varchar(150)", nullable: false),
                    PrevisaoSafraAgronomo = table.Column<string>(type: "varchar(150)", nullable: false),
                    TelefoneAgronomo = table.Column<string>(type: "varchar(150)", nullable: false),
                    DtEmissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoVenda_SafraComercialFuturo_SafraComercialFuturoId",
                        column: x => x.SafraComercialFuturoId,
                        principalTable: "SafraComercialFuturo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TermoContratoCafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    SituacaoTermo = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    FinalidadeContratoCafeId = table.Column<int>(nullable: false),
                    ModalidadeContratoCafeId = table.Column<int>(nullable: false),
                    ExcercicioRefer = table.Column<int>(nullable: false),
                    TipoProcessamentoCafeId = table.Column<int>(nullable: false),
                    ModalidadeCafeEPId = table.Column<int>(nullable: true),
                    CertificacaoCafeId = table.Column<int>(nullable: true),
                    SafraComercialFuturoId = table.Column<int>(nullable: false),
                    ValorUnitario = table.Column<double>(type: "float", nullable: false),
                    DtEmissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEncerramento = table.Column<DateTime>(type: "datetime", nullable: true),
                    DtLimiteEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtLimiteSaida = table.Column<DateTime>(type: "datetime", nullable: false),
                    RequerProtecaoValor = table.Column<string>(type: "varchar(1)", nullable: false),
                    RequerValorSacaFlex = table.Column<string>(type: "varchar(1)", nullable: false),
                    RequerModalidadeCafeEP = table.Column<string>(type: "varchar(1)", nullable: false),
                    RequerCertificacaoCafe = table.Column<string>(type: "varchar(1)", nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermoContratoCafe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermoContratoCafe_CertificacaoCafe_CertificacaoCafeId",
                        column: x => x.CertificacaoCafeId,
                        principalTable: "CertificacaoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TermoContratoCafe_FinalidadeContratoCafe_FinalidadeContratoCafeId",
                        column: x => x.FinalidadeContratoCafeId,
                        principalTable: "FinalidadeContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TermoContratoCafe_ModalidadeCafeEP_ModalidadeCafeEPId",
                        column: x => x.ModalidadeCafeEPId,
                        principalTable: "ModalidadeCafeEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TermoContratoCafe_ModalidadeContratoCafe_ModalidadeContratoCafeId",
                        column: x => x.ModalidadeContratoCafeId,
                        principalTable: "ModalidadeContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TermoContratoCafe_SafraComercialFuturo_SafraComercialFuturoId",
                        column: x => x.SafraComercialFuturoId,
                        principalTable: "SafraComercialFuturo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TermoContratoCafe_TipoProcessamentoCafe_TipoProcessamentoCafeId",
                        column: x => x.TipoProcessamentoCafeId,
                        principalTable: "TipoProcessamentoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeSaidaAjuste",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoSaidaId = table.Column<int>(nullable: false),
                    DtAjuste = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEmissaoAjuste = table.Column<DateTime>(type: "datetime", nullable: false),
                    DescricaoAjuste = table.Column<string>(type: "varchar(100)", nullable: false),
                    QuantSacasAjuste = table.Column<double>(type: "float", nullable: false),
                    ValorAjuste = table.Column<double>(type: "float", nullable: false),
                    EfetuadoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    SituacaoAjuste = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeSaidaAjuste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaidaAjuste_ContratoCafeSaida_ContratoSaidaId",
                        column: x => x.ContratoSaidaId,
                        principalTable: "ContratoCafeSaida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeSaidaMov",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoSaidaId = table.Column<int>(nullable: false),
                    OpESContratoId = table.Column<int>(nullable: false),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DTOperacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    TituloCTReceber = table.Column<string>(type: "varchar(30)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeSaidaMov", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaidaMov_ContratoCafeSaida_ContratoSaidaId",
                        column: x => x.ContratoSaidaId,
                        principalTable: "ContratoCafeSaida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaidaMov_OperacaoESContratoCafe_OpESContratoId",
                        column: x => x.OpESContratoId,
                        principalTable: "OperacaoESContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeSaidaSaldo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoSaidaId = table.Column<int>(nullable: false),
                    ExercicioId = table.Column<int>(nullable: false),
                    MesReferenciaId = table.Column<int>(nullable: false),
                    EntradaQuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    SaidaQuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    SaldoQuantidadeSacas = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeSaidaSaldo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaidaSaldo_ContratoCafeSaida_ContratoSaidaId",
                        column: x => x.ContratoSaidaId,
                        principalTable: "ContratoCafeSaida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacaoVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitacaoId = table.Column<int>(nullable: true),
                    UnidadeId = table.Column<int>(nullable: false),
                    NomeUnidadeEmpresa = table.Column<string>(type: "varchar(100)", nullable: false),
                    SituacaoAutorizacao = table.Column<int>(nullable: false),
                    ModalidadeId = table.Column<int>(nullable: false),
                    ParceiroId = table.Column<int>(nullable: false),
                    NomeParceiro = table.Column<string>(type: "varchar(150)", nullable: false),
                    ParceiroSegmentacaoId = table.Column<int>(nullable: false),
                    ParceiroSegmentacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    DtEmissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    SafraComercialFuturoId = table.Column<int>(nullable: false),
                    DtLimite = table.Column<DateTime>(type: "datetime", nullable: false),
                    SacasAutorizadas = table.Column<double>(nullable: false),
                    PrecoMinimoAutorizado = table.Column<double>(nullable: false),
                    CertificacaoId = table.Column<int>(nullable: true),
                    TipoProcessamentoCafeId = table.Column<int>(nullable: false),
                    DtEntrega = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtPagto = table.Column<DateTime>(type: "datetime", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(50)", nullable: false),
                    BaixadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    CodigoIntegracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacaoVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutorizacaoVenda_CertificacaoCafe_CertificacaoId",
                        column: x => x.CertificacaoId,
                        principalTable: "CertificacaoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutorizacaoVenda_ModalidadeContratoCafe_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "ModalidadeContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutorizacaoVenda_SolicitacaoVenda_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "SolicitacaoVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutorizacaoVenda_SafraComercialFuturo_SafraComercialFuturoId",
                        column: x => x.SafraComercialFuturoId,
                        principalTable: "SafraComercialFuturo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutorizacaoVenda_TipoProcessamentoCafe_TipoProcessamentoCafeId",
                        column: x => x.TipoProcessamentoCafeId,
                        principalTable: "TipoProcessamentoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoVendaFiador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitacaoId = table.Column<int>(nullable: false),
                    FiadorId = table.Column<int>(nullable: false),
                    NomeFiador = table.Column<string>(type: "varchar(150)", nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoVendaFiador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoVendaFiador_SolicitacaoVenda_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "SolicitacaoVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoVendaInterveniente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitacaoId = table.Column<int>(nullable: false),
                    IntervenienteId = table.Column<int>(nullable: false),
                    NomeInterveniente = table.Column<string>(type: "varchar(150)", nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoVendaInterveniente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoVendaInterveniente_SolicitacaoVenda_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "SolicitacaoVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoVendaMov",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitacaoId = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    NomeUsuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    IsComite = table.Column<bool>(nullable: false),
                    Devolutiva = table.Column<string>(type: "varchar(max)", nullable: false),
                    Comentarios = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoVendaMov", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoVendaMov_SolicitacaoVenda_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "SolicitacaoVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeDerivativoTermo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "varchar(100)", nullable: false),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    DtOperacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantSacas = table.Column<double>(type: "float", nullable: false),
                    ContratoCafeDerivativoId = table.Column<int>(nullable: false),
                    TermoContratoCafeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeDerivativoTermo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativoTermo_ContratoCafeDerivativo_ContratoCafeDerivativoId",
                        column: x => x.ContratoCafeDerivativoId,
                        principalTable: "ContratoCafeDerivativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeDerivativoTermo_TermoContratoCafe_TermoContratoCafeId",
                        column: x => x.TermoContratoCafeId,
                        principalTable: "TermoContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeSaidaTermo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoCafeSaidaId = table.Column<int>(nullable: false),
                    TermoContratoCafeId = table.Column<int>(nullable: false),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtOperacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeSaidaTermo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaidaTermo_ContratoCafeSaida_ContratoCafeSaidaId",
                        column: x => x.ContratoCafeSaidaId,
                        principalTable: "ContratoCafeSaida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeSaidaTermo_TermoContratoCafe_TermoContratoCafeId",
                        column: x => x.TermoContratoCafeId,
                        principalTable: "TermoContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TermoContratoHst",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtLancamento = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    RequerProtecao = table.Column<string>(type: "varchar(1)", nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    TermoContratoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermoContratoHst", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermoContratoHst_TermoContratoCafe_TermoContratoId",
                        column: x => x.TermoContratoId,
                        principalTable: "TermoContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacaoVendaFiador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorizacaoId = table.Column<int>(nullable: false),
                    FiadorId = table.Column<int>(nullable: false),
                    NomeFiador = table.Column<string>(type: "varchar(150)", nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacaoVendaFiador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutorizacaoVendaFiador_AutorizacaoVenda_AutorizacaoId",
                        column: x => x.AutorizacaoId,
                        principalTable: "AutorizacaoVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacaoVendaInterveniente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorizacaoId = table.Column<int>(nullable: false),
                    IntervenienteId = table.Column<int>(nullable: false),
                    NomeInterveniente = table.Column<string>(type: "varchar(150)", nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CriadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoPor = table.Column<string>(type: "varchar(50)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacaoVendaInterveniente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutorizacaoVendaInterveniente_AutorizacaoVenda_AutorizacaoId",
                        column: x => x.AutorizacaoId,
                        principalTable: "AutorizacaoVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeEntrada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorizacaoId = table.Column<int>(nullable: true),
                    UnidadeId = table.Column<int>(nullable: false),
                    NomeUnidadeEmpresa = table.Column<string>(type: "varchar(100)", nullable: false),
                    TermoId = table.Column<int>(nullable: false),
                    ModalidadeCafeEPId = table.Column<int>(nullable: true),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    SituacaoContrato = table.Column<int>(nullable: false),
                    EmitidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    ConcluidoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ParceiroId = table.Column<int>(nullable: false),
                    NomeParceiro = table.Column<string>(type: "varchar(150)", nullable: false),
                    ParceiroSegmentacaoId = table.Column<int>(nullable: false),
                    ParceiroSegmentacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    ValorUnitario = table.Column<double>(type: "float", nullable: false),
                    DtEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEmissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEntrega = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtPagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    RequerModalidadeCafeEP = table.Column<string>(type: "varchar(1)", nullable: false),
                    DocumentoRefer = table.Column<string>(type: "varchar(50)", nullable: false),
                    PedidoFaturado = table.Column<string>(type: "varchar(30)", nullable: false),
                    TituloCTReceber = table.Column<string>(type: "varchar(30)", nullable: false),
                    TituloCTPagar = table.Column<string>(type: "varchar(30)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeEntrada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeEntrada_AutorizacaoVenda_AutorizacaoId",
                        column: x => x.AutorizacaoId,
                        principalTable: "AutorizacaoVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeEntrada_ModalidadeCafeEP_ModalidadeCafeEPId",
                        column: x => x.ModalidadeCafeEPId,
                        principalTable: "ModalidadeCafeEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeEntrada_TermoContratoCafe_TermoId",
                        column: x => x.TermoId,
                        principalTable: "TermoContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeEntradaAjuste",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoEntradaId = table.Column<int>(nullable: false),
                    DtAjuste = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEmissaoAjuste = table.Column<DateTime>(type: "datetime", nullable: false),
                    DescricaoAjuste = table.Column<string>(type: "varchar(100)", nullable: false),
                    QuantSacasAjuste = table.Column<double>(type: "float", nullable: false),
                    ValorAjuste = table.Column<double>(type: "float", nullable: false),
                    EfetuadoPor = table.Column<string>(type: "varchar(100)", nullable: false),
                    SituacaoAjuste = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeEntradaAjuste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeEntradaAjuste_ContratoCafeEntrada_ContratoEntradaId",
                        column: x => x.ContratoEntradaId,
                        principalTable: "ContratoCafeEntrada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeEntradaMov",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoCafeEntradaId = table.Column<int>(nullable: false),
                    OpEntSaidaId = table.Column<int>(nullable: false),
                    EmitidoPor = table.Column<string>(nullable: true),
                    OrigemLancamento = table.Column<int>(nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtUltimaManutencao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DtOperacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    TituloCTReceber = table.Column<string>(type: "varchar(100)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeEntradaMov", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeEntradaMov_ContratoCafeEntrada_ContratoCafeEntradaId",
                        column: x => x.ContratoCafeEntradaId,
                        principalTable: "ContratoCafeEntrada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoCafeEntradaMov_OperacaoESContratoCafe_OpEntSaidaId",
                        column: x => x.OpEntSaidaId,
                        principalTable: "OperacaoESContratoCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoCafeEntradaSaldo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExercicioId = table.Column<int>(nullable: false),
                    MesReferenciaId = table.Column<int>(nullable: false),
                    EntradaQuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    SaidaQuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    SaldoQuantidadeSacas = table.Column<double>(type: "float", nullable: false),
                    ContratoCafeEntradaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoCafeEntradaSaldo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoCafeEntradaSaldo_ContratoCafeEntrada_ContratoCafeEntradaId",
                        column: x => x.ContratoCafeEntradaId,
                        principalTable: "ContratoCafeEntrada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacaoVenda_CertificacaoId",
                table: "AutorizacaoVenda",
                column: "CertificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacaoVenda_ModalidadeId",
                table: "AutorizacaoVenda",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacaoVenda_SafraComercialFuturoId",
                table: "AutorizacaoVenda",
                column: "SafraComercialFuturoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacaoVenda_TipoProcessamentoCafeId",
                table: "AutorizacaoVenda",
                column: "TipoProcessamentoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacaoVendaFiador_AutorizacaoId",
                table: "AutorizacaoVendaFiador",
                column: "AutorizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacaoVendaInterveniente_AutorizacaoId",
                table: "AutorizacaoVendaInterveniente",
                column: "AutorizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativo_ModalidadeDerivativoId",
                table: "ContratoCafeDerivativo",
                column: "ModalidadeDerivativoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativo_FinalidadeDerivativoId",
                table: "ContratoCafeDerivativo",
                column: "FinalidadeDerivativoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativo_TipoMoedaId",
                table: "ContratoCafeDerivativo",
                column: "TipoMoedaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativoMov_ContratoDerivativoId",
                table: "ContratoCafeDerivativoMov",
                column: "ContratoDerivativoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativoMov_OperacaoESDerivativoCafeId",
                table: "ContratoCafeDerivativoMov",
                column: "OperacaoESDerivativoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativoPAD_ContratoDerivativoId",
                table: "ContratoCafeDerivativoPAD",
                column: "ContratoDerivativoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativoPADHS_PADId",
                table: "ContratoCafeDerivativoPADHS",
                column: "PADId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativoTermo_ContratoCafeDerivativoId",
                table: "ContratoCafeDerivativoTermo",
                column: "ContratoCafeDerivativoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeDerivativoTermo_TermoContratoCafeId",
                table: "ContratoCafeDerivativoTermo",
                column: "TermoContratoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeEntrada_AutorizacaoId",
                table: "ContratoCafeEntrada",
                column: "AutorizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeEntrada_ModalidadeCafeEPId",
                table: "ContratoCafeEntrada",
                column: "ModalidadeCafeEPId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeEntrada_TermoId",
                table: "ContratoCafeEntrada",
                column: "TermoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeEntradaAjuste_ContratoEntradaId",
                table: "ContratoCafeEntradaAjuste",
                column: "ContratoEntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeEntradaMov_ContratoCafeEntradaId",
                table: "ContratoCafeEntradaMov",
                column: "ContratoCafeEntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeEntradaMov_OpEntSaidaId",
                table: "ContratoCafeEntradaMov",
                column: "OpEntSaidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeEntradaSaldo_ContratoCafeEntradaId",
                table: "ContratoCafeEntradaSaldo",
                column: "ContratoCafeEntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaida_CertificacaoId",
                table: "ContratoCafeSaida",
                column: "CertificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaida_FinalidadeContratoId",
                table: "ContratoCafeSaida",
                column: "FinalidadeContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaida_ModalidadeCafeEpId",
                table: "ContratoCafeSaida",
                column: "ModalidadeCafeEpId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaida_SafraComercialFuturoId",
                table: "ContratoCafeSaida",
                column: "SafraComercialFuturoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaida_TipoMoedaId",
                table: "ContratoCafeSaida",
                column: "TipoMoedaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaidaAjuste_ContratoSaidaId",
                table: "ContratoCafeSaidaAjuste",
                column: "ContratoSaidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaidaMov_ContratoSaidaId",
                table: "ContratoCafeSaidaMov",
                column: "ContratoSaidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaidaMov_OpESContratoId",
                table: "ContratoCafeSaidaMov",
                column: "OpESContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaidaSaldo_ContratoSaidaId",
                table: "ContratoCafeSaidaSaldo",
                column: "ContratoSaidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaidaTermo_ContratoCafeSaidaId",
                table: "ContratoCafeSaidaTermo",
                column: "ContratoCafeSaidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoCafeSaidaTermo_TermoContratoCafeId",
                table: "ContratoCafeSaidaTermo",
                column: "TermoContratoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoDerivativoSaldo_ContratoDerivativoId",
                table: "ContratoDerivativoSaldo",
                column: "ContratoDerivativoId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalidadeContratoCafe_TipoFinalidadeId",
                table: "FinalidadeContratoCafe",
                column: "TipoFinalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadeContratoCafe_FinalidadeContratoId",
                table: "ModalidadeContratoCafe",
                column: "FinalidadeContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadeContratoCafe_TipoModalidadeContratoId",
                table: "ModalidadeContratoCafe",
                column: "TipoModalidadeContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_SafraComercialFuturo_ModalidadeId",
                table: "SafraComercialFuturo",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_SafraComercialVigencia_SafraComercialFuturoId",
                table: "SafraComercialVigencia",
                column: "SafraComercialFuturoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoVenda_SafraComercialFuturoId",
                table: "SolicitacaoVenda",
                column: "SafraComercialFuturoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoVendaFiador_SolicitacaoId",
                table: "SolicitacaoVendaFiador",
                column: "SolicitacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoVendaInterveniente_SolicitacaoId",
                table: "SolicitacaoVendaInterveniente",
                column: "SolicitacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoVendaMov_SolicitacaoId",
                table: "SolicitacaoVendaMov",
                column: "SolicitacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_TermoContratoCafe_CertificacaoCafeId",
                table: "TermoContratoCafe",
                column: "CertificacaoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_TermoContratoCafe_FinalidadeContratoCafeId",
                table: "TermoContratoCafe",
                column: "FinalidadeContratoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_TermoContratoCafe_ModalidadeCafeEPId",
                table: "TermoContratoCafe",
                column: "ModalidadeCafeEPId");

            migrationBuilder.CreateIndex(
                name: "IX_TermoContratoCafe_ModalidadeContratoCafeId",
                table: "TermoContratoCafe",
                column: "ModalidadeContratoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_TermoContratoCafe_SafraComercialFuturoId",
                table: "TermoContratoCafe",
                column: "SafraComercialFuturoId");

            migrationBuilder.CreateIndex(
                name: "IX_TermoContratoCafe_TipoProcessamentoCafeId",
                table: "TermoContratoCafe",
                column: "TipoProcessamentoCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_TermoContratoHst_TermoContratoId",
                table: "TermoContratoHst",
                column: "TermoContratoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorizacaoVendaFiador");

            migrationBuilder.DropTable(
                name: "AutorizacaoVendaInterveniente");

            migrationBuilder.DropTable(
                name: "BloqueioVenda");

            migrationBuilder.DropTable(
                name: "ContratoCafeDerivativoMov");

            migrationBuilder.DropTable(
                name: "ContratoCafeDerivativoPADHS");

            migrationBuilder.DropTable(
                name: "ContratoCafeDerivativoTermo");

            migrationBuilder.DropTable(
                name: "ContratoCafeEntradaAjuste");

            migrationBuilder.DropTable(
                name: "ContratoCafeEntradaMov");

            migrationBuilder.DropTable(
                name: "ContratoCafeEntradaSaldo");

            migrationBuilder.DropTable(
                name: "ContratoCafeSaidaAjuste");

            migrationBuilder.DropTable(
                name: "ContratoCafeSaidaMov");

            migrationBuilder.DropTable(
                name: "ContratoCafeSaidaSaldo");

            migrationBuilder.DropTable(
                name: "ContratoCafeSaidaTermo");

            migrationBuilder.DropTable(
                name: "ContratoDerivativoSaldo");

            migrationBuilder.DropTable(
                name: "SafraComercialVigencia");

            migrationBuilder.DropTable(
                name: "SolicitacaoVendaFiador");

            migrationBuilder.DropTable(
                name: "SolicitacaoVendaInterveniente");

            migrationBuilder.DropTable(
                name: "SolicitacaoVendaMov");

            migrationBuilder.DropTable(
                name: "TermoContratoHst");

            migrationBuilder.DropTable(
                name: "OperacaoESDerivativoCafe");

            migrationBuilder.DropTable(
                name: "ContratoCafeDerivativoPAD");

            migrationBuilder.DropTable(
                name: "ContratoCafeEntrada");

            migrationBuilder.DropTable(
                name: "OperacaoESContratoCafe");

            migrationBuilder.DropTable(
                name: "ContratoCafeSaida");

            migrationBuilder.DropTable(
                name: "ContratoCafeDerivativo");

            migrationBuilder.DropTable(
                name: "AutorizacaoVenda");

            migrationBuilder.DropTable(
                name: "TermoContratoCafe");

            migrationBuilder.DropTable(
                name: "ModalidadeDerivativo");

            migrationBuilder.DropTable(
                name: "FinalidadeDerivativo");

            migrationBuilder.DropTable(
                name: "TipoMoeda");

            migrationBuilder.DropTable(
                name: "SolicitacaoVenda");

            migrationBuilder.DropTable(
                name: "CertificacaoCafe");

            migrationBuilder.DropTable(
                name: "ModalidadeCafeEP");

            migrationBuilder.DropTable(
                name: "TipoProcessamentoCafe");

            migrationBuilder.DropTable(
                name: "SafraComercialFuturo");

            migrationBuilder.DropTable(
                name: "ModalidadeContratoCafe");

            migrationBuilder.DropTable(
                name: "FinalidadeContratoCafe");

            migrationBuilder.DropTable(
                name: "TipoModalidadeContrato");

            migrationBuilder.DropTable(
                name: "TipoFinalidadeContrato");
        }
    }
}
