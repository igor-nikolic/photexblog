using Application.DTO;
using EFDataAccess;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.TopicValidators
{
    
    public class UpdateTopicValidator : AbstractValidator<TopicDto>
    {
        private readonly PhoTexBlogContext _context;

        public UpdateTopicValidator(PhoTexBlogContext context)
        {
            _context = context;

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name must not be empty!");

            
            RuleFor(x => x.Id)
                .NotEmpty()
                .Must(id => exist(id))
                .WithMessage("Topic with that id doesn't exist!");


            RuleFor(x => x)
                .NotEmpty()
                .Must(x => BeUnique(x))
                .WithMessage($"Topic already exists!");
        }

        private bool exist(int id)
        {
            return _context.Topics.Any(x => x.Id == id);
        }
        private bool BeUnique(TopicDto dto) 
        {
            return !_context.Topics.Any(t => t.Name == dto.Name && t.Id != dto.Id);
        }
    }
}
