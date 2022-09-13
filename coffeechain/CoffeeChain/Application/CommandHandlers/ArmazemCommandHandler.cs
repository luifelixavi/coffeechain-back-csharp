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
    public class ArmazemCommandHandler : CommandHandlerReturnId,
        IRequestHandler<AdicionarArmazemCommand, ValidationResult>,
        IRequestHandler<AtualizarArmazemCommand, ValidationResult>
    {
        //private readonly IMapper _mapper;
        private readonly IArmazemRepository _armazemRepository;
        private readonly IEmpresaRepository _empresaRepository;

        public ArmazemCommandHandler(IArmazemRepository armazemRepository, IEmpresaRepository empresaRepository)
        {
            //_mapper = mapper;
            _armazemRepository = armazemRepository;
            _empresaRepository = empresaRepository;
        }

        public async Task<ValidationResult> Handle(AdicionarArmazemCommand request, CancellationToken cancellationToken)
        {
            if (!request.EhValido())
            {
                return request.ValidationResult;
            }

            var empresa = await _empresaRepository.GetOne((int)request.EmpresaId);
            
            if (empresa == null)
            {
                AdicionarErro("Não existe empresa com esse id");
                return ValidationResult;
            }



            //var produtor = _mapper.Map<Produtor>(request);

            Armazem armazem = new Armazem();

            armazem.EmpresaId = request.EmpresaId;
            armazem.TelefoneArmazem = request.TelefoneArmazem;
            armazem.EnderecoArmazem = request.EnderecoArmazem;
            armazem.CidadeArmazem = request.CidadeArmazem;
            armazem.UfArmazem = request.UfArmazem;
            armazem.EmailArmazem = request.EmailArmazem;
            



           
            //ArmazemRepository _armazemRepository = new ArmazemRepository(_applicationContext);
            
            _armazemRepository.IncludeEF(armazem);
            return await PersistirDados(_armazemRepository.UnitOfWork);
        }

        public Task<ValidationResult> Handle(AtualizarArmazemCommand request, CancellationToken cancellationToken)
        {
            Armazem armazem = new Armazem();

            armazem.TelefoneArmazem = request.TelefoneArmazem;
            armazem.EnderecoArmazem = request.EnderecoArmazem;
            armazem.CidadeArmazem = request.CidadeArmazem;
            armazem.UfArmazem = request.UfArmazem;
            armazem.EmailArmazem = request.EmailArmazem;


            ApplicationContext _applicationContext = new ApplicationContext();
            ArmazemRepository _armazemRepository = new ArmazemRepository(_applicationContext);
            _armazemRepository.UpdateEF(armazem);
            return PersistirDados(_armazemRepository.UnitOfWork);
        }
    }

}
