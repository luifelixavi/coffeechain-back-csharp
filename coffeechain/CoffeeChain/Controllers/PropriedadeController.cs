using CoffeeChain.Application.Commands;
using CoffeeChain.Application.Queries;
using CoffeeChain.Domain.Entities;
using CoffeeChain.Domain.Interfaces;
using Core.Controllers;
using Core.Mediator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropriedadeController : MainController
    {
        private readonly IMediatorHandler _mediator;
        private readonly ILogger<PropriedadeController> _logger;
        private IPropriedadeRepository _propriedadeRepository;
        public PropriedadeController(ILogger<PropriedadeController> logger, IPropriedadeRepository propriedadeRepository, IMediatorHandler mediator)
        {
            _logger = logger;
            _mediator = mediator;
            _propriedadeRepository = propriedadeRepository;
        }

        [HttpPost]
        public async Task<ActionResult> Post(AdicionarPropriedadeCommand propriedade)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                var result = await _mediator.EnviarComandoReturnId(propriedade);
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
        public IActionResult Put([FromBody] Propriedade propriedade)
        {
            _propriedadeRepository.Update(propriedade);

            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _propriedadeRepository.Delete(id);

            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produtor = _propriedadeRepository.GetOne(id).Result;

            return Ok(produtor);

        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            PropriedadeQuerie produtorQuerie = new PropriedadeQuerie();

            var produtor = await produtorQuerie.GetAllSemFilhos();

            return Ok(produtor);

        }
    }
}
