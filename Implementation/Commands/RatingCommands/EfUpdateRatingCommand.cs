using Application.Commands.Rating;
using Application.DTO;
using Application.Exceptions;
using Application.UseCase;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.RatingValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.RatingCommands
{
    public class EfUpdateRatingCommand : IUpdateRatingCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly IApplicationActor _actor;
        private readonly UpdateRatingValidator _validator;

        public EfUpdateRatingCommand(PhoTexBlogContext context, IApplicationActor actor, UpdateRatingValidator validator)
        {
            _context = context;
            _actor = actor;
            _validator = validator;
        }

        public int Id => 11;

        public string Name => "Update Rating";

        public void Execute(RatingDto request)
        {
            request.UserId = _actor.Id;
            _validator.ValidateAndThrow(request);
            var rating = _context.Ratings.Find(request.Id);
            if(rating.UserId != _actor.Id) throw new ForbiddenUseCaseException(_actor, this.Name, request.Id);
            rating.Value = request.Value;
            _context.SaveChanges();
        }
    }
}
