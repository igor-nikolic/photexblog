using Application.DTO;
using Application.Queries;
using Application.Queries.User;
using Application.SearchDto;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.User
{
    public class EfGetUsersQuery : IGetUsersQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetUsersQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 22;

        public string Name => "Search Users";

        public PagedResponse<ReadUserDto> Execute(UserSearch search)
        {
            var query = _context.Users.AsQueryable();

            if(!string.IsNullOrEmpty(search.Email) || !string.IsNullOrWhiteSpace(search.Email))
            {
                query = query.Where(x => x.Email.ToLower().Contains(search.Email.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.FirstName) || !string.IsNullOrWhiteSpace(search.FirstName))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(search.FirstName.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.LastName) || !string.IsNullOrWhiteSpace(search.LastName))
            {
                query = query.Where(x => x.LastName.ToLower().Contains(search.LastName.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<ReadUserDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ReadUserDto
                {
                    Id=x.Id,
                    FirstName=x.FirstName,
                    LastName=x.LastName,
                    Email=x.Email,
                    NumberOfComments=x.Comments.Count(),
                    NumberOfPosts = x.Posts.Count(),
                    NumberOfRatings = x.Ratings.Count()
                }).ToList()
            };

            return response;
        }
    }
}
