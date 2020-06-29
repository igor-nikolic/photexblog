using Application.Commands.Comments;
using Application.Exceptions;
using Application.UseCase;
using Domain;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.CommentCommands
{
    public class EfSoftDeleteCommentCommand : IDeleteCommentCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly IApplicationActor _actor;

        public EfSoftDeleteCommentCommand(PhoTexBlogContext context, IApplicationActor actor)
        {
            _context = context;
            _actor = actor;
        }

        public int Id => 13;

        public string Name => "Soft Delete Comment";

        public void Execute(int request)
        {
            var comment = _context.Comments.Find(request);
            if (comment == null) throw new EntityNotFoundException(request, typeof(Comment));
            if (comment.UserId != _actor.Id) throw new ForbiddenUseCaseException(_actor, this.Name, request);

            comment.DeletedAt = DateTime.Now;
            comment.Visible = false;
            _context.SaveChanges();
        }
    }
}
