using Application.UseCase;
using System;

namespace Application.Exceptions
{
    public class UnauthorizedUseCaseException : Exception
    {
        public UnauthorizedUseCaseException(IUseCase useCase) 
            : base($"awd")
        {

        }
    }
}
