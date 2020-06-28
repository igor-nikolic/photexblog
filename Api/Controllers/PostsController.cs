using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Post;
using Application.DTO;
using Application.UseCase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public PostsController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<PostsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostsController>
        [HttpPost]
        public IActionResult Post([FromForm] UploadPostDto UPDto,[FromServices] ICreatePostCommand command,PostDto dto)
        {
            var guid = Guid.NewGuid();
            var extension = Path.GetExtension(UPDto.Image.FileName);

            var FileName = guid + extension;
            var path = Path.Combine("wwwroot", "images", FileName);
            using (var fileStream = new FileStream(path,FileMode.Create))
            {
                UPDto.Image.CopyTo(fileStream);
            }
            dto.Title = UPDto.Title;
            dto.Content = UPDto.Content;
            dto.PhotoPath = "images/" + FileName;            
            _executor.ExecuteCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class UploadPostDto
    {
        public IFormFile Image { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
