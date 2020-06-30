using Application.Commands.UseCase;
using Application.DTO;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.UseCaseValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.UseCaseCommands
{
    
    public class EfCreateUseCaseCommand : ICreateUseCaseCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly CreateUseCaseValidator _validator;

        public EfCreateUseCaseCommand(PhoTexBlogContext context, CreateUseCaseValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 26;

        public string Name => "Create UseCase";

        public void Execute(UseCaseDto request)
        {
            _validator.ValidateAndThrow(request);

            var useCase = new UseCase { 
            Name=request.Name
            };
            _context.UseCases.Add(useCase);
            _context.SaveChanges();
        }
    }
}
