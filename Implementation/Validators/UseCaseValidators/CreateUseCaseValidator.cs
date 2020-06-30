using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.UseCaseValidators
{
    public class CreateUseCaseValidator : AbstractValidator<UseCaseDto>
    {
        private readonly PhoTexBlogContext _context;
        public CreateUseCaseValidator(PhoTexBlogContext context)
        {
            _context = context;
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name must not be empty!")
                .Must(name => NotExists(name)).WithMessage("UseCase already exists!");
                
        }
        private bool NotExists(string name)
        {
            return !_context.UseCases.Any(x => x.Name == name);
        }
    }
}
