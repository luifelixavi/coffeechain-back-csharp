
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// Tabela Referente as Modalidades do Cadastro do vinculo do correntista com o agronomo	
    /// </summary>
    public class ModalidadeAgronomoAtaDTO
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
        /// Descricao resumo do grupo
        /// </summary>
        public string descricaoResumo { get;  set; }
        /// <summary>
        /// S(sim), N(não)
        /// </summary>
        public string ativo { get;  set; }
        /// <summary>
        /// Data de Lancamento
        /// </summary>
        public DateTime dtCadastro { get;  set; }
        /// <summary>
        /// Data da ultima atualizacao
        /// </summary>
        public DateTime dtUltManutencao { get;  set; }
        /// <summary>
        /// Observacoes do Lancamento
        /// </summary>
        public string observacao { get;  set; }

    }
}
