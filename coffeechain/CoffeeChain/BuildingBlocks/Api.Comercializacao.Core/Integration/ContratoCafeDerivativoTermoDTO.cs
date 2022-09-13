
using System;
using System.Collections.Generic;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao ContratoCafeDerivativoTermo	
    /// </summary>
    public class ContratoCafeDerivativoTermoDTO
    {
        public string nomeUsuario { get; set; }
        public int origemLancamento { get; set; }
        public DateTime dtOperacao { get; set; }
        public int quantidadeSacas { get; set; }
        public string codigoIntegracaoContrato { get; set; }
        public string codigoIntegracaoTermo { get; set; }
    }
}
