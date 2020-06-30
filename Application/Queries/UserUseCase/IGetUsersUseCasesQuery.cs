using Application.DTO;
using Application.SearchDto;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.UserUseCase
{
    public interface IGetUsersUseCasesQuery : IQuery<UserUseCaseSearch,PagedResponse<ReadUserUseCaseDto>>
    {
    }
}
