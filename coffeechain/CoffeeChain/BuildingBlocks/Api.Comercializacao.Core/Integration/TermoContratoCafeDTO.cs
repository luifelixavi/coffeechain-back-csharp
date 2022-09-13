
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de TermoContratoCafe
    /// </summary>
    public class TermoContratoCafeDTO : IntegrationEvent
    {
        public int origemLancamento { get; set; }
        public int situacaoTermo { get; set; }
        /// <summary>
        /// Código de Integração com ERP
        /// </summary>
        public string codigoIntegracao { get;  set; }
        /// <summary>
        /// Descricao do Grupo
        /// </summary>
        public string descricao { get;  set; }
        /// <summary>
        ///  Data de lancamento
        /// </summary>
        public DateTime dtCadastro { get;  set; }
        /// <summary>
        /// Data da Ultima atualizacao
        /// </summary>
        public DateTime dtUltimaManutencao { get;  set; }
        public string codigoIntegracaoFinCont { get; set; }
        public string codigoIntegracaoModContCafe { get; set; }
        public int exercicioRefer { get; set; }
        public string codigoIntegracaoTipoProcCafe { get; set; }
        public string codigoIntegracaoModCafeEp { get; set; }
        public string codigoIntegracaoCertCafe { get; set; }
        public string codigoIntegracaoSafra { get; set; }
        public double valorUnitario { get; set; }
        public DateTime dtEmissao { get; set; }
        public DateTime? dtEncerramento { get; set; }
        public DateTime dtLimiteEntrada { get; set; }
        public DateTime dtLimiteSaida { get; set; }
        public string requerProtecaoValor { get; set; }
        public string requerValorSacaFlex { get; set; }
        public string requerModalidadeCafeEp { get; set; }
        public string requerCertificacaoCafe { get; set; }
        public string emitidoPor { get; set; }
        /// <summary>
        /// Observacoes do Lancamento
        /// </summary>
        public string observacao { get;  set; }

    }
}
