using Application.DTO;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public interface IUpdateUserCommand : ICommand<UserDto>
    {
    }
}
