using Application.Commands.Comments;
using Application.DTO;
using Application.UseCase;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.CommentValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.CommentCommands
{
    public class EfCreateCommentCommand : ICreateCommentCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly CreateCommentValidator _validator;
        private readonly IApplicationActor _actor;

        public EfCreateCommentCommand(PhoTexBlogContext context, CreateCommentValidator validator, IApplicationActor actor)
        {
            _context = context;
            _validator = validator;
            _actor = actor;
        }

        public int Id => 12;

        public string Name => "Create Comment";

        public void Execute(CommentDto request)
        {
            _validator.ValidateAndThrow(request);
            var comment = new Comment 
            { 
                CommentText = request.CommentText,
                PostId = request.PostId,
                UserId = _actor.Id
            };
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
