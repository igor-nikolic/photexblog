using Application.DTO;
using EFDataAccess;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                .WithMessage("Name is required!")
                .Must(name => NotExists(name))
                .WithMessage("Topic with that name already exists!");
            
        }
        private bool NotExists(string name)
        {
            return !_context.Topics.Any(x => x.Name == name);
        }
    }
}
