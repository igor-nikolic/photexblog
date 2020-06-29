using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Comment
{
    public interface IGetOneCommentQuery : IQuery<int,ReadCommentDto>
    {
    }
}
