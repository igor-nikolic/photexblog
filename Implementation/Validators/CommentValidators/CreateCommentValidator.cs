using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.CommentValidators
{
    public class CreateCommentValidator : AbstractValidator<CommentDto>
    {
        private readonly PhoTexBlogContext _context;
        public CreateCommentValidator(PhoTexBlogContext context)
        {
            _context = context;
            RuleFor(x => x.CommentText)
                .NotEmpty().WithMessage("CommentText is required!")
                .MinimumLength(10).WithMessage("CommentText must have at least 10 characters!");

            RuleFor(x => x.PostId)
                .NotEmpty().WithMessage("PostId is required!")
                .Must(id => PostExist(id)).WithMessage("Post with that id doesn't exist!");
            
        }
        private bool PostExist(int postId)
        {
            return _context.Posts.Any(x => x.Id == postId);
        }
    }
}
