using CoffeeChain.Domain.Entities;
using Core.Messages;
using System.Collections.Generic;
using Core.Core.DomainObjects;
using FluentValidation;

namespace CoffeeChain.Application.Commands
{
    public class AtualizarArmazemCommand : CommandReturnId
    {

        public AtualizarArmazemCommand()
        {

        }

        public AtualizarArmazemCommand(int armazemId, int empresaId, string telefoneArmazem, string enderecoArmazem, string cidadeArmazem, string ufArmazem, string emailArmazem)
        {
            ArmazemId = armazemId;
            EmpresaId = empresaId;
            TelefoneArmazem = telefoneArmazem;
            EnderecoArmazem = enderecoArmazem;
            CidadeArmazem = cidadeArmazem;
            UfArmazem = ufArmazem;
            EmailArmazem = emailArmazem;
        }

        public int ArmazemId { get; set; }
        public int EmpresaId { get; set; }
        public string TelefoneArmazem { get; set; }
        public string EnderecoArmazem { get; set; }
        public string CidadeArmazem { get; set; }
        public string UfArmazem { get; set; }
        public string EmailArmazem { get; set; }
        




        public override bool EhValido()
        {
            var result = new EmpresaValidation().Validate(this);
            this.ValidationResult = new Core.Core.DomainObjects.ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        public class EmpresaValidation : AbstractValidator<AtualizarArmazemCommand>
        {

            public EmpresaValidation()
            {

                
            }
        }
    }
}
