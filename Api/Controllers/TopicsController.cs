using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Topic;
using Application.DTO;
using Application.Queries.Topic;
using Application.UseCase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public TopicsController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<TopicsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TopicsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id,[FromServices] IGetOneTopicQuery query)
        {
            return Ok(_executor.ExecuteQuery(query,id));
        }

        // POST api/<TopicsController>
        [HttpPost]
        public IActionResult Post([FromBody] TopicDto dto,[FromServices] ICreateTopicCommand command)
        {
            _executor.ExecuteCommand(command,dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<TopicsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TopicDto dto,[FromServices] IUpdateTopicCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<TopicsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,[FromServices] IDeleteTopicCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
