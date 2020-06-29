using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Post;
using Application.DTO;
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
    public class PostsController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;
        private readonly IApplicationActor _actor;

        public PostsController(UseCaseExecutor executor, IApplicationActor actor)
        {
            _executor = executor;
            _actor = actor;
        }

        [AllowAnonymous]
        // GET: api/<PostsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [AllowAnonymous]
        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostsController>
        [HttpPost]
        public IActionResult Post([FromForm] UploadPostDto UPDto,[FromServices] ICreatePostCommand command,[FromServices] PostDto dto)
        {            
            if (UPDto.Image == null) 
            {
                return StatusCode(StatusCodes.Status422UnprocessableEntity, new
                {
                    message = "Validation error",
                    Errors = "Image is required!"
                });
            }
            var guid = Guid.NewGuid();
            var extension = Path.GetExtension(UPDto.Image.FileName);
            
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png") 
            {
                return StatusCode(StatusCodes.Status422UnprocessableEntity, new
                {
                    message = "Validation error",
                    Errors = "Only jpg, jpeg and png images are allowed!"
                });
            }
            var FileName = guid + extension;
            var path = Path.Combine("wwwroot", "images", FileName);
            using (var fileStream = new FileStream(path,FileMode.Create))
            {
                UPDto.Image.CopyTo(fileStream);
            }
            dto.UserId = _actor.Id;
            dto.Title = UPDto.Title;
            dto.Content = UPDto.Content;
            dto.PhotoPath = "images/" + FileName;
            dto.TopicId = UPDto.TopicId;
            _executor.ExecuteCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }
        

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] UploadPostDto UPDto,[FromServices] IUpdatePostCommand command, [FromServices] PostDto dto)
        {
            if (id == 0)
            {
                return StatusCode(StatusCodes.Status422UnprocessableEntity, new
                {
                    message = "Validation error",
                    Errors = "Id is required!"
                });
            }
            if (UPDto.Image == null)
            {
                return StatusCode(StatusCodes.Status422UnprocessableEntity, new
                {
                    message = "Validation error",
                    Errors = "Image is required!"
                });
            }
            var guid = Guid.NewGuid();
            var extension = Path.GetExtension(UPDto.Image.FileName);

            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
            {
                return StatusCode(StatusCodes.Status422UnprocessableEntity, new
                {
                    message = "Validation error",
                    Errors = "Only jpg, jpeg and png images are allowed!"
                });
            }
            var FileName = guid + extension;
            var path = Path.Combine("wwwroot", "images", FileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                UPDto.Image.CopyTo(fileStream);
            }
            dto.Id = id;
            dto.Title = UPDto.Title;
            dto.Content = UPDto.Content;
            dto.PhotoPath = "images/" + FileName;
            dto.TopicId = UPDto.TopicId;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,[FromServices] IDeletePostCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
    public class UploadPostDto
    {
        public IFormFile Image { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
    }
}
