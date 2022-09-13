
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
    public class PedidoLojaEpCafeMovDTO : IntegrationEvent
    {

        public string codigoEmpresa { get; set; }
        public string codigoPedido { get; set; }
        public int OrdemId { get; set; }
        public int MovimentoId { get; set; }
        public int OrigemLancamento { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime dtUltimaManutencao { get; set; }
        public int QuantidadeSaca { get; set; }
        public string CodigoOperacao{ get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtOperacao { get; set; }
        public string EmitidoPor { get; set; }
        public string Observacao { get; set; }

    }
}
