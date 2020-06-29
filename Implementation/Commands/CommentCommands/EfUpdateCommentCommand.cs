using Application.Commands.Comments;
using Application.DTO;
using Application.Exceptions;
using Application.UseCase;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.CommentValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.CommentCommands
{
    public class EfUpdateCommentCommand : IUpdateCommentCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly IApplicationActor _actor;
        private readonly UpdateCommentValidator _validator;

        public EfUpdateCommentCommand(PhoTexBlogContext context, IApplicationActor actor, UpdateCommentValidator validator)
        {
            _context = context;
            _actor = actor;
            _validator = validator;
        }

        public int Id => 14;

        public string Name => "Update Comment";

        public void Execute(CommentDto request)
        {
            _validator.ValidateAndThrow(request);
            var comment = _context.Comments.Find(request.Id);
            if (comment.UserId != _actor.Id) throw new ForbiddenUseCaseException(_actor, this.Name, request.Id);
            comment.CommentText = request.CommentText;
            _context.SaveChanges();
        }
    }
}
