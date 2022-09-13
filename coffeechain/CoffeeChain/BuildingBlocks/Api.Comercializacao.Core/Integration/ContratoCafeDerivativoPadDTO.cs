
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
    public class ContratoCafeDerivativoPadDTO : IntegrationEvent
    {
        public string codigoIntegracaoConDer { get; set; }
        public DateTime dataPosicaoId { get; set; }
        public int modalidadePosicaoPad { get; set; }
        public int origemLancamento { get; set; }
        public DateTime dataEntrada { get; set; }
        public int quantidadeSacas { get; set; }
        public double valorAjusteUnitario { get; set; }
        public double valorAjustePosicao { get; set; }
        public double valorAmPosicaoCliente { get; set; }
        public double valorAmPosicaoBanco { get; set; }
        public string emitidoPor { get; set; }

    }
}
