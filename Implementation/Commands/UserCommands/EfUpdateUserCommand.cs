using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.UseCase;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.UserValidators;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.UserCommands
{
    public class EfUpdateUserCommand : IUpdateUserCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly UpdateUserValidator _validator;
        private readonly IApplicationActor _actor;

        public EfUpdateUserCommand(PhoTexBlogContext context, UpdateUserValidator validator, IApplicationActor actor)
        {
            _context = context;
            _validator = validator;
            _actor = actor;
        }

        public int Id => 3;

        public string Name => "Update User";

        public void Execute(UserDto request)
        {
            _validator.ValidateAndThrow(request);
            if(request.Id != _actor.Id) throw new ForbiddenUseCaseException(_actor, this.Name, request.Id);
            byte[] salt = Convert.FromBase64String("olK4MOHPZ8IgkmfD17+oyg==");

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: request.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            var user = _context.Users.Find(request.Id);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = hashed;
            _context.SaveChanges();
        }
    }
}
