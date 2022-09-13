using CoffeeChain.Domain.Entities;
using Core.Messages;
using System.Collections.Generic;
using Core.Core.DomainObjects;
using FluentValidation;

namespace CoffeeChain.Application.Commands
{
    public class AtualizarEmpresaCommand : CommandReturnId
    {

        public AtualizarEmpresaCommand()
        {

        }

        public AtualizarEmpresaCommand(string razaoSocial, string nomeFantasia, string cNPJEmpresa, string telefoneEmpresa, string enderecoEmpresa, string cidadeEmpresa, string ufEmpresa, string paisEmpresa, string cepEmpresa, string emailEmpresa)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJEmpresa = cNPJEmpresa;
            TelefoneEmpresa = telefoneEmpresa;
            EnderecoEmpresa = enderecoEmpresa;
            CidadeEmpresa = cidadeEmpresa;
            UfEmpresa = ufEmpresa;
            PaisEmpresa = paisEmpresa;
            CepEmpresa = cepEmpresa;
            EmailEmpresa = emailEmpresa;
        }

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


        public override bool EhValido()
        {
            var result = new EmpresaValidation().Validate(this);
            this.ValidationResult = new Core.Core.DomainObjects.ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        public class EmpresaValidation : AbstractValidator<AtualizarEmpresaCommand>
        {

            public EmpresaValidation()
            {

                
            }
        }
    }
}
