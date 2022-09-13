using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Entities
{
    public class Propriedade
    {
        public int PropriedadeId { get; set; }
        public int ProdutorId { get; set; }
        public string NomeFazenda { get; set; }
        public string CNPJFazenda { get; set; }
        public string InscEstadual { get; set; }
        public string TelefonePropriedade { get; set; }
        public string EnderecoPropriedade { get; set; }
        public string CidadePropriedade { get; set; }
        public string UfPropriedade { get; set; }
        public string EmailPropriedade { get; set; }
        public string CepPropriedade { get; set; }
        public Produtor Produtor { get; set; }
        public List<Entradas> Entradas { get; set; }
        public List<Saidas> Saidas { get; set; }
    }
}
