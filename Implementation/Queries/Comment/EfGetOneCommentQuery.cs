using Application.DTO;
using Application.Exceptions;
using Application.Queries.Comment;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.Comment
{
    public class EfGetOneCommentQuery : IGetOneCommentQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetOneCommentQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 21;

        public string Name => "Get One Comment";

        public ReadCommentDto Execute(int search)
        {
            var comment = _context.Comments.Include(x => x.User).Include(x => x.Post).SingleOrDefault(x => x.Id == search);
            if (comment == null) throw new EntityNotFoundException(search,typeof(Domain.Comment));
            return new ReadCommentDto 
            {
                Id = comment.Id,
                CommentText = comment.CommentText,
                PostId = comment.PostId,
                PostTitle = comment.Post.Title,
                UserEmail = comment.User.Email,
                UserId = comment.User.Id
            };
        }
    }
}
