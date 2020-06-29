using System.Collections.Generic;
using Application.Commands.Comments;
using Application.DTO;
using Application.Queries.Comment;
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
    public class CommentsController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public CommentsController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        [AllowAnonymous]
        // GET: api/<CommentsController>
        [HttpGet]
        public IActionResult Get([FromQuery] CommentSearch search,[FromServices] IGetCommentsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        [AllowAnonymous]
        // GET api/<CommentsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id,[FromServices] IGetOneCommentQuery query)
        {
            return Ok(_executor.ExecuteQuery(query,id));
        }

        // POST api/<CommentsController>
        [HttpPost]
        public IActionResult Post([FromBody] CommentDto dto,[FromServices] ICreateCommentCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<CommentsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CommentDto dto,[FromServices] IUpdateCommentCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<CommentsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,[FromServices] IDeleteCommentCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
