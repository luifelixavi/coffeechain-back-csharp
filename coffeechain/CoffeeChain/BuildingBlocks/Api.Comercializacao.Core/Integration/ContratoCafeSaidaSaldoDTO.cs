
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeSaidaSaldo
    /// </summary>
    public class ContratoCafeSaidaSaldoDTO : IntegrationEvent
    {
        public int exercicioId { get; set; }
        public int mesReferenciaId { get; set; }
        public double entradaQuantidadeSacas { get; set; }
        public double saidaQuantidadeSacas { get; set; }
        public double saldoQuantidadeSacas { get; set; }
        public string codigoIntegracaoContratoSaida { get; set; }


    }
}
