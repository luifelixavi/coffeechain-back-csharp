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
    public class SaidasCommandHandler : CommandHandlerReturnId,
        IRequestHandler<AdicionarSaidasCommand, ValidationResult>,
        IRequestHandler<AtualizarSaidasCommand, ValidationResult>
    {
        //private readonly IMapper _mapper;
        private readonly IProdutorRepository _produtorRepository;
        private readonly ISaidasRepository _saidasRepository;
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IPropriedadeRepository _propriedadeRepository;
        private readonly IEntradasRepository _entradasRepository;
        private readonly IArmazemRepository _armazemRepository;

        public SaidasCommandHandler(ISaidasRepository saidasRepository,
                                    IProdutorRepository produtorRepository,
                                    IEmpresaRepository empresaRepository,
                                    IPropriedadeRepository propriedadeRepository,
                                    IEntradasRepository entradasRepository,
                                    IArmazemRepository armazemRepository)
        {
            //_mapper = mapper;
            _produtorRepository = produtorRepository;
            _saidasRepository = saidasRepository;
            _empresaRepository = empresaRepository;
            _propriedadeRepository = propriedadeRepository;
            _entradasRepository = entradasRepository;
            _armazemRepository = armazemRepository;
        }

        public async Task<ValidationResult> Handle(AdicionarSaidasCommand request, CancellationToken cancellationToken)
        {
            if (!request.EhValido())
            {
                //return request.ValidationResult;
            }


            var empresa = await _empresaRepository.GetOne((int)request.DestinoEmpresaId);
            var produtor = await _produtorRepository.GetOne((int)request.DestinoProdutorId);
            var propriedade = await _propriedadeRepository.GetOne((int)request.DestinoPropriedadeId);
            var entrada = await _entradasRepository.GetOne((int)request.EntradaId);
            var armazem = await _armazemRepository.GetOne((int)request.DestinoArmazemId);

            if (produtor == null)
            {
                AdicionarErro("Não existe produtor com esse id");
                return ValidationResult;
            }
            if (empresa == null)
            {
                AdicionarErro("Não existe empresa com esse id");
                return ValidationResult;
            }
            if (propriedade == null)
            {
                AdicionarErro("Não existe propriedade com esse id");
                return ValidationResult;
            }
            if (entrada == null)
            {
                AdicionarErro("Não existe entrada com esse id");
                return ValidationResult;
            }
            if (armazem == null)
            {
                AdicionarErro("Não existe armazem com esse id");
                return ValidationResult;
            }



            //var produtor = _mapper.Map<Produtor>(request);

            Saidas saidas = new Saidas();

            saidas.DestinoProdutorId = request.DestinoProdutorId;
            saidas.DestinoPropriedadeId = request.DestinoPropriedadeId;
            saidas.DestinoEmpresaId = request.DestinoEmpresaId;
            saidas.EntradaId = request.EntradaId;
            saidas.DestinoArmazemId = request.DestinoArmazemId;
            saidas.DataSaida = request.DataSaida;
            saidas.QtdSacas = request.QtdSacas;
            saidas.TipoSaida = request.TipoSaida;
            saidas.PrecoSaida = request.PrecoSaida;
            saidas.CustoSaida = request.CustoSaida;
            saidas.NfeSaida = request.NfeSaida;
            saidas.EmbalagemSaida = request.EmbalagemSaida;
            

            _saidasRepository.IncludeEF(saidas);
            return await PersistirDados(_saidasRepository.UnitOfWork);
        }

        public Task<ValidationResult> Handle(AtualizarSaidasCommand request, CancellationToken cancellationToken)
        {
            Saidas saidas = new Saidas();

            saidas.DestinoProdutorId = request.DestinoProdutorId;
            saidas.DestinoPropriedadeId = request.DestinoPropriedadeId;
            saidas.DestinoEmpresaId = request.DestinoEmpresaId;
            saidas.EntradaId = request.EntradaId;
            saidas.DestinoArmazemId = request.DestinoArmazemId;
            saidas.DataSaida = request.DataSaida;
            saidas.QtdSacas = request.QtdSacas;
            saidas.TipoSaida = request.TipoSaida;
            saidas.PrecoSaida = request.PrecoSaida;
            saidas.CustoSaida = request.CustoSaida;
            saidas.NfeSaida = request.NfeSaida;
            saidas.EmbalagemSaida = request.EmbalagemSaida;


            _saidasRepository.UpdateEF(saidas);
            return PersistirDados(_produtorRepository.UnitOfWork);
        }
    }

}
