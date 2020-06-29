using Application.DTO;
using Application.Queries;
using Application.Queries.UseCaseLog;
using Application.SearchDto;
using AutoMapper;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Implementation.Queries.UseCaseLog
{
    public class EfGetUseCaseLogsQuery : IGetUseCaseLogsQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetUseCaseLogsQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 15;

        public string Name => "Search UseCaseLog";

        public PagedResponse<UseCaseLogDto> Execute(UseCaseLogSearch search)
        {
            var query = _context.UseCaseLogs.Include(x => x.User).Include(x => x.UseCase).AsQueryable();

            if (!string.IsNullOrEmpty(search.UseCaseName) || !string.IsNullOrWhiteSpace(search.UseCaseName))
            {
                query = query.Where(x => x.UseCase.Name.ToLower().Contains(search.UseCaseName.ToLower()));
                // query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(search.UserEmail) || !string.IsNullOrWhiteSpace(search.UserEmail))
            {
                query = query.Where(x => x.User.Email.ToLower().Contains(search.UserEmail.ToLower()));
            }            

            if (search.StartDate != null) query = query.Where(x => x.Date >= search.StartDate);
            if (search.EndDate != null) query = query.Where(x => x.Date <= search.EndDate);

            var skipCount = search.PerPage * (search.Page - 1);


            var response = new PagedResponse<UseCaseLogDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new UseCaseLogDto
                {
                    Id = x.Id,
                    Data = x.Data,
                    Date = x.Date,
                    UseCaseId = x.UseCase.Id,
                    UseCaseName = x.UseCase.Name,
                    UserId = x.User.Id,
                    UserEmail=x.User.Email
                }).ToList()
            };

            return response;
        }
    }
}
