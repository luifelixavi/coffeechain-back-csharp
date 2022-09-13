
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de ContratoCafeDerivativo
    /// </summary>
    public class ContratoCafeDerivativoDTO : IntegrationEvent
    {
        public string codigoIntegracao { get; set; }
        public int origemLancamento { get; set; }
        public int situacaoContrato { get; set; }
        public int situacaoVinculoTermo { get; set; }
        public int tipoDerivativo { get; set; }
        public int modalidadeDerivativoId { get; set; }
        public int finalidadeDerivativoId { get; set; }
        public int referenciaDerCompl { get; set; }
        public int tipoOperacaoDerivativo { get; set; }
        public int quantidadeSacas { get; set; }
        public double valorUnitario { get; set; }
        public double valorContrato { get; set; }
        public int tipoMoeda { get; set; }
        public double cotacaoMoeda { get; set; }
        public double taxasContraturais { get; set; }
        public DateTime dtEntrada { get; set; }
        public DateTime dtEmissao { get; set; }
        public DateTime dtVencimento { get; set; }
        public int registroCetip { get; set; }
        public string documentoRefer { get; set; }
        public string documentoBolsaRefer { get; set; }
        public string emitidoPor { get; set; }
        public string vinculadoPor { get; set; }
        public string observacao { get; set; }
        public string codigoIntegracaoBanco { get; set; }
        public string nomeBanco { get; set; }
        public string concluidoPor { get; set; }
        public string contratoExportacaoReferencia { get; set; }

    }
}
