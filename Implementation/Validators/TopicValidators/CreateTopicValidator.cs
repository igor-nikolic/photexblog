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
    public class CreateTopicValidator : AbstractValidator<TopicDto>
    {
        private readonly PhoTexBlogContext _context;
        public CreateTopicValidator(PhoTexBlogContext context)
        {
            _context = context;
            RuleFor(x => x.Name)
                .NotEmpty()
                .Must(name => BeUnique(name))
                .WithMessage("Topic with that name already exists in database!");            
        }
        private bool BeUnique(string name) 
        {
            return !_context.Topics.Any(t => t.Name == name);
        }
    }
}
