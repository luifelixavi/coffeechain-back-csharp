
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de Agronomos	
    /// </summary>
    public class AgronomoAtaDTO : IntegrationEvent
    {
        /// <summary>
        /// Código de Integração com ERP
        /// </summary>
        public string codigoIntegracao { get;  set; }
        /// <summary>
        /// Descricao do Grupo
        /// </summary>
        public string descricao { get;  set; }
        /// <summary>
        /// Decricao Resumo do grupo
        /// </summary>
        public string descricaoResumo { get;  set; }
        /// <summary>
        /// S(sim), N(não)
        /// </summary>
        public string ativo { get;  set; }
        /// <summary>
        ///  Data de lancamento
        /// </summary>
        public DateTime dtCadastro { get;  set; }
        /// <summary>
        /// Data da Ultima atualizacao
        /// </summary>
        public DateTime dtUltimaManutencao { get;  set; }
        /// <summary>
        /// Observacoes do Lancamento
        /// </summary>
        public string observacao { get;  set; }
        /// <summary>
        /// Nome do Agronomo
        /// </summary>
        public string nomeRTA { get;  set; }
        /// <summary>
        /// Código do agrononomo no conselho regional
        /// </summary>
        public string crea { get;  set; }
        /// <summary>
        /// Telefone do Agronomo
        /// </summary>
        public string telefone { get;  set; }
        /// <summary>
        /// Email do Agronomo
        /// </summary>
        public string email { get;  set; }

    }
}
