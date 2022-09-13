
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao cadastro de pessoas 
    /// </summary>
    public class IntervenienteDTO
    {
        //Interveniente


        /// <summary>
        /// Código do Produtor
        /// </summary>
        public string codigoParceiro{ get;  set; }
        /// <summary>
        /// NOme do Intermitente
        /// </summary>
        public string NomeInterveniente { get;  set; }
        /// <summary>
        /// Pais de Nascimento
        /// </summary>
        public string Nacionalidade { get;  set; }
        /// <summary>
        /// EstadoCivil do cooperado
        /// </summary>
        public int EstadoCivil { get;  set; }
        /// <summary>
        /// Regime do Casamento, se casado
        /// </summary>
        public int Regime { get;  set; }
        /// <summary>
        /// Rg do Interveniente
        /// </summary>
        public string Rg { get;  set; }
        /// <summary>
        ///  CPF do Interveniente
        /// </summary>
        public string Cpf { get;  set; }
        /// <summary>
        ///  Endereco do Interveniente
        /// </summary>
        public string Endereco { get;  set; }
        /// <summary>
        /// / Numento de Endereco do Interveniente
        /// </summary>
        public string NrEndereco { get;  set; }
        /// <summary>
        ///  Bairro do Interveniente
        /// </summary>
        public string Bairro { get;  set; }
        /// <summary>
        ///  Cidade do Interveniente
        /// </summary>
        public string Cidade { get;  set; }
        /// <summary>
        ///  Uf do Interveniente
        /// </summary>
        public string Uf { get;  set; }
        /// <summary>
        /// verifica se interveniente esta ativo ou não S(sim), N(não)
        /// </summary>
        public string Ativo { get;  set; }
        /// <summary>
        /// Campo Bool para 
        /// </summary>
        public string ExigeAssinatura { get;  set; }


        //Conjuge



        /// <summary>
        /// Nome do Conjuge
        /// </summary>
        public string NomeConjuge { get;  set; }
        /// <summary>
        /// Rg do Interveniente
        /// </summary>
        public string conjugeRg { get;  set; }
        /// <summary>
        ///  CPF do Interveniente
        /// </summary>
        public string conjugeCpf { get;  set; }
        /// <summary>
        ///  Se true então exibe ativo no cadastro do parceiro de negocio
        /// </summary>
        public string PermiteSerFiador { get;  set; }

        //Propriedade


        public string codigoPropriedade { get; set; }


    }
}
