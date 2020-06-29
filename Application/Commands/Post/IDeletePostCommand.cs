using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Application.Commands.Post
{
    public interface IDeletePostCommand : ICommand<int>
    {
    }
}
