using Application.DTO;
using Application.Exceptions;
using Application.Queries.User;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.User
{
    public class EfGetOneUserQuery : IGetOneUserQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetOneUserQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 23;

        public string Name => "Get One User";

        public ReadUserDto Execute(int search)
        {
            var user = _context.Users
                .Include(x => x.Comments)
                .Include(x => x.Ratings)
                .Include(x => x.Posts)
                .SingleOrDefault(x => x.Id == search);

            if (user == null) throw new EntityNotFoundException(search,typeof(Domain.User));

            return new ReadUserDto { 
            Id=user.Id,
            FirstName=user.FirstName,
            LastName=user.LastName,
            Email=user.Email,
            NumberOfComments = user.Comments.Count(),
            NumberOfPosts = user.Posts.Count(),
            NumberOfRatings = user.Ratings.Count()
            };
        }
    }
}
