using Application.Commands.Post;
using Application.DTO;
using Application.Exceptions;
using Application.UseCase;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.PostValidators;
using System;

namespace Implementation.Commands.PostCommands
{
    public class EfUpdatePostCommand : IUpdatePostCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly UpdatePostValidator _validator;
        private readonly IApplicationActor _actor;

        public EfUpdatePostCommand(PhoTexBlogContext context, UpdatePostValidator validator, IApplicationActor actor)
        {
            _context = context;
            _validator = validator;
            _actor = actor;
        }

        public int Id => 9;

        public string Name => "Update Post";

        public void Execute(PostDto request)
        {
            
            _validator.ValidateAndThrow(request);
            var post = _context.Posts.Find(request.Id);
            if (_actor.Id != post.UserId) throw new ForbiddenUseCaseException(_actor, this.Name, request.Id);            
            post.Title = request.Title;
            post.Content = request.Content;
            post.PhotoPath = request.PhotoPath;
            post.TopicId = request.TopicId;
            _context.SaveChanges();         

        }
    }
}
