using Application.DTO;
using Application.Queries;
using Application.Queries.Comment;
using Application.SearchDto;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.Comment
{
    public class EfGetCommentsQuery : IGetCommentsQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetCommentsQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 20;

        public string Name => "Search Comments";

        public PagedResponse<ReadCommentDto> Execute(CommentSearch search)
        {
            var query = _context.Comments.Include(x => x.User).AsQueryable();

            if(!string.IsNullOrEmpty(search.Comment) || !string.IsNullOrWhiteSpace(search.Comment))
            {
                query = query.Where(x => x.CommentText.ToLower().Contains(search.Comment.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.PostTitle) || !string.IsNullOrWhiteSpace(search.PostTitle))
            {
                query = query.Where(x => x.Post.Title.ToLower().Contains(search.PostTitle.ToLower()));
            }

            if(!string.IsNullOrEmpty(search.UserEmail) || !string.IsNullOrWhiteSpace(search.UserEmail))
            {
                query = query.Where(x => x.User.Email.ToLower().Contains(search.UserEmail.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<ReadCommentDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ReadCommentDto
                {
                    Id = x.Id,
                    CommentText = x.CommentText,
                    UserId=x.User.Id,
                    UserEmail=x.User.Email,
                    PostId = x.Post.Id,
                    PostTitle=x.Post.Title
                }).ToList()
            };
            return response;
        }
    }
}
