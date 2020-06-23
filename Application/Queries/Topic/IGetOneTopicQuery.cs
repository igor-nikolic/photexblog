using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Topic
{
    public interface IGetOneTopicQuery : IQuery<int,ReadTopicDto>
    {
    }
}
