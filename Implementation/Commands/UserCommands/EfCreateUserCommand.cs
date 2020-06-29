using Application.Commands;
using Application.DTO;
using Application.Email;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.UserValidators;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

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

            //byte[] salt = new byte[128 / 8];
            //Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");
            //using (var rng = RandomNumberGenerator.Create())
            //{
            //    Console.WriteLine($"RNG {rng}");
            //    rng.GetBytes(salt);
            //}
            byte[] salt = Convert.FromBase64String("olK4MOHPZ8IgkmfD17+oyg==");
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: request.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            Console.WriteLine($"Hashed: {hashed}");

            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = hashed
            };
            _context.Users.Add(user);
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
