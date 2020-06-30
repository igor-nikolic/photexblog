using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.UseCase;
using Application.DTO;
using Application.Queries.UseCase;
using Application.SearchDto;
using Application.UseCase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsecasesController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public UsecasesController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<UsecaseController>
        [HttpGet]
        public IActionResult Get([FromQuery] UseCaseSearch search,[FromServices] IGetUseCasesQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<UsecaseController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id,[FromServices] IGetOneUseCaseQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        // POST api/<UsecaseController>
        [HttpPost]
        public IActionResult Post([FromBody] UseCaseDto dto,[FromServices] ICreateUseCaseCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<UsecaseController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UseCaseDto dto,[FromServices] IUpdateUseCaseCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<UsecaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
