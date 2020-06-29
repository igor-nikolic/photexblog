using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Validators.RatingValidators
{
    public class UpdateRatingValidator : AbstractValidator<RatingDto>
    {
        private readonly PhoTexBlogContext _context;
        public UpdateRatingValidator(PhoTexBlogContext context)
        {
            _context = context;
            RuleFor(x => x.Value)
                .NotEmpty().WithMessage("Value is required")
                .InclusiveBetween(1, 10).WithMessage("Value range is from 1 to 10");

            RuleFor(x => x)
                .Must(x => UserRated(x))
                .WithMessage("You haven't rated this post!");

            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required!")
                .Must(id => Exist(id)).WithMessage("Rating with that id doesn't exist");

            RuleFor(x => x.PostId)
                .NotEmpty().WithMessage("PostId is required!");
                

        }
        private bool UserRated(RatingDto dto)
        {
            return _context.Ratings.Any(x => x.UserId == dto.UserId && x.PostId == dto.PostId);
        }
        private bool Exist(int id)
        {
            return _context.Ratings.Any(x => x.Id == id);
        }

    }
}
