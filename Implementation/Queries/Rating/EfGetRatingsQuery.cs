using Application.DTO;
using Application.Queries;
using Application.Queries.Rating;
using Application.SearchDto;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.Rating
{
    public class EfGetRatingsQuery : IGetRatingsQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetRatingsQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 24;

        public string Name => "Search Ratings";

        public PagedResponse<ReadRatingDto> Execute(RatingSearch search)
        {
            var query = _context.Ratings.AsQueryable();

            if(!string.IsNullOrEmpty(search.UserEmail) || !string.IsNullOrWhiteSpace(search.UserEmail))
            {
                query = query.Where(x => x.User.Email.ToLower().Contains(search.UserEmail.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.PostTitle) || !string.IsNullOrWhiteSpace(search.PostTitle))
            {
                query = query.Where(x => x.Post.Title.ToLower().Contains(search.PostTitle.ToLower()));
            }

            if (search.MinRatingValue != null) 
            {
                query = query.Where(x => x.Value >= search.MinRatingValue);
            }

            if(search.MaxRatingValue != null)
            {
                query = query.Where(x => x.Value <= search.MaxRatingValue);
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<ReadRatingDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ReadRatingDto
                {
                    Id=x.Id,
                    Value=x.Value,
                    UserEmail=x.User.Email,
                    UserId=x.User.Id,
                    PostId=x.Post.Id,
                    PostTitle=x.Post.Title
                }).ToList()
            };
            return response;

        }
    }
}
