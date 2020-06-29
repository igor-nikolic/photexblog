using Application.DTO;
using EFDataAccess;
using FluentValidation;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Implementation.Validators.RatingValidators
{
    public class CreateRatingValidator : AbstractValidator<RatingDto>
    {
        private readonly PhoTexBlogContext _context;
        public CreateRatingValidator(PhoTexBlogContext context)
        {
            _context = context;
            RuleFor(x => x.Value)
                .NotEmpty().WithMessage("Value is required")
                .InclusiveBetween(1, 10).WithMessage("Value range is from 1 to 10");

            RuleFor(x => x.PostId)
                .NotEmpty().WithMessage("PostId is required!")
                .Must(id => PostExists(id)).WithMessage("Post with that Id doesn't exist!");
            RuleFor(x => x)
                .Must(x => UserNotRated(x))
                .WithMessage("You have already rated this post!");
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(x => x.Id == id);
        }
        private bool UserNotRated(RatingDto dto) 
        {
            return !_context.Ratings.Any(x => x.PostId == dto.PostId && x.UserId == dto.UserId);
        }
    }
}
