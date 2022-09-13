using CoffeeChain.Domain.Entities;
using Core.Messages;
using System.Collections.Generic;
using Core.Core.DomainObjects;
using FluentValidation;
using System;

namespace CoffeeChain.Application.Commands
{
    public class AdicionarSaidasCommand : CommandReturnId
    {

        public AdicionarSaidasCommand()
        {

        }

        public AdicionarSaidasCommand(int destinoProdutorId, int destinoPropriedadeId, int destinoEmpresaId, int entradaId, int destinoArmazemId, DateTime dataSaida, decimal qtdSacas, int tipoSaida, decimal precoSaida, decimal custoSaida, string nfeSaida, string embalagemSaida)
        {
            DestinoProdutorId = destinoProdutorId;
            DestinoPropriedadeId = destinoPropriedadeId;
            DestinoEmpresaId = destinoEmpresaId;
            EntradaId = entradaId;
            DestinoArmazemId = destinoArmazemId;
            DataSaida = dataSaida;
            QtdSacas = qtdSacas;
            TipoSaida = tipoSaida;
            PrecoSaida = precoSaida;
            CustoSaida = custoSaida;
            NfeSaida = nfeSaida;
            EmbalagemSaida = embalagemSaida;
        }

        public int DestinoProdutorId { get; set; }
        public int DestinoPropriedadeId { get; set; }
        public int DestinoEmpresaId { get; set; }
        public int EntradaId { get; set; }
        public int DestinoArmazemId { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal QtdSacas { get; set; }
        public int TipoSaida { get; set; }
        public decimal PrecoSaida { get; set; }
        public decimal CustoSaida { get; set; }
        public string NfeSaida { get; set; }
        public string EmbalagemSaida { get; set; }





        public override bool EhValido()
        {
            var result = new EmpresaValidation().Validate(this);
            this.ValidationResult = new Core.Core.DomainObjects.ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        public class EmpresaValidation : AbstractValidator<AdicionarSaidasCommand>
        {

            public EmpresaValidation()
            {

                
            }
        }
    }
}
