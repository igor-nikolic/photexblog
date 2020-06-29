using Application.DTO;
using Application.Exceptions;
using Application.Queries.Post;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.Post
{
    public class EfGetOnePostQuery : IGetOnePostQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetOnePostQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 19;

        public string Name => "Get One Post";

        public ReadPostDto Execute(int search)
        {
            var post = _context.Posts
                .Include(x => x.Topic)
                .Include(x => x.User)
                .Include(x => x.Comments)
                .Include(x => x.Ratings)
                .SingleOrDefault(x => x.Id == search);
            
            if (post == null) throw new EntityNotFoundException(search,typeof(Domain.Post));
            return new ReadPostDto 
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                UserId = post.User.Id,
                UserEmail = post.User.Email,
                Topic = post.Topic.Name,
                PhotoPath = post.PhotoPath,
                TotalComments = post.Comments.Count(),
                TotalRatings = post.Ratings.Count(),
                AverageRating = post.Ratings.Count() > 0 ? Decimal.Round((decimal)post.Ratings.Sum(y => y.Value) / post.Ratings.Count(), 1) : 0
            };
        }
    }
}
