using Application.DTO;
using Application.SearchDto;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.UseCase
{
    public interface IGetUseCasesQuery : IQuery<UseCaseSearch,PagedResponse<ReadUseCaseDto>>
    {
    }
}
