using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Exceptions
{
    public class ForbiddenUseCaseException : Exception
    {
        public ForbiddenUseCaseException(IApplicationActor actor,string actionName,int entityId) 
            : base($"Actor with an id of {actor.Id} - {actor.Identity} tried to {actionName} with an id of {entityId}.")
        {

        }
    }
}
