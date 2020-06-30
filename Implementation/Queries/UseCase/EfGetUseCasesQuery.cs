using Application.DTO;
using Application.Queries;
using Application.Queries.UseCase;
using Application.SearchDto;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.UseCase
{
    public class EfGetUseCasesQuery : IGetUseCasesQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetUseCasesQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 28;

        public string Name => "Search UseCases";

        public PagedResponse<ReadUseCaseDto> Execute(UseCaseSearch search)
        {
            var query = _context.UseCases.AsQueryable();

            if(!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);


            var response = new PagedResponse<ReadUseCaseDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ReadUseCaseDto
                {
                    Id=x.Id,
                    Name=x.Name,
                    NumberOfUseCaseLogs=x.UseCaseLogs.Count(),
                    NumberOfUsers=x.UserUseCases.Count()
                }).ToList()
            };

            return response;
        }
    }
}
