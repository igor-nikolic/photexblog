using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Core;
using Application.Commands;
using Application.Commands.User;
using Application.DTO;
using Application.Queries.User;
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
    public class UsersController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;
        private readonly JwtManager _manager;

        public UsersController(UseCaseExecutor executor, JwtManager manager)
        {
            _executor = executor;
            _manager = manager;
        }

        [AllowAnonymous]
        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get([FromQuery] UserSearch search,[FromServices] IGetUsersQuery query)
        {
            return Ok(_executor.ExecuteQuery(query,search));
        }
        
        [AllowAnonymous]
        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id,[FromServices] IGetOneUserQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        [AllowAnonymous]
        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] UserDto dto,[FromServices] ICreateUserCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserDto dto,[FromServices] IUpdateUserCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,[FromServices] IDeleteUserCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }

        [AllowAnonymous]
        [HttpPost("gettoken")]
        public IActionResult GetToken([FromBody] TokenDto dto) 
        {
            var token = _manager.MakeToken(dto.Email, dto.Password);
            if (token == null) return Unauthorized();
            return Ok(new { token });
        }
    }
}
