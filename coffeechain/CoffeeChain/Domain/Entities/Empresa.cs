using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Entities
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJEmpresa { get; set; }
        public string TelefoneEmpresa { get; set; }
        public string EnderecoEmpresa { get; set; }
        public string CidadeEmpresa { get; set; }
        public string UfEmpresa { get; set; }
        public string PaisEmpresa { get; set; }
        public string CepEmpresa { get; set; }
        public string EmailEmpresa { get; set; }
        public List<Armazem> Armazens { get; set; }
        public List<Entradas> Entradas { get; set; }
        public List<Saidas> Saidas { get; set; }
    }
}
