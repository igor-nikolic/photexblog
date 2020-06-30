using Application.DTO;
using Application.Queries;
using Application.Queries.UserUseCase;
using Application.SearchDto;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.UserUseCase
{
    public class EfGetUsersUseCasesQuery : IGetUsersUseCasesQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetUsersUseCasesQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 31;

        public string Name => "Search UserUseCases";

        public PagedResponse<ReadUserUseCaseDto> Execute(UserUseCaseSearch search)
        {
            var query = _context.UserUseCases.AsQueryable();

            if(!string.IsNullOrEmpty(search.UserEmail) || !string.IsNullOrWhiteSpace(search.UserEmail))
            {
                query = query.Where(x => x.User.Email.ToLower().Contains(search.UserEmail.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.UseCaseName) || !string.IsNullOrWhiteSpace(search.UseCaseName))
            {
                query = query.Where(x => x.UseCase.Name.ToLower().Contains(search.UseCaseName.ToLower()));
            }
            if (search.UserId != null) 
            {
                query = query.Where(x => x.User.Id == search.UserId);
            }

            if (search.UseCaseId != null)
            {
                query = query.Where(x => x.UseCase.Id == search.UseCaseId);
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<ReadUserUseCaseDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ReadUserUseCaseDto
                {
                    Id = x.Id,
                    UserId = x.User.Id,
                    UserEmail = x.User.Email,
                    UseCaseId = x.UseCase.Id,
                    UseCaseName = x.UseCase.Name
                }).ToList()
            };

            return response;

        }
    }
}
