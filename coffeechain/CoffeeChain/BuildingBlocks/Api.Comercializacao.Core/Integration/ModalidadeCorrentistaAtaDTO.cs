
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente as Modalidades de Cadastro  de Parceiros de Negócio	
    /// </summary>
    public class ModalidadeCorrentistaAtaDTO
    {
        /// <summary>
        /// Código de Integração com ERP
        /// </summary>
        public string codigoIntegracao { get;  set; }
        /// <summary>
        /// Descricao do grupo
        /// </summary>
        public string descricao { get;  set; }
        /// <summary>
        /// Descricao resumo do Grupo
        /// </summary>
        public string descricaoResumo { get;  set; }
        /// <summary>
        /// S(sim), N(não)
        /// </summary>
        public string ativo { get;  set; }
        /// <summary>
        /// Data de lancamento
        /// </summary>
        public DateTime dtCadastro { get;  set; }
        /// <summary>
        /// Data da Ultima Atualizacao
        /// </summary>
        public DateTime dtUltimaManutencao { get;  set; }
        /// <summary>
        /// Observacoes de Lancamento
        /// </summary>
        public string observacao { get;  set; }
        /// <summary>
        /// S(sim), N(não)
        /// </summary>
        public string assistidoAta { get;  set; }
        /// <summary>
        /// Tipo de Modalidade 
        /// </summary>

        public int tipoModalidade { get; set; }
    }
}
