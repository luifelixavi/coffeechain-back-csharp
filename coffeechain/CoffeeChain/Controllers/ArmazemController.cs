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
    public class ArmazemController : MainController
    {
        private readonly IMediatorHandler _mediator;
        private readonly ILogger<ArmazemController> _logger;
        private IArmazemRepository _armazemRepository;
        public ArmazemController(ILogger<ArmazemController> logger, IArmazemRepository armazemRepository, IMediatorHandler mediator)
        {
            _logger = logger;
            _mediator = mediator;
            _armazemRepository = armazemRepository;
        }

        [HttpPost]
        public async Task<ActionResult> Post(AdicionarArmazemCommand armazem)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                var result = await _mediator.EnviarComandoReturnId(armazem);
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
        public IActionResult Put([FromBody] Armazem armazem)
        {
            _armazemRepository.Update(armazem);

            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _armazemRepository.Delete(id);

            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produtor = _armazemRepository.GetOne(id).Result;

            return Ok(produtor);

        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            ArmazemQuerie armazemQuerie = new ArmazemQuerie();

            var produtor = await armazemQuerie.GetAllSemFilhos();

            return Ok(produtor);

        }
    }
}
