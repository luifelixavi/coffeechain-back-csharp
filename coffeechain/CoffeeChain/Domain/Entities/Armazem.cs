using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Entities
{
    public class Armazem
    {
        public int ArmazemId { get; set; }
        public int EmpresaId { get; set; }
        public string TelefoneArmazem { get; set; }
        public string EnderecoArmazem { get; set; }
        public string CidadeArmazem { get; set; }
        public string UfArmazem { get; set; }
        public string EmailArmazem { get; set; }
        public Empresa Empresa { get; set; }
        public List<Entradas> Entradas { get; set; }
        public List<Saidas> Saidas { get; set; }
    }
}
