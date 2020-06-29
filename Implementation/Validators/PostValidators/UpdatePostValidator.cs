using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.PostValidators
{
    public class UpdatePostValidator : AbstractValidator<PostDto>
    {
        private readonly PhoTexBlogContext _context;
        public UpdatePostValidator(PhoTexBlogContext context)
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

            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required!")
                .Must(id => Exist(id))
                .WithMessage("Post with that id doesn't exist!");
        }
        private bool TopicExists(int id)
        {
            return _context.Topics.Any(t => t.Id == id);
        }
        private bool Exist(int id) 
        {
            return _context.Posts.Any(x => x.Id == id);
        }
    }
}
