using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Queries.UseCaseLog;
using Application.SearchDto;
using Application.UseCase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public LogsController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<LogController>
        [HttpGet]
        public IActionResult Get([FromQuery] UseCaseLogSearch search,[FromServices] IGetUseCaseLogsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }


    }
}
