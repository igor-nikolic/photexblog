using Application.Commands.User;
using Application.Exceptions;
using Application.UseCase;
using Domain;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Implementation.Commands.UserCommands
{
    public class EfSoftDeleteUserCommand : IDeleteUserCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly IApplicationActor _actor;

        public EfSoftDeleteUserCommand(PhoTexBlogContext context, IApplicationActor actor)
        {
            _context = context;
            _actor = actor;
        }

        public int Id => 2;

        public string Name => "Soft Delete User";

        public void Execute(int request)
        {
            var user = _context.Users.Find(request);
            if (user == null) throw new EntityNotFoundException(request, typeof(User));
            if (user.Id != _actor.Id) throw new ForbiddenUseCaseException(_actor, this.Name, request);

            user.DeletedAt = DateTime.Now;
            user.Visible = false;
            _context.SaveChanges();
        }
    }
}
