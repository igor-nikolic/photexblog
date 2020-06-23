using Application.DTO;
using EFDataAccess;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.PostValidators
{
    public class CreatePostValidator : AbstractValidator<PostDto>
    {
        private readonly PhoTexBlogContext _context;
        public CreatePostValidator(PhoTexBlogContext context)
        {
            _context = context;
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is required!")
                .MinimumLength(3)
                .WithMessage("Title must have at least 3 characters!");

            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage("Content is required!")
                .MinimumLength(20)
                .WithMessage("Content must have at least 20 characters!");


            RuleFor(x => x.TopicId)
                .NotEmpty()
                .WithMessage("TopicId is required!")
                .Must(id => TopicExists(id))
                .WithMessage("Topic with that id doesn't exist!");

            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("UserId is required!")
                .Must(id => UserExists(id))
                .WithMessage("User with that id doesn't exist!");

        }
        private bool TopicExists(int id)
        {
            return _context.Topics.Any(t => t.Id == id);
        }
        private bool UserExists(int id)
        {
            return _context.Users.Any(u => u.Id == id);
        }
    }
}
