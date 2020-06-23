using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.UserValidators
{
    public class CreateUserValidator : AbstractValidator<UserDto>
    {
        private readonly PhoTexBlogContext _context;
        public CreateUserValidator(PhoTexBlogContext context)
        {
            _context = context;
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
                .WithMessage("Invalid email format")
                .Must(email => UniqueEmail(email))
                .WithMessage("User already registered!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required!")
                .MinimumLength(5)
                .WithMessage("Password must have at least 5 characters");

        }

        private bool UniqueEmail(string email) 
        {
            return !_context.Users.Any(x => x.Email == email);
        }
    }
}
