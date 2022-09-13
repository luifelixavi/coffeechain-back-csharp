using Core.Messages;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Application.Commands
{
    public class AtualizarProdutorCommand : CommandReturnId
    {
        public AtualizarProdutorCommand()
        {
        }

        public AtualizarProdutorCommand(int produtorId, string nomeProdutor, string cpfProdutor, string rgProdutor, string telefoneProdutor, string enderecoProdutor, string cidadeProdutor, string ufProdutor, string emailProdutor, string cepProdutor)
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


        public override bool EhValido()
        {
            var result = new ConjugeValidation().Validate(this);
            this.ValidationResult = new Core.Core.DomainObjects.ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        public class ConjugeValidation : AbstractValidator<AtualizarProdutorCommand>
        {

            public ConjugeValidation()
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
