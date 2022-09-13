using CoffeeChain.Domain.Entities;
using Core.Messages;
using System.Collections.Generic;
using Core.Core.DomainObjects;
using FluentValidation;

namespace CoffeeChain.Application.Commands
{
    public class AdicionarProdutorCommand : CommandReturnId
    {

        public AdicionarProdutorCommand ()
        {

        }
        public AdicionarProdutorCommand(int produtorId, string nomeProdutor, string cpfProdutor, string rgProdutor, string telefoneProdutor, string enderecoProdutor, string cidadeProdutor, string ufProdutor, string emailProdutor, string cepProdutor, List<Propriedade> propriedades, List<Entradas> entradas, List<Saidas> saidas)
        {
            ProdutorId = produtorId;
            NomeProdutor = nomeProdutor;
            CpfProdutor = cpfProdutor;
            RgProdutor = rgProdutor;
            TelefoneProdutor = telefoneProdutor;
            EnderecoProdutor = enderecoProdutor;
            CidadeProdutor = cidadeProdutor;
            UfProdutor = ufProdutor;
            EmailProdutor = emailProdutor;
            CepProdutor = cepProdutor;
            //Propriedades = propriedades;
            //Entradas = entradas;
            //Saidas = saidas;
        }

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
        public List<AdicionarPropriedadeCommand> Propriedades { get; set; }
        //public List<Entradas> Entradas { get; set; }
        //public List<Saidas> Saidas { get; set; }


        public override bool EhValido()
        {
            var result = new ProdutorValidation().Validate(this);
            this.ValidationResult = new Core.Core.DomainObjects.ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        public class ProdutorValidation : AbstractValidator<AdicionarProdutorCommand>
        {

            public ProdutorValidation()
            {

                RuleFor(c => c.NomeProdutor)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.CpfProdutor)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.RgProdutor)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.TelefoneProdutor)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.EnderecoProdutor)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.CidadeProdutor)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.UfProdutor)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(2).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.EmailProdutor)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.CepProdutor)
                .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");
            }
        }
    }
}
