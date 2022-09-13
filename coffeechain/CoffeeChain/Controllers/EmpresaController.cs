using AutoMapper;
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
using static Core.Controllers.MainController;

namespace CoffeeChain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : MainController
    {
        private readonly ILogger<EmpresaController> _logger;
        private IEmpresaRepository _empresaRepository;
        private readonly IMediatorHandler _mediator;
        private readonly IMapper _mapper;
        public EmpresaController(ILogger<EmpresaController> logger, IEmpresaRepository empresaRepository, IMediatorHandler mediator)
        {
            _logger = logger;
            _empresaRepository = empresaRepository;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post(AdicionarEmpresaCommand empresa)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                var result = await _mediator.EnviarComandoReturnId(empresa);
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
        public IActionResult Put([FromBody] Empresa empresa)
        {
            _empresaRepository.Update(empresa);

            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _empresaRepository.Delete(id);

            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produtor = _empresaRepository.GetOne(id).Result;

            return Ok(produtor);

        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            EmpresaQuerie empresaQuerie = new EmpresaQuerie();

            var produtor = await empresaQuerie.GetAllSemFilhos();

            return Ok(produtor);

        }
    }
}
