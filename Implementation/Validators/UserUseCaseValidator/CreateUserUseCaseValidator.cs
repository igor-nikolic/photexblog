using Application.DTO;
using EFDataAccess;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.UserUseCaseValidator
{
    public class CreateUserUseCaseValidator : AbstractValidator<UserUseCaseDto>
    {
        private readonly PhoTexBlogContext _context;

        public CreateUserUseCaseValidator(PhoTexBlogContext context)
        {
            _context = context;

            RuleFor(x => x.UseCaseId)
                .NotEmpty().WithMessage("UseCaseId is required!")
                .Must(id => UseCaseExists(id)).WithMessage("UseCase with that id doesn't exist");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId is required!")
                .Must(id => UserExists(id)).WithMessage("User with that ID doesn't exist!");

            RuleFor(x => x)
                .Must(x => NotExist(x)).WithMessage("This user already has that privilege!");
        }
        private bool NotExist(UserUseCaseDto dto)
        {
            return !_context.UserUseCases.Any(x => x.UserId == dto.UserId && x.UseCaseId == dto.UseCaseId);
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(x => x.Id == id);
        }

        private bool UseCaseExists(int id)
        {
            return _context.UseCases.Any(x => x.Id == id);
        }
    }
}
