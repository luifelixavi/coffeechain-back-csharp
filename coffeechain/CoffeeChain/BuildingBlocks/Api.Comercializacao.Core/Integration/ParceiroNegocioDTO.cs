
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao cadastro de pessoas 
    /// </summary>
    public class ParceiroNegocioDTO
    {

        public DateTime dataLancamento { get; set; }
        public DateTime dataAtualizacao { get; set; }
        public DateTime dataSincronizacao { get; set; }
        public int statusMovimento { get; set; }
        public int statusSincronizacao { get; set; }
        public string codigoIntegracao { get; set; }
        public string createdBy { get; set; }
        public string lastModifiedBy { get; set; }
        public string nomeRazaoSocial { get; set; }
        public string nomeFantasia { get; set; }
        public string tipoPessoaCadastro { get; set; }
        public string cnpj { get; set; }
        public string inscEstadual { get; set; }
        public string inscMunicipal { get; set; }
        public string inscEstrangeira { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string espolio { get; set; }
        public DateTime? dataNascimento { get; set; }
        public string paisEntrega { get; set; }
        public string cidadeEntrega { get; set; }
        public string ufEntrega { get; set; }
        public string municipioEntrega { get; set; }
        public string tipoLogradouroEntrega { get; set; }
        public string enderecoLogradouroEntrega { get; set; }
        public string bairroEntrega { get; set; }
        public string numeroEndEntrega { get; set; }
        public string complementoEntrega { get; set; }
        public string cepEntrega { get; set; }
        public string paisCobranca { get; set; }
        public string cidadeCobranca { get; set; }
        public string ufCobranca { get; set; }
        public string municipioCobranca { get; set; }
        public string tipoLogradouroCobranca { get; set; }
        public string enderecoLogradouroCobranca { get; set; }
        public string bairroCobranca { get; set; }
        public string numeroEndCobranca { get; set; }
        public string complementoCobranca { get; set; }
        public string cepCobranca { get; set; }
        public string nomeContatoPrincipal { get; set; }
        public string telefonePrincipal { get; set; }
        public string celularPrincipal { get; set; }
        public string emailPrincipal { get; set; }
        public string faxPrincipal { get; set; }
        public bool flagCooperado { get; set; }
        public string tipoParceiroNegocio { get; set; }
        public string codigoAgrupador { get; set; }
        public double limiteCredito { get; set; }
        public double limiteDisponivel { get; set; }
        public DateTime? dataConcessao { get; set; }
        public DateTime? dataValidade { get; set; }
        public string observacaoFinanceira { get; set; }
        public int vendedorPrincipalId { get; set; }
        public string nacionalidade { get; set; }
        public int estadoCivil { get; set; }
        public int regime { get; set; }
        public string profissao { get; set; }
        public int? dominioAtuacao { get; set; }
        public string nomeConjuge { get; set; }
        public string nacionalidadeConjuge { get; set; }
        public string profissaoConjuge { get; set; }
        public string rgConjuge { get; set; }
        public string cpfConjuge { get; set; }

        List<EnderecoDTO> enderecos { get; set; }
    }
}
