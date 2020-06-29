using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.UserValidators
{
    public class UpdateUserValidator : AbstractValidator<UserDto>
    {
        private readonly PhoTexBlogContext _context;
        public UpdateUserValidator(PhoTexBlogContext context)
        {
            _context = context;

            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required!")
                .Must(id => Exist(id))
                .WithMessage("User with that ID doesn't exist!");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required!")
                .MinimumLength(3)
                .WithMessage("First name must have at least 3 letters!");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is required!")
                .MinimumLength(5)
                .WithMessage("Last name must have at least 5 letters!");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required!")
                .EmailAddress()
                .WithMessage("Invalid email format");

            RuleFor(x => x)
                .Must(x => BeUnique(x))
                .WithMessage("Email already taken!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required!")
                .MinimumLength(5)
                .WithMessage("Password must have at least 5 characters");
        }
        private bool BeUnique(UserDto dto)
        {
            return !_context.Users.Any(u => u.Email == dto.Email && u.Id != dto.Id);
        }
        private bool Exist(int id)
        {
            return _context.Users.Any(x => x.Id == id);
        }
    }
}
