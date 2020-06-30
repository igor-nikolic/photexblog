using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Rating;
using Application.DTO;
using Application.Queries.Rating;
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
    public class RatingsController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public RatingsController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        [AllowAnonymous]
        // GET: api/<RatingsController>
        [HttpGet]
        public IActionResult Get([FromQuery] RatingSearch search,[FromServices] IGetRatingsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        [AllowAnonymous]
        // GET api/<RatingsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id,[FromServices] IGetOneRatingQuery query)
        {
            return Ok(_executor.ExecuteQuery(query,id));
        }

        // POST api/<RatingsController>
        [HttpPost]
        public IActionResult Post([FromBody] RatingDto dto,[FromServices] ICreateRatingCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<RatingsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] RatingDto dto,[FromServices] IUpdateRatingCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }
        
    }
}
