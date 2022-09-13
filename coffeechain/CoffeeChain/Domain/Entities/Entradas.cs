using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Entities
{
    public class Entradas
    {
        public int EntradaId { get; set; }
        public int ProdutorId { get; set; }
        public int PropriedadeId { get; set; }
        public int EmpresaId { get; set; }
        public int ArmazemId { get; set; }
        public DateTime DataEntrada { get; set; }
        public string CodigoLote { get; set; }
        public decimal QtdSacas { get; set; }
        public decimal PrecoLote { get; set; }
        public decimal CustoEntrada { get; set; }
        public string NfeEntrada { get; set; }
        public int TipoEntrada { get; set; }
        public string Safra { get; set; }
        public string TipoCafe { get; set; }
        public string LocalArmazenado { get; set; }
        public string EmbalagemArmazenado { get; set; }
        public Armazem Armazem { get; set; }
        public Produtor Produtor { get; set; }
        public Empresa Empresa { get; set; }
        public Propriedade Propriedade { get; set; }

        public List<Saidas> Saidas { get; set; }

    }
}
