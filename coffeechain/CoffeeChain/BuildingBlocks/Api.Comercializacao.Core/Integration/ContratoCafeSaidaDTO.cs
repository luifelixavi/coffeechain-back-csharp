
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeSaida
    /// </summary>
    public class ContratoCafeSaidaDTO : IntegrationEvent
    {
        public string codigoIntegracao { get; set; }

        public string codigoIntegracaoUnidade { get; set; }
        public string nomeUnidadeEmpresa { get; set; }
        public int origemLancamento { get; set; }
        public int situacaoContrato { get; set; }
        public int situacaoVinculoTermo { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtUltimaManutencao { get; set; }
        public string codigoIntegracaoParceiro { get; set; }
        public string nomeParceiro { get; set; }
        public string codigoIntegracaoParcSegment { get; set; }
        public string parceiroSegmentacao { get; set; }
        public double quantidadeSacas { get; set; }
        public double valorUnitario { get; set; }
        public double cotacaoMoeda { get; set; }
        public DateTime dtEntrada { get; set; }
        public DateTime dtEmissao { get; set; }
        public DateTime dtEntrega { get; set; }
        public string requerCertificacaoCafe { get; set; }
        public string requerFinalidadeContrato { get; set; }
        public string codigoIntegracaoFinCont { get; set; }
        public string requerModalidadeCafeEp { get; set; }
        public string codigoIntegracaoModCafeEp { get; set; }
        public int tipoMoeda { get; set; }
        public string codigoIntegracaoSafraComFut { get; set; }
        public string codigoIntegracaoCertificacao { get; set; }
        public string emitidoPor { get; set; }
        public string vinculadoPor { get; set; }
        public string concluidoPor { get; set; }
        public string documentoRefer { get; set; }
        public string observacao { get; set; }
        public string nomeCorretor { get; set; }

    }
}
