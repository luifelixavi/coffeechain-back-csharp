using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Entities
{
    public class Saidas
    {
        public int SaidaId { get; set; }
        public int DestinoProdutorId { get; set; }
        public int DestinoPropriedadeId { get; set; }
        public int DestinoEmpresaId { get; set; }
        public int EntradaId { get; set; }
        public int DestinoArmazemId { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal QtdSacas { get; set; }
        public int TipoSaida { get; set; }
        public decimal PrecoSaida { get; set; }
        public decimal CustoSaida { get; set; }
        public string NfeSaida { get; set; }
        public string EmbalagemSaida { get; set; }
        public Entradas Entradas { get; set; }
        public Armazem Armazem { get; set; }
        public Produtor Produtor { get; set; }
        public Empresa Empresa { get; set; }
        public Propriedade Propriedade { get; set; }

    }
}
