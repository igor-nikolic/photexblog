using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Rating
{
    public interface IGetOneRatingQuery :IQuery<int,ReadRatingDto>
    {
    }
}
