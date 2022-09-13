
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeDerivativoMov
    /// </summary>
    public class ContratoCafeDerivativoMovDTO : IntegrationEvent
    {
        public string codigoIntegracaoContrato { get; set; }
        public string codigoIntegracaoOpEsDerCafe { get; set; }
        public int origemLancamento { get; set; }
        public int movimentoId { get; set; }
        public int situacaoMovimento { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtUltimaManutencao { get; set; }
        public DateTime dtEntrada { get; set; }
        public DateTime dtOperacao { get; set; }
        public string descOperacaoEsDerivativoCafe { get; set; }
        public double quantidadeSacas{ get; set; }
        public double valorUnitario{ get; set; }
        public double valorOperacao{ get; set; }
        public double valorAjusteUnitario{ get; set; }
        public double valorAjusteOperacao { get; set; }
        public int registroCetip { get; set; }
        public string documentoCetipRefer { get; set; }
        public string emitidoPor { get; set; }
        public string observacao { get; set; }
        public Guid usuarioId { get; set; }

    }
}
