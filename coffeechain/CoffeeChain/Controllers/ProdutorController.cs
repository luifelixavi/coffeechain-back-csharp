using AutoMapper;
using CoffeeChain.Application.Commands;
using CoffeeChain.Domain.Entities;
using CoffeeChain.Domain.Interfaces;
using Core.Mediator;
using Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using static Core.Controllers.MainController;
using System.Threading.Tasks;
using CoffeeChain.Application.Queries;

namespace CoffeeChain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutorController : MainController
    {

        private readonly IMediatorHandler _mediator;
        private readonly IMapper _mapper;
        private readonly ILogger<ProdutorController> _logger;
        private IProdutorRepository _produtorRepository;
        public ProdutorController(ILogger<ProdutorController> logger,
                                IProdutorRepository produtorRepository,
                                IMediatorHandler mediator)
        {
            _logger = logger;
            _mediator = mediator;
            _produtorRepository = produtorRepository;
        }

        [HttpPost]
        public async Task<ActionResult> Post(AdicionarProdutorCommand produtor)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                var result = await _mediator.EnviarComandoReturnId(produtor);
                if (result.IsValid)
                {
                    return CustomResponse(new TransactionResult(result.TransactionId));
                }
                else
                {
                    return CustomResponse(result);
                }


            }
            catch (Exception ex)
            {
                AdicionarErroProcessamento(ex.Message);
                return CustomResponse();
            }

        }

        [HttpPut]
        public async Task<ActionResult> Put(AtualizarProdutorCommand produtor)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                var result = await _mediator.EnviarComandoReturnId(produtor);
                if (result.IsValid)
                {
                    return CustomResponse(new TransactionResult(result.TransactionId));
                }
                else
                {
                    return CustomResponse(result);
                }


            }
            catch (Exception ex)
            {
                AdicionarErroProcessamento(ex.Message);
                return CustomResponse();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _produtorRepository.Delete(id);

            return Ok();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var ocupacaoProfissional = await _produtorRepository.GetOne(id);
            if (ocupacaoProfissional == null) return NotFound();
            return Ok(ocupacaoProfissional);

        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            ProdutorQuerie produtorQuerie = new ProdutorQuerie();

            var produtor = await produtorQuerie.GetAllSemFilhos();

            return Ok(produtor);

        }
    }
}
