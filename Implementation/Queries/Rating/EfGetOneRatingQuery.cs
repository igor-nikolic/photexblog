using Application.DTO;
using Application.Exceptions;
using Application.Queries.Rating;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.Rating
{
    public class EfGetOneRatingQuery : IGetOneRatingQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetOneRatingQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 25;

        public string Name => "Get One Rating";

        public ReadRatingDto Execute(int search)
        {
            var rating = _context.Ratings.Include(x => x.User).Include(x => x.Post).SingleOrDefault(x => x.Id == search);
            if (rating == null) throw new EntityNotFoundException(search,typeof(Domain.Rating));

            return new ReadRatingDto { 
                Id=rating.Id,
                PostId = rating.Post.Id,
                PostTitle=rating.Post.Title,
                UserEmail=rating.User.Email,
                UserId=rating.User.Id,
                Value=rating.Value
            };
        }
    }
}
