using Application.DTO;
using Application.SearchDto;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Post
{
    public interface IGetPostsQuery : IQuery<PostSearch,PagedResponse<ReadPostDto>>
    {
    }
}
