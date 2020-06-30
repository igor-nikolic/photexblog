using Application.Commands.UseCase;
using Application.DTO;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.UseCaseValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.UseCaseCommands
{
    public class EfUpdateUseCaseCommand : IUpdateUseCaseCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly UpdateUseCaseValidator _validator;

        public EfUpdateUseCaseCommand(PhoTexBlogContext context, UpdateUseCaseValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 27;

        public string Name => "Update UseCase";

        public void Execute(UseCaseDto request)
        {
            _validator.ValidateAndThrow(request);
            var usecase = _context.UseCases.Find(request.Id);
            usecase.Name = request.Name;
            _context.SaveChanges();
        }
    }
}
