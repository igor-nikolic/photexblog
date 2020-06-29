using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.CommentValidators
{
    public class UpdateCommentValidator : AbstractValidator<CommentDto>
    {
        private readonly PhoTexBlogContext _context;
        public UpdateCommentValidator(PhoTexBlogContext context)
        {
            _context = context;

            RuleFor(x => x.CommentText)
                .NotEmpty().WithMessage("CommentText is required!")
                .MinimumLength(10).WithMessage("CommentText must have at least 10 characters!");

            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required!")
                .Must(id => Exist(id)).WithMessage("Comment with that ID doesn't exist");
        }
        private bool Exist(int id)
        {
            return _context.Comments.Any(x => x.Id == id);
        }
    }
}
