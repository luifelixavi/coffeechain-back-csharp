
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeEntradaMov
    /// </summary>
    public class ContratoCafeEntradaMovDTO : IntegrationEvent
    {
        public string codigoIntegracaoContrato { get; set; }
        public string codigoIntegracaoOpEsContrCafe { get; set; }
        public string emitidoPor { get; set; }
        public int origemLancamento { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtUltimaManutencao { get; set; }
        public DateTime dtEntrada { get; set; }
        public DateTime dtOperacao { get; set; }
        public int quantidadeSacas { get; set; }
        public string tituloCtReceber { get; set; }
        public string observacao { get; set; }
        public int movimentoId { get; set; }

    }
}
