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
    public class ProdutorCommandHandler : CommandHandlerReturnId,
        IRequestHandler<AdicionarProdutorCommand, ValidationResult>,
        IRequestHandler<AtualizarProdutorCommand, ValidationResult>
    {
        //private readonly IMapper _mapper;
        private readonly IProdutorRepository _produtorRepository;

        public ProdutorCommandHandler(IProdutorRepository produtorRepository)
        {
            //_mapper = mapper;
            _produtorRepository = produtorRepository;
        }

        public Task<ValidationResult> Handle(AdicionarProdutorCommand request, CancellationToken cancellationToken)
        {
            if (!request.EhValido())
            {
                //return request.ValidationResult;
            }





            //var produtor = _mapper.Map<Produtor>(request);

            Produtor produtor = new Produtor();

            produtor.CepProdutor = request.CepProdutor;
            produtor.CidadeProdutor = request.CidadeProdutor;
            produtor.CpfProdutor = request.CpfProdutor;
            produtor.EnderecoProdutor = request.EnderecoProdutor;
            produtor.RgProdutor = request.RgProdutor;
            produtor.UfProdutor = request.UfProdutor;
            produtor.TelefoneProdutor = request.TelefoneProdutor;
            produtor.NomeProdutor = request.NomeProdutor;
            produtor.EmailProdutor = request.EmailProdutor;

            if (request.Propriedades != null)
            {
                foreach (var propriedades in request.Propriedades)
                {
                    produtor.Propriedades = new List<Propriedade>();
                    Propriedade propriedade = new Propriedade();

                    propriedade.NomeFazenda = propriedades.NomeFazenda;
                    propriedade.CNPJFazenda = propriedades.CNPJFazenda;
                    propriedade.InscEstadual = propriedades.InscEstadual;
                    propriedade.TelefonePropriedade = propriedades.TelefonePropriedade;
                    propriedade.EnderecoPropriedade = propriedades.EnderecoPropriedade;
                    propriedade.CidadePropriedade = propriedades.CidadePropriedade;
                    propriedade.UfPropriedade = propriedades.UfPropriedade;
                    propriedade.EmailPropriedade = propriedades.EmailPropriedade;
                    propriedade.CepPropriedade = propriedades.CepPropriedade;

                    produtor.Propriedades.Add(propriedade);

                }
            }

           


            //ApplicationContext _applicationContext = new ApplicationContext();
            //ProdutorRepository _produtorRepository = new ProdutorRepository(_applicationContext);
            _produtorRepository.IncludeEF(produtor);
            return PersistirDados(_produtorRepository.UnitOfWork);
        }

        public Task<ValidationResult> Handle(AtualizarProdutorCommand request, CancellationToken cancellationToken)
        {
            Produtor produtor = new Produtor();

            produtor.ProdutorId = request.ProdutorId;
            produtor.CepProdutor = request.CepProdutor;
            produtor.CidadeProdutor = request.CidadeProdutor;
            produtor.CpfProdutor = request.CpfProdutor;
            produtor.EnderecoProdutor = request.EnderecoProdutor;
            produtor.RgProdutor = request.RgProdutor;
            produtor.UfProdutor = request.UfProdutor;
            produtor.TelefoneProdutor = request.TelefoneProdutor;
            produtor.NomeProdutor = request.NomeProdutor;
            produtor.EmailProdutor = request.EmailProdutor;


            ApplicationContext _applicationContext = new ApplicationContext();
            ProdutorRepository _produtorRepository = new ProdutorRepository(_applicationContext);
            _produtorRepository.UpdateEF(produtor);
            return PersistirDados(_produtorRepository.UnitOfWork);
        }
    }

}
