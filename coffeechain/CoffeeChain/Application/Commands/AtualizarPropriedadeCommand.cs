using CoffeeChain.Domain.Entities;
using Core.Messages;
using System.Collections.Generic;
using Core.Core.DomainObjects;
using FluentValidation;

namespace CoffeeChain.Application.Commands
{
    public class AdicionarPropriedadeCommand : CommandReturnId
    {

        public AdicionarPropriedadeCommand()
        {

        }

        public AdicionarPropriedadeCommand(int produtorId, string nomeFazenda, string cNPJFazenda, string inscEstadual, string telefonePropriedade, string enderecoPropriedade, string cidadePropriedade, string ufPropriedade, string emailPropriedade, string cepPropriedade)
        {
            ProdutorId = produtorId;
            NomeFazenda = nomeFazenda;
            CNPJFazenda = cNPJFazenda;
            InscEstadual = inscEstadual;
            TelefonePropriedade = telefonePropriedade;
            EnderecoPropriedade = enderecoPropriedade;
            CidadePropriedade = cidadePropriedade;
            UfPropriedade = ufPropriedade;
            EmailPropriedade = emailPropriedade;
            CepPropriedade = cepPropriedade;
        }

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


        public override bool EhValido()
        {
            var result = new PropriedadeValidation().Validate(this);
            this.ValidationResult = new Core.Core.DomainObjects.ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        public class PropriedadeValidation : AbstractValidator<AdicionarPropriedadeCommand>
        {

            public PropriedadeValidation()
            {

                
            }
        }
    }
}
