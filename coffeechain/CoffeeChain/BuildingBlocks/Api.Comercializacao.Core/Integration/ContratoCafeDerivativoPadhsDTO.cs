
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeDerivativoPad
    /// </summary>
    public class ContratoCafeDerivativoPadhsDTO : IntegrationEvent
    {

        public string codigoIntegracaoPad { get; set; }
        public string emitidoPor { get; set; }
        public int contratoDerivativoId { get; set; }
        public DateTime dataPosicaoId { get; set; }
        public int modalidadePosicaoId { get; set; }
        public DateTime timeStampHistoricoId { get; set; }
        public DateTime dataEntrada { get; set; }
        public int quantidadeSacas { get; set; }
        public double valorAjusteUnitario { get; set; }
        public double valorAjustePosicao { get; set; }
        public double valorAmPosicaoCliente { get; set; }
        public double valorAmPosicaoBanco { get; set; }
        public int origemLancamento { get; set; }

    }
}
