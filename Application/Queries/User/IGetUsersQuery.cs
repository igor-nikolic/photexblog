using Application.DTO;
using Application.SearchDto;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.User
{
    public interface IGetUsersQuery : IQuery<UserSearch,PagedResponse<ReadUserDto>>
    {
    }
}
