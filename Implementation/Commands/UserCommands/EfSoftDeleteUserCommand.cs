using Application.Commands.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.UserCommands
{
    public class EfSoftDeleteUserCommand : IDeleteUserCommand
    {
        public int Id => 2222222;

        public string Name => "Delete User";

        public void Execute(int request)
        {
            throw new NotImplementedException();
        }
    }
}
