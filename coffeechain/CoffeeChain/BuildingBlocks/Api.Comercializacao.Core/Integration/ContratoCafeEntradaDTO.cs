
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeEntrada
    /// </summary>
    public class ContratoCafeEntradaDTO : IntegrationEvent
    {
        public string codigoIntegracao { get; set; }

        public string codigoIntegracaoUnidade { get; set; }
        public string nomeUnidadeEmpresa { get; set; }
        public string codigoIntegracaoTermo { get; set; }
        public string codigoIntegracaoModCafeEp { get; set; }
        public int origemLancamento { get; set; }
        public int situacaoContrato { get; set; }
        public string emitidoPor { get; set; }
        public string concluidoPor { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtUltimaManutencao { get; set; }
        public string codigoIntegracaoParceiro { get; set; }
        public string nomeParceiro { get; set; }
        public string codigoIntegracaoSegmentacao { get; set; }
        public string parceiroSegmentacao { get; set; }
        public int quantidadeSaca { get; set; }
        public double valorUnitario { get; set; }
        public DateTime dtEntrada { get; set; }
        public DateTime dtEmissao { get; set; }
        public DateTime dtEntrega { get; set; }
        public DateTime dtPagamento { get; set; }
        public string requerModalidadeCafeEp { get; set; }
        public string documentoRefer { get; set; }
        public string pedidoFaturado { get; set; }
        public string tituloCtReceber { get; set; }
        public string tituloCtPagar { get; set; }
        public string observacao { get; set; }
        public string contratoAssinado { get; set; }
    }
}
