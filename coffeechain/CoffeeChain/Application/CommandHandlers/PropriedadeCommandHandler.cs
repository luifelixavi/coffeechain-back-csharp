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
    public class PropriedadeCommandHandler : CommandHandlerReturnId,
        IRequestHandler<AdicionarPropriedadeCommand, ValidationResult>,
        IRequestHandler<AtualizarPropriedadeCommand, ValidationResult>
    {
        //private readonly IMapper _mapper;
        private readonly IPropriedadeRepository _propriedadeRepository;
        private readonly IProdutorRepository _produtorRepository;

        public PropriedadeCommandHandler(IPropriedadeRepository propriedadeRepository, IProdutorRepository produtorRepository)
        {
            //_mapper = mapper;
            _propriedadeRepository = propriedadeRepository;
            _produtorRepository = produtorRepository;
        }

        public async Task<ValidationResult> Handle(AdicionarPropriedadeCommand request, CancellationToken cancellationToken)
        {
            if (!request.EhValido())
            {
                //return request.ValidationResult;
            }



            var empresa = await _produtorRepository.GetOne((int)request.ProdutorId);

            if (empresa == null)
            {
                AdicionarErro("Não existe produtor com esse id");
                return ValidationResult;
            }



            //var produtor = _mapper.Map<Produtor>(request);

            Propriedade propriedade = new Propriedade();

            propriedade.ProdutorId = request.ProdutorId;
            propriedade.NomeFazenda = request.NomeFazenda;
            propriedade.CNPJFazenda = request.CNPJFazenda;
            propriedade.InscEstadual = request.InscEstadual;
            propriedade.TelefonePropriedade = request.TelefonePropriedade;
            propriedade.EnderecoPropriedade = request.EnderecoPropriedade;
            propriedade.CidadePropriedade = request.CidadePropriedade;
            propriedade.UfPropriedade = request.UfPropriedade;
            propriedade.EmailPropriedade = request.EmailPropriedade;
            propriedade.CepPropriedade = request.CepPropriedade;


            _propriedadeRepository.IncludeEF(propriedade);
            return await PersistirDados(_propriedadeRepository.UnitOfWork);
        }

        public Task<ValidationResult> Handle(AtualizarPropriedadeCommand request, CancellationToken cancellationToken)
        {
            Propriedade propriedade = new Propriedade();

            propriedade.NomeFazenda = request.NomeFazenda;
            propriedade.CNPJFazenda = request.CNPJFazenda;
            propriedade.InscEstadual = request.InscEstadual;
            propriedade.TelefonePropriedade = request.TelefonePropriedade;
            propriedade.EnderecoPropriedade = request.EnderecoPropriedade;
            propriedade.CidadePropriedade = request.CidadePropriedade;
            propriedade.UfPropriedade = request.UfPropriedade;
            propriedade.EmailPropriedade = request.EmailPropriedade;
            propriedade.CepPropriedade = request.CepPropriedade;



            _propriedadeRepository.UpdateEF(propriedade);
            return PersistirDados(_propriedadeRepository.UnitOfWork);
        }
    }

}
