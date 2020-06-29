using Application.DTO;
using Application.Queries;
using Application.Queries.Post;
using Application.SearchDto;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.Post
{
    public class EfGetPostsQuery : IGetPostsQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetPostsQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 17;

        public string Name => "Search Posts";

        public PagedResponse<ReadPostDto> Execute(PostSearch search)
        {
            var query = _context.Posts
                .Include(x =>x.Topic)
                .Include(x=>x.User).AsQueryable();

            if(!string.IsNullOrEmpty(search.Title) || !string.IsNullOrWhiteSpace(search.Title))
            {
                query = query.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.Topic) || !string.IsNullOrWhiteSpace(search.Topic))
            {
                query = query.Where(x => x.Topic.Name.ToLower().Contains(search.Topic));
            }

            if(!string.IsNullOrEmpty(search.Content) || !string.IsNullOrWhiteSpace(search.Content))
            {
                query = query.Where(x => x.Content.ToLower().Contains(search.Content.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.UserEmail) || !string.IsNullOrWhiteSpace(search.UserEmail))
            {
                query = query.Where(x => x.User.Email.ToLower().Contains(search.UserEmail.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<ReadPostDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ReadPostDto
                {
                    Id = x.Id,
                    Title=x.Title,
                    Content=x.Content,
                    UserId = x.User.Id,
                    UserEmail = x.User.Email,
                    Topic = x.Topic.Name,
                    PhotoPath = x.PhotoPath,
                    TotalComments = x.Comments.Count(),
                    TotalRatings = x.Ratings.Count(),
                    AverageRating = x.Ratings.Count() > 0 ? Decimal.Round((decimal)x.Ratings.Sum(y => y.Value) / x.Ratings.Count(), 1) : 0
                }).ToList()
            };
            return response;
        }
    }
}
