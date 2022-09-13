using CoffeeChain.Application.Commands;
using CoffeeChain.Application.Queries;
using CoffeeChain.Domain.Entities;
using CoffeeChain.Domain.Interfaces;
using Core.Controllers;
using Core.Mediator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CoffeeChain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntradasController : MainController
    {
        private readonly IMediatorHandler _mediator;
        private readonly ILogger<EntradasController> _logger;
        private IEntradasRepository _entradasRepository;
        public EntradasController(ILogger<EntradasController> logger, IEntradasRepository entradasRepository, IMediatorHandler mediator)
        {
            _logger = logger;
            _entradasRepository = entradasRepository;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post(AdicionarEntradasCommand entradas)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                var result = await _mediator.EnviarComandoReturnId(entradas);
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
        public IActionResult Put([FromBody] Entradas entradas)
        {
            _entradasRepository.Update(entradas);

            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _entradasRepository.Delete(id);

            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produtor = _entradasRepository.GetOne(id).Result;

            return Ok(produtor);

        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            EntradasQuerie produtorQuerie = new EntradasQuerie();

            var produtor = await produtorQuerie.GetAllSemFilhos();

            return Ok(produtor);

        }
    }
}
