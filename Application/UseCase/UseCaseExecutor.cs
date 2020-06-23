using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase
{
    public class UseCaseExecutor
    {
        //private readonly IApplicationActor actor;
        private readonly IUseCaseLogger logger;

        public UseCaseExecutor(IUseCaseLogger logger)
        {
            this.logger = logger;
        }

        public TResult ExecuteQuery<TSearch, TResult>(IQuery<TSearch, TResult> query, TSearch search)
        {
            logger.Log(query, search);

            //if (!actor.AllowedUseCases.Contains(query.Id))
            //{
            //    throw new UnauthorizedUseCaseException(query, actor);
            //}

            return query.Execute(search);
        }

        public void ExecuteCommand<TRequest>(
            ICommand<TRequest> command,
            TRequest request)
        {
            logger.Log(command, request);
            // 1 (1,2,3,4)
            //if (!actor.AllowedUseCases.Contains(command.Id))
            //{
            //    throw new UnauthorizedUseCaseException(command, actor);
            //}

            command.Execute(request);

        }
    }
}
