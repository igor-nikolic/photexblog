using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.UseCase
{
    public interface IGetOneUseCaseQuery : IQuery<int,ReadUseCaseDto>
    {
    }
}
