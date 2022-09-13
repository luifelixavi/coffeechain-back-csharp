
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de Pedido	
    /// </summary>
    public class PedidoLojaEpCafeDTO : IntegrationEvent
    {
        public string CodigoIntegraEmpresa { get; set; }
        public string codigoIntegracaoPedido { get; set; }
        public int OrdemId { get; set; }
        public int OrigemLancamento { get; set; }
        public int SituacaoPedido { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtUltimaManutencao { get; set; }
        public string CodigoIntegracaoCorrentista { get; set; }
        public string SafraId { get; set; }
        public int QuantidadeSaca { get; set; }
        public double ValorUnitario { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtEntrega { get; set; }
        public string RequerModalidadeCafeEp { get; set; }
        public string RequerCertificacaoCafe { get; set; }
        public string CodigoIntegracaoFinalidade { get; set; }
        public string CodigoIntegracaoModalidade { get; set; }
        public string CodigoIntegracaoCerti { get; set; }
        public string codigoIntegracaoEndereco { get; set; }
        public string EmitidoPor { get; set; }
        public string ConcluidoPor { get; set; }
        public string DocumentoRefer { get; set; }
        public string Observacao { get; set; }

    }
}
