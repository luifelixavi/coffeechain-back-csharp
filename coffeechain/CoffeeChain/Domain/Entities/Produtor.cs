using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Entities
{
    public class Produtor
    {
        public int ProdutorId { get; set; }
        public string NomeProdutor { get; set; }
        public string CpfProdutor { get; set; }
        public string RgProdutor { get; set; }
        public string TelefoneProdutor { get; set; }
        public string EnderecoProdutor { get; set; }
        public string CidadeProdutor { get; set; }
        public string UfProdutor { get; set; }
        public string EmailProdutor { get; set; }
        public string CepProdutor { get; set; }
        public List<Propriedade> Propriedades { get; set; }
        public List<Entradas> Entradas { get; set; }
        public List<Saidas> Saidas { get; set; }


    }
}
