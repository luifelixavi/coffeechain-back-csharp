using AutoMapper;
using CoffeeChain.Application.Commands;
using CoffeeChain.Data;
using CoffeeChain.Domain.Entities;
using CoffeeChain.Domain.Interfaces;
using CoffeeChain.Infra.Data.Repository;
using Core.Core.DomainObjects;
using Core.Messages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeChain.Application.CommandHandlers
{
    public class EntradasCommandHandler : CommandHandlerReturnId,
        IRequestHandler<AdicionarEntradasCommand, ValidationResult>,
        IRequestHandler<AtualizarEntradasCommand, ValidationResult>
    {
        //private readonly IMapper _mapper;
        private readonly IEntradasRepository _entradasRepository;

        public EntradasCommandHandler(IEntradasRepository entradasRepository)
        {
            //_mapper = mapper;
            _entradasRepository = entradasRepository;
        }

        public Task<ValidationResult> Handle(AdicionarEntradasCommand request, CancellationToken cancellationToken)
        {
            if (!request.EhValido())
            {
                //return request.ValidationResult;
            }



            //var produtor = _mapper.Map<Produtor>(request);

            Entradas entradas = new Entradas();

            entradas.ProdutorId = request.ProdutorId;
            entradas.PropriedadeId = request.PropriedadeId;
            entradas.EmpresaId = request.EmpresaId;
            entradas.ArmazemId = request.ArmazemId;
            entradas.DataEntrada = request.DataEntrada;
            entradas.CodigoLote = request.CodigoLote;
            entradas.QtdSacas = request.QtdSacas;
            entradas.PrecoLote = request.PrecoLote;
            entradas.CustoEntrada = request.CustoEntrada;
            entradas.NfeEntrada = request.NfeEntrada;
            entradas.TipoEntrada = request.TipoEntrada;
            entradas.Safra = request.Safra;
            entradas.TipoCafe = request.TipoCafe;
            entradas.LocalArmazenado = request.LocalArmazenado;
            entradas.EmbalagemArmazenado = request.EmbalagemArmazenado;



            //ApplicationContext _applicationContext = new ApplicationContext();
            //EntradasRepository _entradasRepository = new EntradasRepository(_applicationContext);
            _entradasRepository.IncludeEF(entradas);
            return PersistirDados(_entradasRepository.UnitOfWork);
        }

        public Task<ValidationResult> Handle(AtualizarEntradasCommand request, CancellationToken cancellationToken)
        {
            Entradas entradas = new Entradas();

            entradas.ProdutorId = request.ProdutorId;
            entradas.PropriedadeId = request.PropriedadeId;
            entradas.EmpresaId = request.EmpresaId;
            entradas.ArmazemId = request.ArmazemId;
            entradas.DataEntrada = request.DataEntrada;
            entradas.CodigoLote = request.CodigoLote;
            entradas.QtdSacas = request.QtdSacas;
            entradas.PrecoLote = request.PrecoLote;
            entradas.CustoEntrada = request.CustoEntrada;
            entradas.NfeEntrada = request.NfeEntrada;
            entradas.TipoEntrada = request.TipoEntrada;
            entradas.Safra = request.Safra;
            entradas.TipoCafe = request.TipoCafe;
            entradas.LocalArmazenado = request.LocalArmazenado;
            entradas.EmbalagemArmazenado = request.EmbalagemArmazenado;


            ApplicationContext _applicationContext = new ApplicationContext();
            EntradasRepository _entradasRepository = new EntradasRepository(_applicationContext);
            _entradasRepository.UpdateEF(entradas);
            return PersistirDados(_entradasRepository.UnitOfWork);
        }
    }

}
