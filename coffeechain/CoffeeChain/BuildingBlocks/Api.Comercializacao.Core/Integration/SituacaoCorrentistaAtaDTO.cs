using Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Vinculo do Correntista com a modalidade do agronomo	
    /// </summary>
    public class SituacaoCorrentistaAtaDTO
    {


        /// <summary>
        /// Código de integracao
        /// </summary>
        public string codigoIntegracao { get; set; }
        /// <summary>
        /// Cosdigo de Produtor
        /// </summary>
        public int parceiroNegocioId { get;  set; }
        /// <summary>
        /// NOme de parceiro de negocio
        /// </summary>
        public string nomeParceiroNegocio { get;  set; }
        /// <summary>
        /// Data de Lancamento
        /// </summary>
        public DateTime dtCadastro { get;  set; }
        /// <summary>
        /// Data de Lancamento
        /// </summary>
        public DateTime dtModalidadeAta { get; set; }
        /// <summary>
        /// Data da ultima atualizacao
        /// </summary>
        public DateTime dtUltimaAtualizacao{ get;  set; }
        /// <summary>
        /// Codigo da modalidade
        /// </summary>
        public int modalidadeCorrentistaAtaId { get;  set; }
    }
}
