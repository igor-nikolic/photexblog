using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.UseCaseValidators
{
    public class UpdateUseCaseValidator : AbstractValidator<UseCaseDto>
    {
        private readonly PhoTexBlogContext _context;

        public UpdateUseCaseValidator(PhoTexBlogContext context)
        {
            _context = context;
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required!")
                .Must(id => Exist(id)).WithMessage("UseCase with that ID doesn't exist");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required!");

            RuleFor(x => x)
                .Must(x => BeUnique(x)).WithMessage("UseCase already exists!");
                
                
        }
        private bool Exist(int id) 
        {
            return _context.UseCases.Any(x => x.Id == id);
        }
        private bool BeUnique(UseCaseDto dto)
        {
            return !_context.UseCases.Any(x => x.Name == dto.Name && x.Id != dto.Id);
        }
    }
}
