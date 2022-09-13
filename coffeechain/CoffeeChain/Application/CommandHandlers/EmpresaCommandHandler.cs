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
    public class EmpresaCommandHandler : CommandHandlerReturnId,
        IRequestHandler<AdicionarEmpresaCommand, ValidationResult>,
        IRequestHandler<AtualizarEmpresaCommand, ValidationResult>
    {
        //private readonly IMapper _mapper;
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaCommandHandler(IEmpresaRepository empresaRepository)
        {
            //_mapper = mapper;
            _empresaRepository = empresaRepository;
        }

        public Task<ValidationResult> Handle(AdicionarEmpresaCommand request, CancellationToken cancellationToken)
        {
            if (!request.EhValido())
            {
                //return request.ValidationResult;
            }



            //var produtor = _mapper.Map<Produtor>(request);

            Empresa empresa = new Empresa();

            empresa.RazaoSocial = request.RazaoSocial;
            empresa.NomeFantasia = request.NomeFantasia;
            empresa.CNPJEmpresa = request.CNPJEmpresa;
            empresa.TelefoneEmpresa = request.TelefoneEmpresa;
            empresa.EnderecoEmpresa = request.EnderecoEmpresa;
            empresa.CidadeEmpresa = request.CidadeEmpresa;
            empresa.UfEmpresa = request.UfEmpresa;
            empresa.PaisEmpresa = request.PaisEmpresa;
            empresa.CepEmpresa = request.CepEmpresa;
            empresa.EmailEmpresa = request.EmailEmpresa;

            foreach (var propriedades in request.Armazems)
            {
                empresa.Armazens = new List<Armazem>();
                Armazem armazem = new Armazem();

                armazem.TelefoneArmazem = propriedades.TelefoneArmazem;
                armazem.EnderecoArmazem = propriedades.EnderecoArmazem;
                armazem.CidadeArmazem = propriedades.CidadeArmazem;
                armazem.UfArmazem = propriedades.UfArmazem;
                armazem.EmailArmazem = propriedades.EmailArmazem;
                

                empresa.Armazens.Add(armazem);

            }

            //ApplicationContext _applicationContext = new ApplicationContext();
            //EmpresaRepository _empresaRepository = new EmpresaRepository(_applicationContext);
            _empresaRepository.IncludeEF(empresa);
            return PersistirDados(_empresaRepository.UnitOfWork);
        }

        public Task<ValidationResult> Handle(AtualizarEmpresaCommand request, CancellationToken cancellationToken)
        {
            Empresa empresa = new Empresa();

            empresa.RazaoSocial = request.RazaoSocial;
            empresa.NomeFantasia = request.NomeFantasia;
            empresa.CNPJEmpresa = request.CNPJEmpresa;
            empresa.TelefoneEmpresa = request.TelefoneEmpresa;
            empresa.EnderecoEmpresa = request.EnderecoEmpresa;
            empresa.CidadeEmpresa = request.CidadeEmpresa;
            empresa.UfEmpresa = request.UfEmpresa;
            empresa.PaisEmpresa = request.PaisEmpresa;
            empresa.CepEmpresa = request.CepEmpresa;
            empresa.EmailEmpresa = request.EmailEmpresa;


            ApplicationContext _applicationContext = new ApplicationContext();
            EmpresaRepository _empresaRepository = new EmpresaRepository(_applicationContext);
            _empresaRepository.UpdateEF(empresa);
            return PersistirDados(_empresaRepository.UnitOfWork);
        }
    }

}
