using Application.Commands.UserUseCase;
using Application.DTO;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.UserUseCaseValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.UserUseCase
{
    public class EfCreateUserUseCaseCommand : ICreateUserUseCaseCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly CreateUserUseCaseValidator _validator;

        public EfCreateUserUseCaseCommand(PhoTexBlogContext context, CreateUserUseCaseValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 30;

        public string Name => "Create UserUseCase";

        public void Execute(UserUseCaseDto request)
        {
            _validator.ValidateAndThrow(request);

            var userusecase = new Domain.UserUseCase 
            {
                UseCaseId = request.UseCaseId,
                UserId = request.UserId
            };

            _context.UserUseCases.Add(userusecase);
            _context.SaveChanges();
        }
    }
}
