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
    public class SaidasController : MainController
    {
        private readonly ILogger<SaidasController> _logger;
        private readonly IMediatorHandler _mediator;
        private ISaidasRepository _saidasRepository;
        public SaidasController(ILogger<SaidasController> logger, ISaidasRepository saidasRepository, IMediatorHandler mediator)
        {
            _logger = logger;
            _saidasRepository = saidasRepository;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post(AdicionarSaidasCommand saidas)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                var result = await _mediator.EnviarComandoReturnId(saidas);
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
        public IActionResult Put([FromBody] Saidas saidas)
        {
            _saidasRepository.Update(saidas);

            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _saidasRepository.Delete(id);

            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produtor = _saidasRepository.GetOne(id).Result;

            return Ok(produtor);

        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            SaidasQuerie produtorQuerie = new SaidasQuerie();

            var produtor = await produtorQuerie.GetAllSemFilhos();

            return Ok(produtor);

        }
    }
}
