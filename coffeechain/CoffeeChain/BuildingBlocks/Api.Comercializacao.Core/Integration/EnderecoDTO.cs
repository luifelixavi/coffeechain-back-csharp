
using System;
using System.Collections.Generic;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Endereco	
    /// </summary>
    public class EnderecoDTO
    {
        public DateTime dataLancamento { get; set; }
        public DateTime dataAtualizacao { get; set; }
        public DateTime dataSincronizacao { get; set; }
        public int statusMovimento { get; set; }
        public int statusSincronizacao { get; set; }
        public string codigoIntegracao { get; set; }
        public string codigoIntegracaoCorrentista { get; set; }
        public string createdBy { get; set; }
        public string lastModifiedBy { get; set; }
        public string nomeFazenda { get; set; }
        public string cnpj { get; set; }
        public string ie { get; set; }
        public string pais { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string municipio { get; set; }
        public string tipoLogradouro { get; set; }
        public string enderecoLogradouro { get; set; }
        public string bairro { get; set; }
        public string numeroEndereco { get; set; }
        public string complementoEndereco { get; set; }
        public string cep { get; set; }
        public string areaPlantada { get; set; }
        public string longitudeEndereco { get; set; }
        public string latitudeEndereco { get; set; }
        public string altitudeEndereco { get; set; }
        public string contatoPrincipal { get; set; }
        public string culturaPrincipal { get; set; }
        public int flagCobrancaEntrega { get; set; }
        public bool flagPrincipal { get; set; }
        public bool flagFunral { get; set; }
        public bool flagSenar { get; set; }
        public bool flagRecolherFolha { get; set; }
        public bool flagRecolherFonte { get; set; }
        public string ccir { get; set; }
        public string nirf { get; set; }
        public int? qualificacaoUsoPosseId { get; set; }
        public bool anuencia { get; set; }
        public DateTime dataVencimentoContrato { get; set; }
        public string matricula { get; set; }
        public string ativo { get; set; }
        public string permiteDeposito { get; set; }
        public int tipoPropriedade { get; set; }
    }
}
