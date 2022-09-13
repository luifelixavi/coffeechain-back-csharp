
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de OperacaoEsContratoCafe
    /// </summary>
    public class OperacaoEsContratoCafeDTO : IntegrationEvent
    {
        /// <summary>
        /// Código de Integração com ERP
        /// </summary>
        public string codigoIntegracao { get; set; }
        /// <summary>
        /// Descricao do Grupo
        /// </summary>
        public string descricao { get; set; }
        /// <summary>
        /// Decricao Resumo do grupo
        /// </summary>
        public string descricaoResumo { get; set; }
        /// <summary>
        /// S(sim), N(não)
        /// </summary>
        public string ativo { get; set; }
        /// <summary>
        ///  Data de lancamento
        /// </summary>
        public DateTime dtCadastro { get; set; }
        /// <summary>
        /// Data da Ultima atualizacao
        /// </summary>
        public DateTime dtUltimaManutencao { get; set; }
        /// <summary>
        /// Observacoes do Lancamento
        /// </summary>
        public string observacao { get; set; }
        public string criadoPor { get; set; }
        public string atualizadoPor { get; set; }
        public string bloqueado { get; set; }
        public string operacaoEntregaCafe {get;set;}
        public string operacaoEs {get;set; }

    }
}
