﻿using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.User
{
    public interface IDeleteUserCommand : ICommand<int>
    {
    }
}
