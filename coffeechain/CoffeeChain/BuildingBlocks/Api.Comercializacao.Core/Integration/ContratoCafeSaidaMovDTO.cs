
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeSaidaMov
    /// </summary>
    public class ContratoCafeSaidaMovDTO : IntegrationEvent
    {
        public string codigoIntegracaoContratoSaida { get; set; }
        public string codigoIntegracaoOpEsContCafe { get; set; }
        public string emitidoPor { get; set; }
        public int origemLancamento { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtUltimaManutencao { get; set; }
        public DateTime dtEntrada { get; set; }
        public DateTime dtOperacao { get; set; }
        public int quantidadeSacas { get; set; }
        public string tituloCtReceber { get; set; }
        public string observacao { get; set; }
        public string movimentoId { get; set; }

    }
}
