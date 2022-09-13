
using System;
using System.Collections.Generic;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao ContratoCafeSaidaTermo	
    /// </summary>
    public class ContratoCafeSaidaTermoDTO
    {
        public string emitidoPor { get; set; }
        public int origemLancamento { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtUltimaManutencao { get; set; }
        public DateTime dtOperacao { get; set; }
        public int quantidadeSacas { get; set; }
        public string codigoIntegracaoContCafeSaida { get; set; }
        public string codigoIntegracaoTermo { get; set; }
    }
}
