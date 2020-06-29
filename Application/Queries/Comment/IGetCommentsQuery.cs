using Application.DTO;
using Application.SearchDto;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Comment
{
    public interface IGetCommentsQuery : IQuery<CommentSearch,PagedResponse<ReadCommentDto>>
    {
    }
}
