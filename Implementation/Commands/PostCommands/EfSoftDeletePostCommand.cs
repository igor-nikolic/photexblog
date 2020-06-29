using Application.Commands.Post;
using Application.Exceptions;
using Application.UseCase;
using Domain;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.PostCommands
{
    public class EfSoftDeletePostCommand : IDeletePostCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly IApplicationActor _actor;

        public EfSoftDeletePostCommand(PhoTexBlogContext context, IApplicationActor actor)
        {
            _context = context;
            _actor = actor;
        }

        public int Id => 8;

        public string Name => "Soft Delete Post";

        public void Execute(int request)
        {
            var post = _context.Posts.Find(request);
            if (post == null) throw new EntityNotFoundException(request, typeof(Post));
            if (_actor.Id != post.UserId) throw new ForbiddenUseCaseException(_actor,this.Name, request);

            post.DeletedAt = DateTime.Now;
            post.Visible = false;
            _context.SaveChanges();

        }
    }
}
