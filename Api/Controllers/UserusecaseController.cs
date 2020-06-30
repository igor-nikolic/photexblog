using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.UserUseCase;
using Application.DTO;
using Application.Queries.UserUseCase;
using Application.SearchDto;
using Application.UseCase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserusecaseController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public UserusecaseController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<UserusecaseController>
        [HttpGet]
        public IActionResult Get([FromQuery] UserUseCaseSearch search,[FromServices] IGetUsersUseCasesQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }
        

        // POST api/<UserusecaseController>
        [HttpPost]
        public IActionResult Post([FromBody] UserUseCaseDto dto,[FromServices] ICreateUserUseCaseCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        
    }
}
