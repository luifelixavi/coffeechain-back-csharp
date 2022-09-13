using CoffeeChain.Domain.Entities;
using Core.Messages;
using System.Collections.Generic;
using Core.Core.DomainObjects;
using FluentValidation;
using System;

namespace CoffeeChain.Application.Commands
{
    public class AdicionarEntradasCommand : CommandReturnId
    {

        public AdicionarEntradasCommand()
        {

        }

        public AdicionarEntradasCommand(int produtorId, int propriedadeId, int empresaId, int armazemId, DateTime dataEntrada, string codigoLote, decimal qtdSacas, decimal precoLote, decimal custoEntrada, string nfeEntrada, int tipoEntrada, string safra, string tipoCafe, string localArmazenado, string embalagemArmazenado)
        {
            ProdutorId = produtorId;
            PropriedadeId = propriedadeId;
            EmpresaId = empresaId;
            ArmazemId = armazemId;
            DataEntrada = dataEntrada;
            CodigoLote = codigoLote;
            QtdSacas = qtdSacas;
            PrecoLote = precoLote;
            CustoEntrada = custoEntrada;
            NfeEntrada = nfeEntrada;
            TipoEntrada = tipoEntrada;
            Safra = safra;
            TipoCafe = tipoCafe;
            LocalArmazenado = localArmazenado;
            EmbalagemArmazenado = embalagemArmazenado;
        }

        public int ProdutorId { get; set; }
        public int PropriedadeId { get; set; }
        public int EmpresaId { get; set; }
        public int ArmazemId { get; set; }
        public DateTime DataEntrada { get; set; }
        public string CodigoLote { get; set; }
        public decimal QtdSacas { get; set; }
        public decimal PrecoLote { get; set; }
        public decimal CustoEntrada { get; set; }
        public string NfeEntrada { get; set; }
        public int TipoEntrada { get; set; }
        public string Safra { get; set; }
        public string TipoCafe { get; set; }
        public string LocalArmazenado { get; set; }
        public string EmbalagemArmazenado { get; set; }





        public override bool EhValido()
        {
            var result = new EmpresaValidation().Validate(this);
            this.ValidationResult = new Core.Core.DomainObjects.ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        public class EmpresaValidation : AbstractValidator<AdicionarEntradasCommand>
        {

            public EmpresaValidation()
            {

                
            }
        }
    }
}
