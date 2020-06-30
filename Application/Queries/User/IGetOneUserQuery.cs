using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.User
{
    public interface IGetOneUserQuery : IQuery<int,ReadUserDto>
    {
    }
}
