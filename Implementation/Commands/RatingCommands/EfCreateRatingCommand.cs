using Application.Commands.Rating;
using Application.DTO;
using Application.UseCase;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.RatingValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.RatingCommands
{
    public class EfCreateRatingCommand : ICreateRatingCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly CreateRatingValidator _validator;
        private readonly IApplicationActor _actor;

        public EfCreateRatingCommand(PhoTexBlogContext context, CreateRatingValidator validator, IApplicationActor actor)
        {
            _context = context;
            _validator = validator;
            _actor = actor;
        }

        public int Id => 10;

        public string Name => "Create Rating";

        public void Execute(RatingDto request)
        {
            request.UserId = _actor.Id;
            _validator.ValidateAndThrow(request);
            var rating = new Rating 
            {
                UserId = _actor.Id,
                PostId = request.PostId,
                Value = request.Value
            };
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }
    }
}
