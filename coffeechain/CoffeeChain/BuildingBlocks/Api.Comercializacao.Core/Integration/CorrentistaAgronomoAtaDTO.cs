
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Vinculo do Correntista com o agronomo	
    /// </summary>
    public class CorrentistaAgronomoAtaDTO
    {

        /// <summary>
        /// Codigo do Produtor
        /// </summary>
        public int parceiroNegocioId { get;  set; }
        /// <summary>
        /// NOme do parceiro de negocio
        /// </summary>
        public string nomeParceiroNegocio { get; set; }
        /// <summary>
        /// Nome do Parceiro de negocio
        /// </summary>
        public string codigoIntegracao { get;  set; }
        /// <summary>
        /// Data de Lancemento
        /// </summary>
        public DateTime dtCadastro { get;  set; }
        /// <summary>
        /// Data da Ultima Atualizacao
        /// </summary>
        public DateTime dtUltimaAtualizacao{ get;  set; }
        /// <summary>
        /// Codigo do Agronomo
        /// </summary>
        public int agronomoAtaId { get;  set; }
        /// <summary>
        /// Codigo da Modalidade
        /// </summary>
        public int ModalidadeAgronomoId { get;  set; }
        /// <summary>
        /// Data de Inicio da assistencia tecnica
        /// </summary>
        public DateTime dtAssistenciaInicio{ get;  set; }
    }
}
