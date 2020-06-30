using Application.Commands;
using Application.DTO;
using Application.Email;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.UserValidators;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;

namespace Implementation.Commands.UserCommands
{
    public class EfCreateUserCommand : ICreateUserCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly CreateUserValidator _validator;
        private readonly IEmailSender _sender;

        public EfCreateUserCommand(PhoTexBlogContext context, CreateUserValidator validator, IEmailSender sender)
        {
            _context = context;
            _validator = validator;
            _sender = sender;
        }

        public int Id => 1;

        public string Name => "Create User";

        public void Execute(UserDto request)
        {
            _validator.ValidateAndThrow(request);
            byte[] salt = Convert.FromBase64String("olK4MOHPZ8IgkmfD17+oyg==");

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: request.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));


            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = hashed
            };
            _context.Users.Add(user);
            _context.SaveChanges();

            var userusecase = new List<Domain.UserUseCase> 
            {
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =1 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =2 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =3 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =7 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =8 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =9 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =10 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =11 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =12 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =13 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =14 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =16 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =17 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =18 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =19 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =20 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =21 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =22 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =23 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =24 },
            new Domain.UserUseCase{ UserId = user.Id,UseCaseId =25 }
            };
            _context.UserUseCases.AddRange(userusecase);
            _context.SaveChanges();


            _sender.Send(new SendEmailDto
            {
                Content = "You have been registered!",
                SendTo = request.Email,
                Subject= "Registration Confirmation"
            });
        }
    }
}
