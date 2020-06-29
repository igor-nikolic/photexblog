using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Post
{
    public interface IUpdatePostCommand : ICommand<PostDto>
    {
    }
}
