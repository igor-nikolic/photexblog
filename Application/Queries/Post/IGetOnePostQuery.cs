using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Post
{
    public interface IGetOnePostQuery : IQuery<int,ReadPostDto>
    {
    }
}
